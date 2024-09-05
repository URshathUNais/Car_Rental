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
    public partial class hire : Form
    {
        HireClass HireClassobj = new HireClass();
        Packages_For_HireClass Packages_For_HireClassObj = new Packages_For_HireClass();
        VehiclesClass VehiclesClassobj = new VehiclesClass();
        CustomerClass CustomerClassobj = new CustomerClass();
        DriverClass DriverClassobj = new DriverClass();

        public hire()
        {
            InitializeComponent();
        }

        private void hire_Load(object sender, EventArgs e)
        {
            HireClassobj.view(load_table);
            Packages_For_HireClassObj.loadlistInComboBox(hire_package_id_combox);
            VehiclesClassobj.loadlistInComboBox(vehicle_id_combox);
            CustomerClassobj.loadlistInComboBox(customer_id_combox);
            DriverClassobj.loadlistInComboBox(driver_id_combox);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            HireClassobj.date_time = hire_date.Text +" "+ hire_time.Text;
            HireClassobj.start_date_time = hire_start_date.Text + " " + hire_start_time.Text;
            HireClassobj.end_date_time = hire_end_date.Text + " " + hire_end_time.Text;
            HireClassobj.save();
            HireClassobj.view(load_table);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            HireClassobj.date_time = hire_date.Text + " " + hire_time.Text;
            HireClassobj.start_date_time = hire_start_date.Text + " " + hire_start_time.Text;
            HireClassobj.end_date_time = hire_end_date.Text + " " + hire_end_time.Text;
            HireClassobj.update();
            HireClassobj.view(load_table);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            HireClassobj.delete();
            HireClassobj.view(load_table);
        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            HireClassobj.id = Convert.ToInt32(load_table.Rows[index].Cells[0].Value.ToString());
            HireClassobj.id = Convert.ToInt32(load_table.Rows[index].Cells[1].Value.ToString());
        }

        private void hire_package_id_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HireClassobj.h_p_id_FK = Convert.ToInt32(hire_package_id_combox.SelectedValue.ToString());
        }

        private void vehicle_id_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HireClassobj.v_id_FK = Convert.ToInt32(vehicle_id_combox.SelectedValue.ToString());
        }

        private void customer_id_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HireClassobj.c_id_FK = Convert.ToInt32(customer_id_combox.SelectedValue.ToString());
        }

        private void driver_id_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HireClassobj.d_id_FK = Convert.ToInt32(driver_id_combox.SelectedValue.ToString());
        }

        private void hire_waiting_extra_hour_box_TextChanged(object sender, EventArgs e)
        {
            HireClassobj.waiting_charge_extra_hour = Convert.ToInt32(hire_waiting_extra_hour_box.Text);
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void hire_waiting_charge_fees_box_TextChanged(object sender, EventArgs e)
        {
            HireClassobj.extra_km_fees = Convert.ToInt32(hire_extra_km_fees_box.Text);
        }

        private void hire_end_date_time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            HireClassobj.search(load_table, search_box.Text);
        }

        private void load_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            hire_package_id_combox.Text = load_table.CurrentRow.Cells[1].Value.ToString();
            vehicle_id_combox.Text = load_table.CurrentRow.Cells[2].Value.ToString();
            customer_id_combox.Text = load_table.CurrentRow.Cells[3].Value.ToString();
            driver_id_combox.Text = load_table.CurrentRow.Cells[4].Value.ToString();
            hire_waiting_extra_hour_box.Text = load_table.CurrentRow.Cells[5].Value.ToString();
            hire_start_km_box.Text = load_table.CurrentRow.Cells[6].Value.ToString();
            hire_extra_km_fees_box.Text = load_table.CurrentRow.Cells[7].Value.ToString();
            hire_date.Text = load_table.CurrentRow.Cells[8].Value.ToString();
            hire_start_date.Text = load_table.CurrentRow.Cells[9].Value.ToString();
            hire_end_date.Text = load_table.CurrentRow.Cells[10].Value.ToString();
        }

        private void hire_time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hire_start_time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hire_end_time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hire_start_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hire_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hire_start_km_box_TextChanged(object sender, EventArgs e)
        {
            HireClassobj.start_KM = Convert.ToInt32(hire_start_km_box.Text);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
