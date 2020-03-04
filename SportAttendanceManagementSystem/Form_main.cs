using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportAttendanceManagementSystem
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        //close the app with "exit" button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //open the query menu
        private void button1_Click(object sender, EventArgs e)
        {
            Form_meniu_rapoarte form2 = new Form_meniu_rapoarte();
            form2.ShowDialog();
        }

        //change button color on hover
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(127, 255, 0);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.RoyalBlue;
        }


        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(127, 255, 0);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.RoyalBlue;
        }


        private void button3_MouseHover(object sender, EventArgs e)
        {
            //use red color here
            button3.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.RoyalBlue;
        }
        //how to use button click
        private void button2_Click(object sender, EventArgs e)
        {
            Form_how_to_use form_how_to_use = new Form_how_to_use();
            form_how_to_use.ShowDialog();
        }
    }
}
