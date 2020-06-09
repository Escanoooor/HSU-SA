using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading.Tasks;

using Firebase.BookClient.EL;

using Firebase.Database;
using Firebase.Database.Query;

namespace Firebase.BookClient.BLL
{
    class BookBUS1
    {
        private const String FIREBASE_APP = "https://sonkkdemos.firebaseio.com/";
        private FirebaseClient firebase = new FirebaseClient(FIREBASE_APP);

        public void ListenFirebase(DataGridView gridBook)
        {
            firebase.Child("books").AsObservable<Book>().Subscribe((item) => { UpdateDataGridView(gridBook); });
        }

        private async void UpdateDataGridView(DataGridView gridBook)
        {
            List<Book> books = await GetAll();
            gridBook.BeginInvoke(new MethodInvoker(delegate { gridBook.DataSource = books; })); // set asynchronous datasource
        }

        private async Task<List<Book>> GetAll()
        {
            List<Book> books = new List<Book>();
            var fbBooks = await firebase.Child("books").OnceAsync<Book>();
            foreach (var item in fbBooks)
                books.Add(item.Object);
            return books;
        }

        public async Task<Book> GetDetails(int code)
        {
            var fbBooks = await firebase.Child("books").OnceAsync<Book>();
            foreach (var item in fbBooks)
                if (item.Object.Code == code)
                    return item.Object;
            return null;
        }

        private async Task<String> GetKeyByCode(int code)
        {
            var fbBooks = await firebase.Child("books").OnceAsync<Book>();
            foreach (var item in fbBooks)
                if (item.Object.Code == code)
                    return item.Key;
            return null;
        }

        public async Task<List<Book>> Search(String keyword)
        {
            List<Book> books = new List<Book>();
            var fbBooks = await firebase.Child("books").OnceAsync<Book>();
            foreach (var item in fbBooks)
                if (item.Object.Name.ToLower().Contains(keyword.ToLower()))
                    books.Add(item.Object);
            return books;
        }

        public async Task<bool> AddNew(Book newBook)
        {
            try
            {
                //await firebase.Child("books").PostAsync(newBook); // auto-generated key
                await firebase.Child("books").Child("B" + newBook.Code).PutAsync(newBook); // custom key
                return true;
            } catch { return false; }
        }

        public async Task<bool> Update(Book newBook)
        {
            try
            {
                String key = await GetKeyByCode(newBook.Code);
                if (String.IsNullOrEmpty(key)) return false;
                await firebase.Child("books").Child(key).PutAsync(newBook);
                return true;
            } catch { return false; }
        }

        public async Task<bool> Delete(int code)
        {
            try
            {
                String key = await GetKeyByCode(code);
                if (String.IsNullOrEmpty(key)) return false;
                await firebase.Child("books").Child(key).DeleteAsync();
                return true;
            } catch { return false; }
        }
    }
}