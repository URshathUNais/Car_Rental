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
    public partial class type_of_vehicle : Form
    {
        Type_Of_VehicleClass Type_Of_VehicleClassobj = new Type_Of_VehicleClass();
        public type_of_vehicle()
        {
            InitializeComponent();
        }

        private void type_of_vehicle_Load(object sender, EventArgs e)
        {
            Type_Of_VehicleClassobj.view(load_table);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Type_Of_VehicleClassobj.save();
            Type_Of_VehicleClassobj.view(load_table);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Type_Of_VehicleClassobj.update();
            Type_Of_VehicleClassobj.view(load_table);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Type_Of_VehicleClassobj.delete();
            Type_Of_VehicleClassobj.view(load_table);
        }

        private void vehicle_type_name_box_TextChanged(object sender, EventArgs e)
        {
            Type_Of_VehicleClassobj.name = vehicle_type_name_box.Text;
        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            Type_Of_VehicleClassobj.id = Convert.ToInt32(load_table.Rows[index].Cells[0].Value.ToString());
            Type_Of_VehicleClassobj.name = load_table.Rows[index].Cells[1].Value.ToString();
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Type_Of_VehicleClassobj.search(load_table, search_box.Text);
        }

        private void load_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vehicle_type_name_box.Text = load_table.CurrentRow.Cells[1].Value.ToString();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
