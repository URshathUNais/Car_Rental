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
    internal class RatesClass : DB
    {
        internal int id;
        internal int v_t_id_FK;
        internal float per_day;
        internal float per_week;
        internal float per_month;

        public RatesClass()
        {
            connectwithdatabase();
        }

        public void save()
        {
            string sql = "Insert INTO Rates (v_t_id_FK , per_day , per_week , per_month) Values ('" + this.v_t_id_FK + "' , '" + this.per_day + "' , '" + this.per_week + "'  , '" + this.per_month + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE Rates SET v_t_id_FK = '" + this.v_t_id_FK + "' , per_day = '" + this.per_day + "' , per_week = '" + this.per_week + "' , per_month = '" + this.per_month + "' Where r_id = " + this.id;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM Rates Where r_id = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyLoadTable)
        {
            string sql = "Select * FROM Rates";
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }

        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "select * from Rates";
            loadcomboBox(sql, comboBox, "r_id", "r_id");
        }

        public void search(DataGridView _MyLoadTable, string _id)
        {
            string sql = "Select * FROM Rates WHERE r_id = " + _id;
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }


    }
}
