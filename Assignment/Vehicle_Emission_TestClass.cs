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
    internal class Vehicle_Emission_TestClass : DB
    {
        internal int id;
        internal int v_id_FK;
        internal string t_date_time;
        internal string expire_date_time;
        internal string t_amount;

        public Vehicle_Emission_TestClass()
        {
            connectwithdatabase();
        }

        public void save()
        {
            string sql = "Insert INTO Vehicle_emission_test (v_id_FK , t_date_time , expire_date_time , t_amount) Values ('" + this.v_id_FK + "' , '" + this.t_date_time + "' , '" + this.expire_date_time + "'  , '" + this.t_amount + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE Vehicle_emission_test SET v_id_FK = '" + this.v_id_FK + "' , t_date_time = '" + this.t_date_time + "' , expire_date_time = '" + this.expire_date_time + "' , t_amount = '" + this.t_amount + "' Where t_id = " + this.id;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM Vehicle_emission_test Where t_id = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyLoadTable)
        {
            string sql = "Select * FROM Vehicle_emission_test";
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }

        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "select * from Vehicle_emission_test";
            loadcomboBox(sql, comboBox, "t_id", "t_id");
        }

        public void search(DataGridView _MyLoadTable, string _id)
        {
            string sql = "Select * FROM Vehicle_emission_test WHERE t_id = " + _id;
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }
    }
}
