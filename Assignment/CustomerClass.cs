using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using Assignment.come_code;

namespace Assignment
{
    internal class CustomerClass : DB
    {
        internal int id;
        internal string name;
        internal int mobile;
        internal string address;
        internal string nic_number;
        internal int licence_number;

        public CustomerClass()
        {
            connectwithdatabase();
        }

        public void save()
        {
            string sql = "Insert INTO Customer (c_name , c_mobile , c_address , c_nic_number , c_licence_number) Values ('" + this.name + "' , '" + this.mobile + "' , '" + this.address + "' , '" + this.nic_number + "' , '" + this.licence_number + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE Customer SET c_name = '" + this.name + "' , c_mobile = '" + this.mobile + "' , c_address = '" + this.address + "' , c_nic_number = '" + this.nic_number + "' , c_licence_number = '" + this.licence_number + "' Where c_id = " + this.id;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM Customer Where c_id = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view (DataGridView _MyLoadTable)
        {
            string sql = "Select * FROM Customer";
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }

        public void loadlistInComboBox (ComboBox comboBox)
        {
            string sql = "select * from Customer";
            loadcomboBox(sql, comboBox, "c_id", "c_name");
        }

        public void search(DataGridView _MyLoadTable, string _id)
        {
            string sql = "Select * FROM Customer WHERE c_id = " + _id;
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }
    }
}
