using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SportAttendanceManagementSystem
{
    public partial class Form_meniu_rapoarte : Form
    {
        public Form_meniu_rapoarte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        /*
         * button1 for an overview of students
         * 
         * -----> View Students
         * 
         *  buttons 2,3,4  for displaying specific reports:
         * 
         * -----> Sporturi disponibile
         * -----> Repartizari sport
         * -----> Stare promovare studenti
         * 
         */
        private void button1_Click_1(object sender, EventArgs e)
        {
            /*Form3 form3 = new Form3();
            form3.ShowDialog();*/
            Form_adaugare_prezenta form_adaugare_prezenta = new Form_adaugare_prezenta();
            form_adaugare_prezenta.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_sporturi_disponibile form_Sporturi_Disponibile = new Form_sporturi_disponibile();
            form_Sporturi_Disponibile.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_repartizari_sport form_Repartizari_Sport = new Form_repartizari_sport();
            form_Repartizari_Sport.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_stare_promovare_studenti form_stare_promovare_studenti = new Form_stare_promovare_studenti();
            form_stare_promovare_studenti.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_student_id form_student_id = new Form_student_id();
            form_student_id.ShowDialog();
        }

        //change buttons color on Mouse hover
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
            button3.BackColor = Color.FromArgb(127, 255, 0);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.RoyalBlue;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(127, 255, 0);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.RoyalBlue;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(127, 255, 0);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.RoyalBlue;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form_adaugare_student form_adaugare_student = new Form_adaugare_student();
            form_adaugare_student.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_grad_alegere_sport form_grad_alegere_sport = new Form_grad_alegere_sport();
            form_grad_alegere_sport.ShowDialog();
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(127, 255, 0);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.RoyalBlue;
        }
    }
}
