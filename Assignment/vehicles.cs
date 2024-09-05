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
    public partial class vehicles : Form
    {
        VehiclesClass VehiclesClassobj = new VehiclesClass();
        Type_Of_VehicleClass Type_Of_VehicleClassobj = new Type_Of_VehicleClass();

        public vehicles()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void vehicles_Load(object sender, EventArgs e)
        {
            VehiclesClassobj.view(load_table);
            Type_Of_VehicleClassobj.loadlistInComboBox(vehicle_type_id_fk_box);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            VehiclesClassobj.save();
            VehiclesClassobj.view(load_table);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            VehiclesClassobj.update();
            VehiclesClassobj.view(load_table);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            VehiclesClassobj.delete();
            VehiclesClassobj.view(load_table);
        }

        private void vehicle_type_id_fk_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            VehiclesClassobj.v_t_id_FK = Convert.ToInt32(vehicle_type_id_fk_box.SelectedValue.ToString());
        }

        private void vehicle_number_box_TextChanged(object sender, EventArgs e)
        {
            VehiclesClassobj.v_no = vehicle_number_box.Text;
        }

        private void vehicle_brand_box_TextChanged(object sender, EventArgs e)
        {
            VehiclesClassobj.v_brand = vehicle_brand_box.Text;
        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            VehiclesClassobj.id = Convert.ToInt32(load_table.Rows[index].Cells[0].Value.ToString());
            VehiclesClassobj.id = Convert.ToInt32(load_table.Rows[index].Cells[1].Value.ToString());
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            VehiclesClassobj.search(load_table , search_box.Text);
        }

        private void load_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vehicle_type_id_fk_box.Text = load_table.CurrentRow.Cells[1].Value.ToString();
            vehicle_number_box.Text = load_table.CurrentRow.Cells[2].Value.ToString();
            vehicle_brand_box.Text = load_table.CurrentRow.Cells[3].Value.ToString();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
