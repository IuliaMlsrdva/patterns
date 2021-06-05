using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tmps_books
{
    public partial class Hamp_Hotelcs : Form
    {
        public Hamp_Hotelcs()
        {
            InitializeComponent();
            label2.Text = "“The first of my father’s illusions was that bears could survive the life lived by human beings,\n" +
                " and the second was that human beings could survive a life led in hotels.” \n " +
                "So says John Berry, son of a hapless dreamer, brother to a cadre of eccentric siblings, \n" +
                " and chronicler of the lives lived, the loves experienced, the deaths met,\n" +
                " and the myriad strange and wonderful times encountered by the family Berry. ";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var NewForm4 = new Order();
            NewForm4.Show();
            this.Hide();
        }

        
    }
}
