using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tmps_books
{
    public partial class Ucebniki : Form
    {
        public Ucebniki()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
           
            



            switch (comboBox1.SelectedItem)
            {
                case "Math":
                    Math math = new Math();
                    math.BooksInfo(label1, label5, label6, textBox1, textBox2,  textBox3);
                    break;
                case "Literature":
                    Literature literature = new Literature();
                    literature.BooksInfo(label1,  label5, label6, textBox1, textBox2, textBox3);
                    break;
            }

        }
//шаблонный

        abstract class School
        {

            public void BooksInfo(Label label1, Label label5, Label label6, TextBox textBox1, TextBox textBox2, TextBox textBox3)
            {
                BookName( label1,  textBox1);
                Author(label5,  textBox2);
                PublicHouse( label6,  textBox3);
            }
            public abstract void BookName(Label label1, TextBox textBox1);
            public abstract void Author(Label label5, TextBox textBox2);
            public abstract void PublicHouse(Label label6, TextBox textBox3);

        }
     

        class Math : School
        {
            public override void BookName(Label label1, TextBox textBox1)
            {
                label1.Text = textBox1.Text;
            }
            public override void Author(Label label5, TextBox textBox2)
            {
                label5.Text = textBox2.Text;
            }
            public override void PublicHouse(Label label6, TextBox textBox3)
            {
                label6.Text = textBox3.Text;
            }
        }
    
        class Literature : School
        {
            public override void BookName(Label label1,TextBox textBox1)
            {
                label1.Text = textBox1.Text;
            }
            public override void Author(Label label5, TextBox textBox2)
            {
                label5.Text = textBox2.Text;
            }
            public override void PublicHouse(Label label6, TextBox textBox3)
            {
                label6.Text = textBox3.Text;
            }
        }
        public string TransmitSelectedValue()
        {
            return comboBox1.SelectedItem.ToString();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}




