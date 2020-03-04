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
    public partial class Form_sporturi_disponibile : Form
    {
        public Form_sporturi_disponibile()
        {
            InitializeComponent();
        }

        private void Form_sporturi_disponibile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportDataSet.sports' table. You can move, or remove it, as needed.
            this.sportsTableAdapter.Fill(this.sportDataSet.sports);

            this.reportViewer1.RefreshReport();
        }
    }
}
