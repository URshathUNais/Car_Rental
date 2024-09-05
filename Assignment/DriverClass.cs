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
    internal class DriverClass : DB
    {
        internal int id;
        internal string name;
        internal int mobile;
        internal int licence_number;
        internal string address;
        internal int rate;
        internal int over_night_stay_rate;

        public DriverClass()
        {
            connectwithdatabase();
        }
        public void save()
        {
            string sql = "Insert INTO Driver (d_name , d_mobile , d_licence_number , d_address , d_rate , d_over_night_stay_rate) Values ('" + this.name + "' , '" + this.mobile + "', '"+ this.licence_number +"' , '" + this.address + "', '" + this.rate + "' , '" + this.over_night_stay_rate + "')";
            executeQuery(sql, FunctionType.save);
        }
        public void update()
        {
            string sql = "UPDATE Driver SET d_name = '"+ this.name +"' , d_mobile = '"+ this.mobile + "' , d_licence_number = '" + this.licence_number + "' , d_address = '" + this.address + "' , d_rate = '" + this.rate + "' , d_over_night_stay_rate = '" + this.over_night_stay_rate + "' Where d_id = " + this.id;
            executeQuery(sql, FunctionType.update);
        }
        public void delete()
        {
            string sql = "DELETE FROM Driver Where d_id = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }
        public void view(DataGridView _MyLoadTable)
        {
            string sql = "Select * FROM Driver";
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }

        public void loadlistInComboBox(ComboBox comboBox)
        { 
            string sql = "select * from Driver";
            loadcomboBox(sql, comboBox, "d_id", "d_name");
        }

        public void search(DataGridView _MyLoadTable, string _id)
        {
            string sql = "Select * FROM Driver WHERE d_id = " + _id;
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }
    }
}
