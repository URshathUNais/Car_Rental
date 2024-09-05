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
    public partial class vehicles_test_expiry_date : Form
    {
        ReportClass ReportClassobj = new ReportClass();
        public vehicles_test_expiry_date()
        {
            InitializeComponent();
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            ReportClassobj.vehicles_expiry_date(load_table,vehicle_id_box.Text);
        }

        private void vehicles_test_expiry_date_Load(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
