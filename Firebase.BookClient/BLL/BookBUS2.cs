using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

using Firebase.BookClient.EL;

using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Firebase.BookClient.BLL
{
    class BookBUS2
    {
        static IFirebaseConfig config = new FirebaseConfig { BasePath = "https://sonkkdemos.firebaseio.com/" };
        static FirebaseClient client = new FirebaseClient(config);

        public async void ListenFirebase(DataGridView gridBook)
        {
            EventStreamResponse response = await client.OnAsync("books",
                added: (sender, args, context) => { UpdateDataGridView(gridBook); },
                changed: (sender, args, context) => { UpdateDataGridView(gridBook); },
                removed: (sender, args, context) => { UpdateDataGridView(gridBook); });
        }

        private void UpdateDataGridView(DataGridView gridBook)
        {
            List<Book> books = GetAll();
            gridBook.BeginInvoke(new MethodInvoker(delegate { gridBook.DataSource = books; })); // set asynchronous datasource
        }

        private List<Book> GetAll()
        {
            FirebaseResponse response = client.Get("books");
            Dictionary<String, Book> dictBooks = response.ResultAs<Dictionary<String, Book>>();
            return dictBooks.Values.ToList();
        }

        public Book GetDetails(int code)
        {
            FirebaseResponse response = client.Get("books/B" + code);
            Book book = response.ResultAs<Book>();
            return book;
        }

        private String GetKeyByCode(int code)
        {
            FirebaseResponse response = client.Get("books");
            Dictionary<String, Book> dictBooks = response.ResultAs<Dictionary<String, Book>>();
            String key = dictBooks.FirstOrDefault(x => x.Value.Code == code).Key;
            return key;
        }

        public List<Book> Search(String keyword)
        {
            List<Book> books = new List<Book>();
            foreach (var item in GetAll())
                if (item.Name.ToLower().Contains(keyword.ToLower()))
                    books.Add(item);
            return books;
        }

        public bool AddNew(Book newBook)
        {
            try
            {
                //client.Push("books", newBook); // auto-generated key
                client.Set("books/B" + newBook.Code, newBook); // custom key
                return true;
            }
            catch { return false; }
        }

        public bool Update(Book newBook)
        {
            try
            {
                String key = GetKeyByCode(newBook.Code);
                if (String.IsNullOrEmpty(key)) return false;
                client.Set("books/" + key, newBook);
                return true;
            }
            catch { return false; }
        }

        public bool Delete(int code)
        {
            try
            {
                String key = GetKeyByCode(code);
                if (String.IsNullOrEmpty(key)) return false;
                client.Delete("books/" + key);
                return true;
            }
            catch { return false; }
        }
    }
}