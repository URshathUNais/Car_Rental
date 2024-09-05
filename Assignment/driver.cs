using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Assignment.come_code;

namespace Assignment
{
    public partial class driver : Form
    {
        DriverClass DriverClassobj = new DriverClass();
        public driver()
        {
            InitializeComponent();
        }

        private void driver_Load(object sender, EventArgs e)
        {
            DriverClassobj.view(load_table);
        }

        private void dri_name_box_TextChanged(object sender, EventArgs e)
        {
            DriverClassobj.name = dri_name_box.Text;
        }

        private void dri_mobile_box_TextChanged(object sender, EventArgs e)
        {
            DriverClassobj.mobile = Convert.ToInt32(dri_mobile_box.Text);
        }

        private void dri_licence_number_box_TextChanged(object sender, EventArgs e)
        {
            DriverClassobj.licence_number = Convert.ToInt32(dri_licence_number_box.Text);
        }

        private void dri_address_box_TextChanged(object sender, EventArgs e)
        {
            DriverClassobj.address = dri_address_box.Text;
        }

        private void dri_rate_box_TextChanged(object sender, EventArgs e)
        {
            DriverClassobj.rate = Convert.ToInt32(dri_rate_box.Text);
        }

        private void dri_over_night_rate_box_TextChanged(object sender, EventArgs e)
        {
            DriverClassobj.over_night_stay_rate = Convert.ToInt32(dri_over_night_rate_box.Text);
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            DriverClassobj.save();
            DriverClassobj.view(load_table);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            DriverClassobj.update();
            DriverClassobj.view(load_table);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DriverClassobj.delete();
            DriverClassobj.view(load_table);
        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DriverClassobj.id = Convert.ToInt32(load_table.Rows[index].Cells[0].Value.ToString());
            DriverClassobj.name = load_table.Rows[index].Cells[1].Value.ToString();
        }

        private void load_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dri_name_box.Text = load_table.CurrentRow.Cells[1].Value.ToString();
            dri_mobile_box.Text = load_table.CurrentRow.Cells[2].Value.ToString();
            dri_licence_number_box.Text = load_table.CurrentRow.Cells[3].Value.ToString();
            dri_address_box.Text = load_table.CurrentRow.Cells[4].Value.ToString();
            dri_rate_box.Text = load_table.CurrentRow.Cells[5].Value.ToString();
            dri_over_night_rate_box.Text = load_table.CurrentRow.Cells[6].Value.ToString();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            DriverClassobj.search(load_table , search_box.Text);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
