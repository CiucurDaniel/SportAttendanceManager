using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SportAttendanceManagementSystem
{
    public partial class Form_adaugare_prezenta : Form
    {
        public Form_adaugare_prezenta()
        {
            InitializeComponent();
        }

        private void Form_adaugare_prezenta_Load(object sender, EventArgs e)
        {
            label_informativ.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection_string = "server=localhost;user id=root;password=Parolameadesql1234;database=sport";
            string query = "INSERT INTO sport.presence(id, date) VALUES ("+ id_textBox.Text + ", DATE '" + date_textBox.Text + "')";
            MySqlConnection connDatabase = new MySqlConnection(connection_string);
            MySqlCommand cmdDatabase = new MySqlCommand(query, connDatabase);
            MySqlDataReader myReader;

            try
            {
                connDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Prezenta adaugata");
                while(myReader.Read())
                {

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void date_textBox_MouseHover(object sender, EventArgs e)
        {
            //If the user hovers the mouse on the date field inform him about date format
            label_informativ.Show();
        }


        //change button color on hover
        private void date_textBox_MouseLeave(object sender, EventArgs e)
        {
            label_informativ.Hide();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(127, 255, 0);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.RoyalBlue;
        }
    }
}
