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
    public partial class vehicle_emission_test : Form
    {
        Vehicle_Emission_TestClass Vehicle_Emission_TestClassobj = new Vehicle_Emission_TestClass();
        VehiclesClass VehiclesClassobj = new VehiclesClass();

        public vehicle_emission_test()
        {
            InitializeComponent();
        }

        private void vehicle_emission_test_Load(object sender, EventArgs e)
        {
            Vehicle_Emission_TestClassobj.view(load_table);
            VehiclesClassobj.loadlistInComboBox(vehicle_id_fk_combox);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Vehicle_Emission_TestClassobj.t_date_time = test_date.Text + " " + test_time.Text;
            Vehicle_Emission_TestClassobj.expire_date_time = expire_date.Text + " " + expire_time.Text;
            Vehicle_Emission_TestClassobj.save();
            Vehicle_Emission_TestClassobj.view(load_table);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Vehicle_Emission_TestClassobj.t_date_time = test_date.Text + " " + test_time.Text;
            Vehicle_Emission_TestClassobj.expire_date_time = expire_date.Text + " " + expire_time.Text;
            Vehicle_Emission_TestClassobj.update();
            Vehicle_Emission_TestClassobj.view(load_table);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Vehicle_Emission_TestClassobj.delete();
            Vehicle_Emission_TestClassobj.view(load_table);
        }

        private void vehicle_id_fk_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehicle_Emission_TestClassobj.v_id_FK = Convert.ToInt32(vehicle_id_fk_combox.SelectedValue.ToString());
        }

        private void total_amount_box_TextChanged(object sender, EventArgs e)
        {
            Vehicle_Emission_TestClassobj.t_amount = total_amount_box.Text;
        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            Vehicle_Emission_TestClassobj.id = Convert.ToInt32(load_table.Rows[index].Cells[0].Value.ToString());
            Vehicle_Emission_TestClassobj.id = Convert.ToInt32(load_table.Rows[index].Cells[0].Value.ToString());
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void expire_date_picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Vehicle_Emission_TestClassobj.search(load_table, search_box.Text);
        }

        private void load_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vehicle_id_fk_combox.Text = load_table.CurrentRow.Cells[1].Value.ToString();
            test_date.Text = load_table.CurrentRow.Cells[2].Value.ToString();
            expire_date.Text = load_table.CurrentRow.Cells[3].Value.ToString();
            total_amount_box.Text = load_table.CurrentRow.Cells[4].Value.ToString();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
