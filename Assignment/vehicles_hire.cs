using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class vehicles_hire : Form
    {
        ReportClass ReportClassobj = new ReportClass();
        public vehicles_hire()
        {
            InitializeComponent();
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            ReportClassobj.vehicle_for_hire(load_table,vehicle_id_box.Text);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
