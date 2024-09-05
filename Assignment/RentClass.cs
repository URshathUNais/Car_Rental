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
    internal class RentClass : DB
    {
        internal int id;
        internal int c_id_FK;
        internal int v_id_FK;
        internal int d_id_FK;
        internal float r_days;
        internal string date_time;
        internal string start_date_time;
        internal string end_date_time;

        public RentClass()
        {
            connectwithdatabase();
        }

        public void save()
        {
            string sql = "Insert INTO Rent (c_id_FK , v_id_FK , d_id_FK , r_days , date_time , start_date_time , end_date_time) Values ('" + this.c_id_FK + "' , '" + this.v_id_FK + "' , '" + this.d_id_FK + "'  , '" + this.r_days + "' , '" + this.date_time + "' , '" + this.start_date_time + "' , '" + this.end_date_time + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE Rent SET c_id_FK = '" + this.c_id_FK + "' , v_id_FK = '" + this.v_id_FK + "' , d_id_FK = '" + this.d_id_FK + "' , r_days = '" + this.r_days + "' , date_time = '" + this.date_time + "' , start_date_time = '" + this.start_date_time + "' , end_date_time = '" + this.end_date_time + "' Where r_id = " + this.id;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM Rent Where r_id = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyLoadTable)
        {
            string sql = "Select * FROM Rent";
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }

        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "select * from Rent";
            loadcomboBox(sql, comboBox, "r_id", "r_id");
        }

        public void search(DataGridView _MyLoadTable, string _id)
        {
            string sql = "Select * FROM Rent WHERE r_id = " + _id;
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }
    }
}
