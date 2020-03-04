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
    public partial class Form_stare_promovare_studenti : Form
    {
        public Form_stare_promovare_studenti()
        {
            InitializeComponent();
        }

        private void Form_stare_promovare_studenti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportDataSet.presence' table. You can move, or remove it, as needed.
            this.presenceTableAdapter.Fill(this.sportDataSet.presence);

            this.reportViewer1.RefreshReport();
        }

    }
}
