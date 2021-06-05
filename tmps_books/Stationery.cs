using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tmps_books
{
    public partial class Stationery : Form
    {
        public Stationery()
        {
            InitializeComponent();
        }



        abstract class Mediator
        {
            public abstract void Send(TextBox msg, Label label5, Colleague colleague);
        }
        abstract class Colleague
        {
            protected Mediator mediator;

            public Colleague(Mediator mediator)
            {
                this.mediator = mediator;
            }

            public virtual void Send(TextBox message, Label label5)
            {
                mediator.Send(message, label5, this);
            }
            public abstract void Notify(TextBox message, Label label5);
        }
        // класс КАРТОН
        class Cardboard : Colleague
        {
            public Cardboard(Mediator mediator)
                : base(mediator)
            { }

            public override void Notify(TextBox message, Label label5)
            {
                label5.Text = message.Text;
            }
        }
        // класс ПЛАСТИК
        class Plastic : Colleague
        {
            public Plastic(Mediator mediator)
                : base(mediator)
            { }

            public override void Notify(TextBox message, Label label5)
            {
                label5.Text = message.Text;
                //Console.WriteLine("Сообщение программисту: " + message);
            }
        }
        // класс БУМАЖНЫЙ
        class Paper : Colleague
        {
            public Paper(Mediator mediator)
                : base(mediator)
            { }

            public override void Notify(TextBox message, Label label5)
            {
                label5.Text = message.Text;
            }
        }

        class ManagerMediator : Mediator
        {
            public Colleague Customer { get; set; }
            public Colleague Programmer { get; set; }
            public Colleague Tester { get; set; }
            public override void Send(TextBox msg, Label label5, Colleague colleague)
            {
                // если отправитель - заказчик, значит есть новый заказ
                // отправляем сообщение программисту - выполнить заказ
                if (Customer == colleague)
                    Programmer.Notify(msg,label5);
                // если отправитель - программист, то можно приступать к тестированию
                // отправляем сообщение тестеру
                else if (Programmer == colleague)
                    Tester.Notify(msg, label5);
                // если отправитель - тест, значит продукт готов
                // отправляем сообщение заказчику
                else if (Tester == colleague)
                    Customer.Notify(msg, label5);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            ManagerMediator mediator = new ManagerMediator();
            Colleague customer = new Cardboard(mediator);
            Colleague programmer = new Plastic(mediator);
            Colleague tester = new Paper(mediator);
            mediator.Customer = customer;
            mediator.Programmer = programmer;
            mediator.Tester = tester;
            customer.Send(card, label5);
            programmer.Send(plactic, label6);
            tester.Send(paper, label7);
        }
    }
}
