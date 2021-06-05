using DocumentFormat.OpenXml.Wordprocessing;
using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tmps_books
{
    public partial class Flowers_form : Form
    {
        //private TextBox dpp;

        public Flowers_form()
        {
            InitializeComponent();
            label3.AutoSize = true;
            label3.Text = "It wasn't that she didn't love her children. She did. But there was a fortune at stake—a \n" +
                "fortune that would assure their later happiness if she could keep the children \n" +
                "a secret from her dying father. \n\nSo she and her mother hid her darlings away in an unused attic.";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = Properties.Resources.flower;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var NewForm4 = new Order();
            NewForm4.Show();
            this.Hide();


            // NameLab.Text = OrderBuilder(TextBox dp);
        }

      
        public void OrderBuilder(TextBox dpp, TextBox endp)
        {
            
            Client client = new Client();
            orderBuilder builder = new BuiledrUser();
            Info info = client.Create(builder, dpp, endp);
            NameLab.Text += NameLab.ToString();
            
        }
     

        private void Show_res_Click(object sender, EventArgs e)
        {
            
            Client client = new Client();
            orderBuilder builder = new BuiledrUser();
            //Info info = client.Create(builder, dpp, endp); //работает, только если поменять dpp на  Name_text и endp на Last_text
           //также скорее всего вина того, что выдает не значение, а название ячейки не в этой строчке
            NameLab.Text += NameLab.ToString();
            
        }



        ///билдер
        abstract class Person
        {
            // public string Name { get; set; }

            /* public Person(string name)
             {
                 Name = name;
             }
            */
            // public abstract void Display(Text text);

        }

        //типо пекарь???
        class Client : Person
        {
            public Info Create(orderBuilder orderBuilder, TextBox dpp, TextBox endp)
            {
                orderBuilder.CreateInfo();
                orderBuilder.SetName(dpp);
                orderBuilder.SetLast(endp);
                return orderBuilder.Info;
            }
        }

        //билдер
        class N
        {
            public string Name { get; set; }
        }
        class L
        {
            public string Lastname { get; set; }
        }

        class Info
        {
            public N N { get; set; }
            public L L { get; set; }


            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                if (N != null)
                    sb.Append("Имя:" + N.Name + "\n");
                if (L != null)
                    sb.Append("Фамилия:" + L.Lastname + "\n");

                return sb.ToString();
            }

        }
        //абстрактный класс строителя
        abstract class orderBuilder
        {
            public Info Info { get; private set; }
            public void CreateInfo()
            {
                Info = new Info();
            }
            public abstract void SetName(TextBox depp);
            public abstract void SetLast(TextBox endp);
        }

        class BuiledrUser : orderBuilder
        {
            public override void SetName(TextBox deppoint)
            {
                this.Info.N = new N { Name = deppoint.Text };
            }

            public override void SetLast(TextBox endpoint)
            {
                this.Info.L = new L { Lastname = endpoint.Text };
            }


        }




    }
   
}
