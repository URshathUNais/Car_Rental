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
    public partial class rent : Form
    {
        RentClass RentClassobj = new RentClass();
        CustomerClass CustomerClassobj = new CustomerClass();
        VehiclesClass VehicleClassobj = new VehiclesClass();
        DriverClass DriverClassobj = new DriverClass();

        public rent()
        {
            InitializeComponent();
        }

        private void rent_Load(object sender, EventArgs e)
        {
            RentClassobj.view(load_table);
            CustomerClassobj.loadlistInComboBox(customer_id_fk_combox);
            VehicleClassobj.loadlistInComboBox(vehicle_id_fk_combox);
            DriverClassobj.loadlistInComboBox(driver_id_fk_combox);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            RentClassobj.date_time = rent_date.Text + " " + rent_time.Text;
            RentClassobj.start_date_time = rent_start_date.Text + " " + rent_start_time.Text;
            RentClassobj.end_date_time = rent_end_date.Text + " " + rent_end_time.Text;
            RentClassobj.save();
            RentClassobj.view(load_table);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            RentClassobj.date_time = rent_date.Text + " " + rent_time.Text;
            RentClassobj.start_date_time = rent_start_date.Text + " " + rent_start_time.Text;
            RentClassobj.end_date_time = rent_end_date.Text + " " + rent_end_time.Text;
            RentClassobj.update();
            RentClassobj.view(load_table);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            RentClassobj.delete();
            RentClassobj.view(load_table);
        }

        private void customer_id_fk_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RentClassobj.c_id_FK = Convert.ToInt32(customer_id_fk_combox.SelectedValue.ToString());
        }

        private void vehicle_id_fk_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RentClassobj.v_id_FK = Convert.ToInt32(vehicle_id_fk_combox.SelectedValue.ToString());
        }

        private void driver_id_fk_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RentClassobj.d_id_FK = Convert.ToInt32(driver_id_fk_combox.SelectedValue.ToString());
        }

        private void rent_days_box_TextChanged(object sender, EventArgs e)
        {
            RentClassobj.r_days = Convert.ToInt32(rent_days_box.Text);
        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            RentClassobj.id = Convert.ToInt32(load_table.Rows[index].Cells[0].Value.ToString());
            RentClassobj.id = Convert.ToInt32(load_table.Rows[index].Cells[0].Value.ToString());
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            RentClassobj.search(load_table, search_box.Text);
        }

        private void load_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            customer_id_fk_combox.Text = load_table.CurrentRow.Cells[1].Value.ToString();
            vehicle_id_fk_combox.Text = load_table.CurrentRow.Cells[2].Value.ToString();
            driver_id_fk_combox.Text = load_table.CurrentRow.Cells[3].Value.ToString();
            rent_days_box.Text = load_table.CurrentRow.Cells[4].Value.ToString();
            rent_date.Text = load_table.CurrentRow.Cells[5].Value.ToString();
            rent_start_date.Text = load_table.CurrentRow.Cells[6].Value.ToString();
            rent_end_date.Text = load_table.CurrentRow.Cells[7].Value.ToString();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
