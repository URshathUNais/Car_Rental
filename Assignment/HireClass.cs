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
    internal class HireClass : DB
    {
        internal int id;
        internal int h_p_id_FK;
        internal int v_id_FK;
        internal int c_id_FK;
        internal int d_id_FK;
        internal int waiting_charge_extra_hour;
        internal int start_KM;
        internal int extra_km_fees;
        internal string date_time;
        internal string start_date_time;
        internal string end_date_time;

        public HireClass()
        {
            connectwithdatabase();
        }
        public void save()
        {
            string sql = "Insert INTO Hire (h_p_id_FK , v_id_FK , c_id_FK , d_id_FK , h_waiting_charge_extra_hour , h_start_KM , h_extra_KM_fees , h_date_time , h_start_date_time , h_end_date_time) Values ('" + this.h_p_id_FK + "' , '" + this.v_id_FK + "', '" + this.c_id_FK + "' , '" + this.d_id_FK + "', '" + this.waiting_charge_extra_hour + "' , '" + this.start_KM + "' , '" + this.extra_km_fees + "' , '" + this.date_time + "' , '" + this.start_date_time + "' , '" + this.end_date_time + "')";
            executeQuery(sql, FunctionType.save);
        }
        public void update()
        {
            string sql = "UPDATE Hire SET h_p_id_FK = '" + this.h_p_id_FK + "' , v_id_FK = '" + this.v_id_FK + "' , c_id_FK = '" + this.c_id_FK + "' , d_id_FK = '" + this.d_id_FK + "' , h_waiting_charge_extra_hour = '" + this.waiting_charge_extra_hour + "' , h_start_KM = '" + this.start_KM + "' , h_extra_KM_fees = '" + this.extra_km_fees + "' , h_date_time = '" + this.date_time + "' , h_start_date_time = '" + this.start_date_time + "' , h_end_date_time = '" + this.end_date_time + "' Where h_id = " + this.id;
            executeQuery(sql, FunctionType.update);
        }
        public void delete()
        {
            string sql = "DELETE FROM Hire Where h_id = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }
        public void view(DataGridView _MyLoadTable)
        {
            string sql = "Select * FROM Hire";
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }
        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "select * from Hire";
            loadcomboBox(sql, comboBox, "h_id", "h_id");
        }

        public void search(DataGridView _MyLoadTable, string _id)
        {
            string sql = "Select * FROM Hire WHERE h_id = " + _id;
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }
    }
}
