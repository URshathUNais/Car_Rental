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
    public partial class rates : Form
    {
        RatesClass RatesClassobj = new RatesClass();
        Type_Of_VehicleClass Type_Of_VehicleClassobj = new Type_Of_VehicleClass();

        public rates()
        {
            InitializeComponent();
        }

        private void rates_Load(object sender, EventArgs e)
        {
            RatesClassobj.view(load_table);
            Type_Of_VehicleClassobj.loadlistInComboBox(vehicle_type_id_fk_combox);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            RatesClassobj.save();
            RatesClassobj.view(load_table);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            RatesClassobj.update();
            RatesClassobj.view(load_table);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            RatesClassobj.delete();
            RatesClassobj.view(load_table);
        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            RatesClassobj.id = Convert.ToInt32(load_table.Rows[index].Cells[0].Value.ToString());
            RatesClassobj.id= Convert.ToInt32(load_table.Rows[index].Cells[0].Value.ToString());
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void per_day_box_TextChanged_2(object sender, EventArgs e)
        {
            RatesClassobj.per_day = Convert.ToInt32(per_day_box.Text);
        }

        private void vehicle_type_id_fk_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RatesClassobj.v_t_id_FK = Convert.ToInt32(vehicle_type_id_fk_combox.SelectedValue.ToString());
        }

        private void per_week_box_TextChanged(object sender, EventArgs e)
        {
            RatesClassobj.per_week = Convert.ToInt32(per_week_box.Text);
        }

        private void per_month_box_TextChanged(object sender, EventArgs e)
        {
            RatesClassobj.per_month = Convert.ToInt32(per_month_box.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            RatesClassobj.search(load_table, search_box.Text);
        }

        private void load_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vehicle_type_id_fk_combox.Text = load_table.CurrentRow.Cells[1].Value.ToString();
            per_day_box.Text = load_table.CurrentRow.Cells[2].Value.ToString();
            per_week_box.Text = load_table.CurrentRow.Cells[3].Value.ToString();
            per_month_box.Text = load_table.CurrentRow.Cells[4].Value.ToString();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
