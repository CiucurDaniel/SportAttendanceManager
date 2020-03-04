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
    public partial class Form_how_to_use : Form
    {
        public Form_how_to_use()
        {
            InitializeComponent();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Show();
            button2.BackColor = Color.FromArgb(127, 255, 0);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            button2.BackColor = Color.RoyalBlue;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Show();
            button1.BackColor = Color.FromArgb(127, 255, 0);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            button1.BackColor = Color.RoyalBlue;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Show();
            button3.BackColor = Color.FromArgb(127, 255, 0);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Hide();
            button3.BackColor = Color.RoyalBlue;
        }
    }
}
