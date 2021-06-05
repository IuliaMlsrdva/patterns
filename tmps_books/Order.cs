using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Linq;


namespace tmps_books
{
    public partial class Order : Form
    {
       

        public Order()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       public string TransmitSelectedValue()
        {return book_format.SelectedItem.ToString() + comboBox1.SelectedItem.ToString(); }
        
        //next button
        private void button_next_Click(object sender, EventArgs e)
        {
            //var NewForm4 = new Complete_Order();
           // Complete_Order f2 = new Complete_Order();
           // f2.Show();


            //factory

            switch (book_format.SelectedItem)
            {
                case "Paper book":

                    Developer dev = new PaperDeveloper();
                    Book b = dev.Create(label4, book_format);
                    break;
                case "Audio book":

                    Developer devo = new AudioDeveloper();
                    Book bo = devo.Create(label4, book_format);
                    break;

            }

            
            //bridge 
            switch (comboBox1.SelectedItem)
            {
                case "Physical payment":
                 Payment payment = new OnePayment(new Physical());
                 payment.DoWork(label5, comboBox1);
                    break;
                case "Online payment":

                 Payment paymentt = new OnePayment(new Online());
                 paymentt.DoWork(label5, comboBox1);
                    break;
            }

            //for facade

            CoverType cover = new CoverType();
            Languaged language = new Languaged();

            orderFacade orderFacade = new orderFacade(cover, language);

            Client client = new Client();
            Cover_label.Text = client.Cover_Lang(orderFacade, coverType_txt, language_text);


        }

        //facade
        abstract class Person
        {
           
        }

        class Client : Person
        {
            public string Cover_Lang(orderFacade rew, TextBox cov, TextBox lang)
            {
                string txt;
                txt = rew.Specify(cov, lang);
                return txt;
            }
        }
        class CoverType
        {
            public string SetCover(TextBox f)
            {
                string Text;
                Text = f.Text;
                return Text;
            }
        }
        
        class Languaged
        {
            public string SetLanguage(TextBox f)
            {
                string Text;
                Text = f.Text;
                return Text;
            }
        }

        class orderFacade
        {
            CoverType cover;
            Languaged language;

            public orderFacade(CoverType t, Languaged l)
            {
                this.cover = t;
                this.language = l;
            }
            public string Specify(TextBox coverType_txt, TextBox language_text)
            {
                cover.SetCover(coverType_txt);
                language.SetLanguage(language_text);
                return cover.SetCover(coverType_txt) + "\n\n"+"\n" + language.SetLanguage(language_text);
            }

        }

        private void Order_Load(object sender, EventArgs e)
        {

        }


        //factory (фабричеый)
        abstract class Developer
        {
            public string Name { get; set; }
           
            // фабричный метод

            abstract public Book Create(Label label4, ComboBox book_format);
            
        }
        
        class PaperDeveloper : Developer
        {
           

            public override Book Create(Label label4, ComboBox book_format)
            {
                return new Paperbook( label4,  book_format);
            }
        }
        
        class AudioDeveloper : Developer
        {
           

            public override Book Create(Label label4, ComboBox book_format)
            {

                return new Audiobook( label4,  book_format);
            }
        }

        abstract class Book
        {
            public abstract void Display(Label label4, ComboBox book_format);

        }

        class Paperbook : Book
        {


            public override void Display(Label label4, ComboBox book_format)
            {
                Paperbook paperbook = new Paperbook( label4,  book_format);
               
            }


                public Paperbook(Label label4, ComboBox book_format) 
                {
                    label4.Text = (string)book_format.Items[0];
                   
                } 
           
            
        }
        class Audiobook : Book
        {
            

            public override void Display(Label label4, ComboBox book_format)
            {
                Audiobook audiobook = new Audiobook(label4, book_format);
            }
           public Audiobook(Label label4, ComboBox book_format)
            {
                label4.Text = (string)book_format.Items[1];
                //Console.WriteLine("Деревянный дом построен");
            }
        }






        //bridge
        interface IPurchase
        {
            void Choose(Label label5, ComboBox comboBox1);
        }

        class Physical : IPurchase
        {
            public void Choose(Label label5, ComboBox comboBox1)
            {
                label5.Text = (string)comboBox1.Items[0];
            }
        }

        class Online : IPurchase
        {
            public void Choose(Label label5, ComboBox comboBox1)
            {
                label5.Text = (string)comboBox1.Items[1];
            }
        }

        abstract class Payment
        {

        protected IPurchase purchase;
        public IPurchase Purchase
        {
            set { purchase = value; }
        }
        public Payment(IPurchase p)
        {
            purchase = p;
        }
        public virtual void DoWork(Label label5, ComboBox comboBox1)
        {
            purchase.Choose( label5,  comboBox1);
        }

        }


        class OnePayment : Payment
        {
            public OnePayment (IPurchase p) : base(p)
            {

            }

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            ListOfBooks form1 = new ListOfBooks();
            form1.Show();

        }
    } 

}