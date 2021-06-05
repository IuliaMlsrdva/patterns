using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tmps_books
{
    public partial class ListOfBooks : Form
    {
        public ListOfBooks()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Size = new System.Drawing.Size(158, 225); //задаем размеры
           // int h = pictureBox1.Size.Height; //получаем текущую высоту
           // int w = pictureBox1.Size.Width;//получаем текущую ширину
            pictureBox1.Image = Properties.Resources.flower;
           

        }

        private void flowers_in_the_Attick_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var NewForm3 = new Flowers_form();
            NewForm3.Show();
            this.Hide();

        }

        private void Hamp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var NewForm3 = new Hamp_Hotelcs();
            NewForm3.Show();
            this.Hide();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
