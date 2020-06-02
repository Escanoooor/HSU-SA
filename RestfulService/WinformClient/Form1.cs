using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using WinformClient.DTO;
using Newtonsoft.Json;

namespace WinformClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            String response = client.DownloadString("http://sonkkk.gear.host/api/books/"); // HttpGet
            //MessageBox.Show(response);
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(response);
            dataGridView1.DataSource = books;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String keyword = textBox1.Text.Trim();
            String response = "";
            WebClient client = new WebClient();
            if (keyword.Length > 0)
            {
                response = client.DownloadString("http://sonkkk.gear.host/api/books/search/" + keyword); // HttpGet
            } else
            {
                response = client.DownloadString("http://sonkkk.gear.host/api/books/"); // HttpGet
            }            
            List<Book> books = JsonConvert.DeserializeObject<List<Book>>(response);
            dataGridView1.DataSource = books;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book newBook = new Book() {
                Code = 0,
                Name = textBox3.Text.Trim(),
                Author =textBox4.Text.Trim(),
                Price = int.Parse(textBox5.Text.Trim())
            };
            String data = JsonConvert.SerializeObject(newBook);
            WebClient client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString("http://sonkkk.gear.host/api/books/", "POST", data); // HttpPost
            if (response != null)
            {
                String response2 = client.DownloadString("http://sonkkk.gear.host/api/books/"); // HttpGet
                List<Book> books = JsonConvert.DeserializeObject<List<Book>>(response2);
                dataGridView1.DataSource = books;
            }
        }
    }
}