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
    internal class Type_Of_VehicleClass : DB
    {
        internal int id;
        internal string name;

        public Type_Of_VehicleClass()
        {
            connectwithdatabase();
        }

        public void save()
        {
            string sql = "Insert INTO Types_of_vehicle (v_t_name) Values ('" + this.name + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE Types_of_vehicle SET v_t_name = '" + this.name + "' Where v_t_id = " + this.id;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM Types_of_vehicle Where v_t_id = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyLoadTable)
        {
            string sql = "Select * FROM Types_of_vehicle";
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }

        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "select * from Types_of_vehicle";
            loadcomboBox(sql, comboBox, "v_t_id", "v_t_name");
        }

        public void search(DataGridView _MyLoadTable, string _id)
        {
            string sql = "Select * FROM Types_of_vehicle WHERE v_t_id = " + _id;
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }
    }
}
