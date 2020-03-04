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
    public partial class Form_repartizari_sport : Form
    {
        public Form_repartizari_sport()
        {
            InitializeComponent();
        }

        private void Form_repartizari_sport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.sportDataSet.students);

            this.reportViewer1.RefreshReport();
        }
    }
}
