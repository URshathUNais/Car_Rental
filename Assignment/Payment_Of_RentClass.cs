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
    internal class Payment_Of_RentClass : DB
    {
        internal int id;
        internal int r_id_FK;
        internal int p_m_id_FK;
        internal float basic_charge;
        internal string date;
        internal float driver_charge;

        public Payment_Of_RentClass()
        {
            connectwithdatabase();
        }

        public void transaction()
        {
            string sql = "Insert INTO Payment_of_rent (r_id_FK , p_m_id_FK , r_p_basic_charge , r_p_date , r_p_driver_charge) Values ('" + this.r_id_FK + "' , '" + this.p_m_id_FK + "' , '" + this.basic_charge + "' , GETDATE() , '" + this.driver_charge + "')";
            executeQuery(sql, FunctionType.transaction);
        }

        public void update()
        {
            string sql = "UPDATE Payment_of_rent SET r_id_FK = '" + this.r_id_FK + "' , p_m_id_FK = '" + this.p_m_id_FK + "' , r_p_basic_charge = '" + this.basic_charge + "' , GETDATE() , r_p_driver_charge = '" + this.driver_charge + "' Where r_p_id = " + this.id;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM Payment_of_rent Where r_p_id = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyLoadTable)
        {
            string sql = "Select * FROM Payment_of_rent";
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }

        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "select * from Payment_of_rent";
            loadcomboBox(sql, comboBox, "r_p_id", "r_p_id");
        }

        public void search(DataGridView _MyLoadTable, string _id)
        {
            string sql = "Select * FROM Payment_of_rent WHERE r_p_id = " + _id;
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }

        public DataTable findBtnClick(string rentID)
        {
            string sql = "select * from Rent join Vehicles on Vehicles.v_id = rent.v_id_FK join Types_of_vehicle on Vehicles.v_t_id_FK = Types_of_vehicle.v_t_id join Rates on Types_of_vehicle.v_t_id = Rates.v_t_id_FK join Driver on Rent.d_id_FK = Driver.d_id join Customer on Rent.c_id_FK = Customer.c_id where Rent.r_id = " + rentID;
            return getDataFromDatabase(sql);
        }
    }
}
