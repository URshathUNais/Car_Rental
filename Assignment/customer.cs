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
    public partial class customer : Form
    {
        CustomerClass CustomerClassobj = new CustomerClass();
        public customer()
        {
            InitializeComponent();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            
            CustomerClassobj.view(load_table);
        }

        private void cus_name_box_TextChanged(object sender, EventArgs e)
        {
            CustomerClassobj.name = cus_name_box.Text;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            CustomerClassobj.save();
            CustomerClassobj.view(load_table);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            CustomerClassobj.update();
            CustomerClassobj.view(load_table);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            CustomerClassobj.delete();
            CustomerClassobj.view(load_table);
        }

        private void cus_mobile_box_TextChanged(object sender, EventArgs e)
        {
            CustomerClassobj.mobile = Convert.ToInt32(cus_mobile_box.Text);
        }

        private void cus_address_box_TextChanged(object sender, EventArgs e)
        {
            CustomerClassobj.address = cus_address_box.Text;
        }

        private void cus_nic_number_box_TextChanged(object sender, EventArgs e)
        {
            CustomerClassobj.nic_number = cus_nic_number_box.Text;
        }

        private void cus_licence_number_box_TextChanged(object sender, EventArgs e)
        {
            CustomerClassobj.licence_number = Convert.ToInt32(cus_licence_number_box.Text);
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            CustomerClassobj.id = Convert.ToInt32(load_table.Rows[index].Cells[0].Value.ToString());
            CustomerClassobj.name = load_table.Rows[index].Cells[1].Value.ToString();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            CustomerClassobj.search(load_table, search_box.Text);
        }

        private void load_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cus_name_box.Text = load_table.CurrentRow.Cells[1].Value.ToString();
            cus_mobile_box.Text = load_table.CurrentRow.Cells[2].Value.ToString();
            cus_address_box.Text = load_table.CurrentRow.Cells[3].Value.ToString();
            cus_nic_number_box.Text = load_table.CurrentRow.Cells[4].Value.ToString();
            cus_licence_number_box.Text = load_table.CurrentRow.Cells[5].Value.ToString();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
