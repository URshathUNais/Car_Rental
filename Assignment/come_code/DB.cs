using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Information is transferred from the database to the application.
using System.Data.SqlClient;
//Access the data from SQL to the application
using System.Data;
//Represents a Windows list view control that can be used to display a collection of items.
using System.Windows.Forms;

namespace Assignment.come_code
{
    //used to give a group of numeric integer values constant names.
    public enum FunctionType
    {
        save,
        update,
        delete,
        transaction
    }

    internal class DB
    {   
        //Create a link between the database and the application.
        private string connectionstring = @"Data Source=URshathUNais\SQLEXPRESS;Initial Catalog='Programming Assignment';Integrated Security=True";
        private SqlConnection con = null;

        //The instructions can be used to conduct actions such as select,save,update and delete.
        protected void connectwithdatabase()
        {
            con = new SqlConnection(connectionstring);
        }

        //This function created to execute insert , update, and delete function in one place
        protected void executeQuery ( string sql , FunctionType type )
        {
            string message = ""; 
            int effecetedRowsCount = 0;

            //If an open connection is available, the SQL Connection uses it.
            con.Open();
            
            //The following commands will work if the execute query function type is save.
            if (type == FunctionType.save)
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                effecetedRowsCount = cmd.ExecuteNonQuery();
                message = "Inserted Successfully";
            }

            else if (type == FunctionType.update)
            {
               
                if (MessageBox.Show("Do you want to update ? " , "Update Confirmation Message" , MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand (sql, con);
                    effecetedRowsCount = cmd.ExecuteNonQuery();
                    message = "Update Successfully";
                }
            }
                else if (type == FunctionType.delete)
            {
                if (MessageBox.Show("Do you want to delete ?" , "Delete Confirmation message" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    effecetedRowsCount = cmd.ExecuteNonQuery();
                    message = "Deleted Successfully";
                }
            }
                else if (type == FunctionType.transaction)
            {
                if (MessageBox.Show("Do you want to transaction ?", "transaction Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    effecetedRowsCount = cmd.ExecuteNonQuery();
                    message = "Your Transaction Is Successful";
                }
            }

            con.Close();

            if (effecetedRowsCount > 0)
            {
                MessageBox.Show(message);
            }
        }
        protected DataTable getDataFromDatabase(string sql)
        {
            DataTable myreturn = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql,con);
            da.Fill(myreturn);
            return myreturn;
        }
        protected void loadcomboBox(string sql , ComboBox myFkBox , string idcolumnName , string nameColumnName)
        {
            myFkBox.DisplayMember = nameColumnName;
            myFkBox.ValueMember = idcolumnName;
            DataTable dt = getDataFromDatabase(sql);
            myFkBox.DataSource = dt;
        }
    }
}
