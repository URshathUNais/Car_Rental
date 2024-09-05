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
    internal class Method_Of_PaymentClass : DB
    {
        internal int id;
        internal string name;

        public Method_Of_PaymentClass()
        {
            connectwithdatabase();
        }
        public void save()
        {
            string sql = "Insert INTO Method_of_payment (p_m_name) Values ('" + this.name + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE Method_of_payment SET p_m_name = '" + this.name + "' Where p_m_id = " + this.id;
            executeQuery(sql, FunctionType.update);
        }
        public void delete()
        {
            string sql = "DELETE FROM Method_of_payment Where p_m_id = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }
        public void view(DataGridView _MyLoadTable)
        {
            string sql = "Select * from Method_of_payment";
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }
        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "select * from Method_of_payment";
            loadcomboBox(sql, comboBox, "p_m_id", "p_m_name");
        }

        public void search(DataGridView _MyLoadTable, string _id)
        {
            string sql = "Select * FROM Method_of_payment WHERE p_m_id = " + _id;
            DataTable dt = getDataFromDatabase(sql);
            _MyLoadTable.DataSource = dt;
        }
    }
}
