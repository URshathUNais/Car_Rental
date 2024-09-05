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
    public partial class method_of_payment : Form
    {
        Method_Of_PaymentClass Method_Of_PaymentClassobj = new Method_Of_PaymentClass();
        public method_of_payment()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Method_Of_PaymentClassobj.save();
            Method_Of_PaymentClassobj.view(load_table);
        }

        private void method_of_payment_Load(object sender, EventArgs e)
        {
            Method_Of_PaymentClassobj.view(load_table);
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            Method_Of_PaymentClassobj.update();
            Method_Of_PaymentClassobj.view(load_table);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            Method_Of_PaymentClassobj.delete();
            Method_Of_PaymentClassobj.view(load_table);
        }

        private void payment_method_name_box_TextChanged(object sender, EventArgs e)
        {
            Method_Of_PaymentClassobj.name = payment_method_name_box.Text;
        }

        private void load_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            Method_Of_PaymentClassobj.id = Convert.ToInt32(load_table.Rows[index].Cells[0].Value.ToString());
            Method_Of_PaymentClassobj.name = load_table.Rows[index].Cells[1].Value.ToString();
        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Method_Of_PaymentClassobj.search(load_table, search_box.Text);
        }

        private void load_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            payment_method_name_box.Text = load_table.CurrentRow.Cells[1].Value.ToString();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
