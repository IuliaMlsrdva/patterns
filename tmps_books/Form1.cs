using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tmps_books
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //link to books
        {
            var NewForm2 = new ListOfBooks();
            NewForm2.Show();
            this.Hide();

        }


        //singleton -не разработана и не продумана :(
        class Book
        {
            private static Book instance;

            public string Books { get; private set; }

            protected Book(string b)
            {
                this.Books = b;
            }
            public static Book getInstance(string b)
            {
                if (instance == null)
                    instance = new Book(b);
                return instance;
            }

        }

        private void School_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var NewForm3 = new Ucebniki();
            NewForm3.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void Conctov_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var NewForm4 = new Stationery();
            NewForm4.Show();
            this.Hide();
        }
    }
}
