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
    internal class VehiclesClass : DB
    {
        internal int id;
        internal int v_t_id_FK;
        internal string v_no;
        internal string v_brand;

        public VehiclesClass()
        {
            connectwithdatabase();
        }

        public void save()
        {
            string sql = "Insert INTO Vehicles (v_t_id_FK , v_no , v_brand) Values ('" + this.v_t_id_FK + "' , '" + this.v_no + "', '" + this.v_brand + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE Vehicles SET v_t_id_FK = '" + this.v_t_id_FK + "' , v_no = '" + this.v_no + "' , v_brand = '" + this.v_brand + "' Where v_id = " + this.id;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM Vehicles Where v_id = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyLoadTable)
        {
            string sql = "Select * FROM Vehicles";
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }

        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "select * from Vehicles";
            loadcomboBox(sql, comboBox, "v_id", "v_id");
        }

        public void search(DataGridView _MyLoadTable, string _id)
        {
            string sql = "Select * FROM Vehicles WHERE v_id = " + _id;
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }
    }
}
