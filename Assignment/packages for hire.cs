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
    public partial class packages_for_hire : Form
    {
        Packages_For_HireClass Packages_For_HireClassobj = new Packages_For_HireClass();
        public packages_for_hire()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Packages_For_HireClassobj.save();
            Packages_For_HireClassobj.view(load_table);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Packages_For_HireClassobj.update();
            Packages_For_HireClassobj.view(load_table);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Packages_For_HireClassobj.delete();
            Packages_For_HireClassobj.view(load_table);
        }

        private void packages_for_hire_Load(object sender, EventArgs e)
        {
            Packages_For_HireClassobj.view(load_table);
        }

        private void hire_package_name_box_TextChanged(object sender, EventArgs e)
        {
            Packages_For_HireClassobj.name = hire_package_name_box.Text;
        }

        private void maximum_km_box_TextChanged(object sender, EventArgs e)
        {
            Packages_For_HireClassobj.max_KM = Convert.ToInt32(maximum_km_box.Text);
        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            Packages_For_HireClassobj.id = Convert.ToInt32(load_table.Rows[index].Cells[0].Value.ToString());
            Packages_For_HireClassobj.name = load_table.Rows[index].Cells[1].Value.ToString();
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Packages_For_HireClassobj.search(load_table , search_box.Text);
        }

        private void load_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            hire_package_name_box.Text = load_table.CurrentRow.Cells[1].Value.ToString();
            maximum_hour_box.Text = load_table.CurrentRow.Cells[2].Value.ToString();
            maximum_km_box.Text = load_table.CurrentRow.Cells[3].Value.ToString();
            rate_box.Text = load_table.CurrentRow.Cells[4].Value.ToString();
        }

        private void maximum_hour_box_TextChanged(object sender, EventArgs e)
        {
            Packages_For_HireClassobj.max_hour = Convert.ToInt32(maximum_hour_box.Text);
        }

        private void rate_box_TextChanged(object sender, EventArgs e)
        {
            Packages_For_HireClassobj.rate = Convert.ToInt32(rate_box.Text);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
