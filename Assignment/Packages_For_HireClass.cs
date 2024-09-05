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
    internal class Packages_For_HireClass : DB
    {
        internal int id;
        internal string name;
        internal float max_hour;
        internal float max_KM;
        internal float rate;


        public Packages_For_HireClass()
        {
            connectwithdatabase();
        }

        public void save()
        {
            string sql = "Insert INTO Packages_for_hire (h_p_name , max_hour , max_KM , rate) Values ('" + this.name + "' , '" + this.max_hour + "' , '" + this.max_KM + "' , '" + this.rate + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE Packages_for_hire SET h_p_name = '" + this.name + "' , max_hour = '" + this.max_hour + "' , max_KM = '" + this.max_KM + "' , rate = '" + this.rate + "' Where h_p_id = " + this.id;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM Packages_for_hire Where h_p_id = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyLoadTable)
        {
            string sql = "Select * FROM Packages_for_hire";
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }

        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "select * from Packages_for_hire";
            loadcomboBox(sql, comboBox, "h_p_id", "h_p_name");
        }

        public void search(DataGridView _MyLoadTable, string _id)
        {
            string sql = "Select * FROM Packages_for_hire WHERE h_p_id = " + _id;
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }
    }
}
