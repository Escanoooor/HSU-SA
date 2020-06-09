using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Firebase.BookClient.EL;
using Firebase.BookClient.BLL;

namespace Firebase.BookClient.PL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //new BookBUS1().ListenFirebase(gridBook);
            new BookBUS2().ListenFirebase(gridBook);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void gridBook_SelectionChanged(object sender, EventArgs e)
        {
            if (gridBook.SelectedRows.Count > 0)
            {
                int code = int.Parse(gridBook.SelectedRows[0].Cells["Code"].Value.ToString());
                //Book book = await new BookBUS1().GetDetails(code);
                Book book = new BookBUS2().GetDetails(code);
                if (book != null)
                {
                    txtBookCode.Text = book.Code.ToString();
                    txtBookName.Text = book.Name.ToString();
                    txtBookAuthor.Text = book.Author.ToString();
                    txtBookPrice.Text = book.Price.ToString();
                }
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            //List<Book> books = await new BookBUS1().Search(keyword);
            List<Book> books = new BookBUS2().Search(keyword);
            gridBook.BeginInvoke(new MethodInvoker(delegate { gridBook.DataSource = books; })); // set asynchronous datasource
        }

        private async void btAdd_Click(object sender, EventArgs e)
        {
            Book newBook = new Book()
            {
                Code = int.Parse(txtBookCode.Text.Trim()),
                Name = txtBookName.Text.Trim(),
                Author = txtBookAuthor.Text.Trim(),
                Price = int.Parse(txtBookPrice.Text.Trim())
            };
            //bool result = await new BookBUS1().AddNew(newBook);
            bool result = new BookBUS2().AddNew(newBook);
            if (!result) MessageBox.Show("SORRY BABY !!!");
        }

        private async void btUpdate_Click(object sender, EventArgs e)
        {
            Book newBook = new Book()
            {
                Code = int.Parse(txtBookCode.Text.Trim()),
                Name = txtBookName.Text.Trim(),
                Author = txtBookAuthor.Text.Trim(),
                Price = int.Parse(txtBookPrice.Text.Trim())
            };
            //bool result = await new BookBUS1().Update(newBook);
            bool result = new BookBUS2().Update(newBook);
            if (!result) MessageBox.Show("SORRY BABY !!!");
        }

        private async void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE ?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int code = int.Parse(txtBookCode.Text);
                //bool result = await new BookBUS1().Delete(code);
                bool result = new BookBUS2().Delete(code);
                if (!result) MessageBox.Show("SORRY BABY !!!");
            }
        }
    }
}