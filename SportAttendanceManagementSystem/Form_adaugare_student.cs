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
    public partial class Form_adaugare_student : Form
    {
        public Form_adaugare_student()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            //connect to the database
            string connection_string = "server=localhost;user id=root;password=Parolameadesql1234;database=sport";
            MySqlConnection connDatabase = new MySqlConnection(connection_string);

            //create the query
            string query = "INSERT INTO sport.students( name, year, picked_sport, university) VALUES (@nume, " +
                "@an, @sport, @facultate);";
            MySqlCommand cmdDatabase = new MySqlCommand(query, connDatabase);

            cmdDatabase.Parameters.AddWithValue("@nume", name_textBox.Text);
            cmdDatabase.Parameters.AddWithValue("@an", an_textBox.Text);
            cmdDatabase.Parameters.AddWithValue("@sport", sport_textBox2.Text);
            cmdDatabase.Parameters.AddWithValue("@facultate", university_textBox.Text);


            MySqlDataReader myReader;

            try
            {
                connDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                MessageBox.Show("Student adaugat");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //change button color on mouse hover
        private void enterButton_MouseHover(object sender, EventArgs e)
        {
            enterButton.BackColor = Color.FromArgb(127, 255, 0);
        }

        private void enterButton_MouseLeave(object sender, EventArgs e)
        {
            enterButton.BackColor = Color.RoyalBlue;
        }
    }
}
