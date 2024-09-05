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
    internal class Payment_Of_hireClass : DB
    {
        internal int id;
        internal int h_id_FK;
        internal int p_m_id_FK;
        internal int basic_charge;
        internal float waiting_charge;
        internal float extra_KM_charge;
        internal float over_night_stay_charge;
        internal string date;

        public Payment_Of_hireClass()
        {
            connectwithdatabase();
        }

        public void transaction()
        {
            string sql = "Insert INTO Payment_of_hire (h_id_FK , p_m_id_FK , h_P_basic_charge , h_p_waiting_charge , h_p_extra_KM_charge , h_p_over_night_stay_charge , h_p_date) Values ('" + this.h_id_FK + "' , '" + this.p_m_id_FK + "' , '" + this.basic_charge + "' , '" + this.waiting_charge + "' , '" + this.extra_KM_charge + "' , '" + this.over_night_stay_charge + "' , GETDATE())";
            executeQuery(sql, FunctionType.transaction);
        }

        public void update()
        {
            string sql = "UPDATE Payment_of_hire SET h_id_FK = '" + this.h_id_FK + "' , p_m_id_FK = '" + this.p_m_id_FK + "' , h_P_basic_charge = '" + this.basic_charge + "' , h_p_waiting_charge = '" + this.waiting_charge + "' , h_p_extra_KM_charge = '" + this.extra_KM_charge + "' , h_p_over_night_stay_charge = '" + this.over_night_stay_charge + "' , h_p_date = GETDATE() Where h_p_id = " + this.id;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM Payment_of_hire Where h_p_id = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyLoadTable)
        {
            string sql = "Select * FROM Payment_of_hire";
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }

        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "select * from Payment_of_hire";
            loadcomboBox(sql, comboBox, "h_p_id", "h_p_id");
        }

        public void search(DataGridView _MyLoadTable, string _id)
        {
            string sql = "Select * FROM Payment_of_hire WHERE h_p_id = " + _id;
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }
    }
}
