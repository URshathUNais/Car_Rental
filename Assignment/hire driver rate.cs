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
    public partial class customer_rent_charge : Form
    {
        ReportClass ReportClassobj = new ReportClass();
        public customer_rent_charge()
        {
            InitializeComponent();
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            ReportClassobj.driver_rate(load_table, customer_id_box.Text);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void start_rate_box_TextChanged(object sender, EventArgs e)
        {
            ReportClassobj.start_rate = start_rate_box.Text;
        }

        private void end_rate_box_TextChanged(object sender, EventArgs e)
        {
            ReportClassobj.end_rate = end_rate_box.Text;
        }
    }
}
