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
    internal class ReportClass : DB
    {
        internal string start_rate;
        internal string end_rate;
        public ReportClass()
        {
            connectwithdatabase();
        }


        public void vehicles_expiry_date(DataGridView _MyLoadTable, string id)
        {
            string sql = "select Vehicles.v_id as [Vehicle ID], Types_of_vehicle.v_t_name as [Vehicle Name],Vehicle_emission_test.expire_date_time as [Emission Expire Date Time] from Vehicles join Vehicle_emission_test on Vehicles.v_id = Vehicle_emission_test.v_id_FK join Types_of_vehicle on Types_of_vehicle.v_t_id = Vehicles.v_t_id_FK where v_id = " + id;
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }

        public void driver_rate(DataGridView _MyLoadTable, string id)
        {
            string sql = "select Driver.d_name as [Driver Name],d_rate as [Driver Rate],Packages_for_hire.h_p_name as [Package Name] from Hire join Packages_for_hire on Hire.h_p_id_FK = Packages_for_hire.h_p_id join Driver on Driver.d_id = Hire.d_id_FK where d_rate between '"+ this.start_rate + "' and '"+ this.end_rate +"' and h_id =" + id;
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }

        public void vehicle_for_hire(DataGridView _MyLoadTable, string id)
        {
            string sql = "select Vehicles.v_id as [Vehicle ID], Types_of_vehicle.v_t_name as [Vehicle Name], Packages_for_hire.h_p_name as [Hire Package Name] from Vehicles join Hire on Vehicles.v_id = Hire.v_id_FK join Packages_for_hire on Hire.h_p_id_FK = Packages_for_hire.h_p_id join Types_of_vehicle on Types_of_vehicle.v_t_id = Vehicles.v_t_id_FK where v_id = " + id;
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }

    }
}
