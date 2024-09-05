using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Assignment
{
    public partial class payment_of_hire : Form
    {
        Payment_Of_hireClass payment_Of_HireClassobj = new Payment_Of_hireClass();
        Method_Of_PaymentClass Method_Of_PaymentClassobj = new Method_Of_PaymentClass();

        SqlConnection con = new SqlConnection(@"Data Source=URshathUNais\SQLEXPRESS;Initial Catalog=Programming Assignment;Integrated Security=True");

        public payment_of_hire()
        {
            InitializeComponent();
        }

        private void payment_of_hire_Load(object sender, EventArgs e)
        {
            Method_Of_PaymentClassobj.loadlistInComboBox(payment_method_com_box);
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            string hireID = hire_id_box.Text;

            if (hireID == "")
            {
                MessageBox.Show("Please Enter Your Hire ID Before Search");
                clearLabels();
            }

            else
            {
                string sql = "select * From Hire join Packages_for_hire on Hire.h_p_id_FK = Packages_for_hire.h_p_id join Customer on Customer.c_id = Hire.c_id_FK join Vehicles on Vehicles.v_id = Hire.v_id_FK join Types_of_vehicle on Vehicles.v_t_id_FK = Types_of_vehicle.v_t_id join Driver on Driver.d_id = Hire.d_id_FK where Hire.h_id = " + hireID;
                SqlDataAdapter da = new SqlDataAdapter(sql , con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //Vehicle Type Information
                    vehicle_type_id.Text = dt.Rows[0]["v_t_id"].ToString();
                    vehicle_type_name.Text = dt.Rows[0]["v_t_name"].ToString();

                    //Vehicle Information
                    vehicle_id.Text = dt.Rows[0]["v_id"].ToString();
                    vehicle_number.Text = dt.Rows[0]["v_no"].ToString();
                    vehicle_brand.Text = dt.Rows[0]["v_brand"].ToString();

                    //Driver Information
                    driver_id.Text = dt.Rows[0]["d_id"].ToString();
                    driver_name.Text = dt.Rows[0]["d_name"].ToString();
                    driver_mobile.Text = dt.Rows[0]["d_mobile"].ToString();
                    driver_licence_number.Text = dt.Rows[0]["d_licence_number"].ToString();
                    driver_address.Text = dt.Rows[0]["d_address"].ToString();
                    driver_rate.Text = dt.Rows[0]["d_rate"].ToString();
                    driver_over_night_stay_rate.Text = dt.Rows[0]["d_over_night_stay_rate"].ToString();

                    //Customer Information
                    customer_id.Text = dt.Rows[0]["c_id"].ToString();
                    customer_name.Text = dt.Rows[0]["c_name"].ToString();
                    customer_mobile.Text = dt.Rows[0]["c_mobile"].ToString();
                    customer_address.Text = dt.Rows[0]["c_address"].ToString();
                    customer_NIC_number.Text = dt.Rows[0]["c_nic_number"].ToString();
                    customer_licence_number.Text = dt.Rows[0]["c_licence_number"].ToString();

                    //Hire Information
                    hire_id.Text = dt.Rows[0]["h_id"].ToString();
                    hire_waiting_charge_extra_hour.Text = dt.Rows[0]["h_waiting_charge_extra_hour"].ToString();
                    hire_start_KM.Text = dt.Rows[0]["h_start_KM"].ToString();
                    hire_extra_km_fees.Text = dt.Rows[0]["h_extra_KM_fees"].ToString();
                    hire_date.Text = dt.Rows[0]["h_date_time"].ToString();
                    hire_start_time.Text = dt.Rows[0]["h_start_date_time"].ToString();
                    hire_end_time.Text = dt.Rows[0]["h_end_date_time"].ToString();

                    //Packages For Hire Information
                    hire_package_id.Text = dt.Rows[0]["h_p_id"].ToString();
                    h_package_name.Text = dt.Rows[0]["h_p_name"].ToString();
                    maximum_hour.Text = dt.Rows[0]["max_hour"].ToString();
                    maximum_km.Text = dt.Rows[0]["max_KM"].ToString();
                    hire_package_rate.Text = dt.Rows[0]["rate"].ToString();

                    //Hire Calculation Information
                    //Base Charge Calculation
                    base_charge_box.Text = Convert.ToString(hire_package_rate.Text);
                    //Waiting Charge Calculation
                    DateTime start_time = Convert.ToDateTime(hire_start_time.Text);
                    DateTime end_time = Convert.ToDateTime(hire_end_time.Text);
                    double total_time = (end_time - start_time).TotalHours;
                    double max_time = Convert.ToDouble(maximum_hour.Text);
                    double waiting_fees = Convert.ToDouble(hire_waiting_charge_extra_hour.Text);

                    if (total_time > max_time)
                    {
                        if (total_time <= 24)
                        {
                            waiting_charge_box.Text = Convert.ToString(Convert.ToDouble(total_time - max_time) * waiting_fees);
                        }
                        else
                        {
                            waiting_charge_box.Text = "0";
                        }
                    }
                    //Over Night Stay Rate charge Calculation
                    DateTime start_date = Convert.ToDateTime(hire_start_time.Text);
                    DateTime end_date = Convert.ToDateTime(hire_end_time.Text);
                    double hire_days = (end_date - start_date).TotalDays;
                    double stay_charge_perday = Convert.ToDouble(driver_over_night_stay_rate.Text);

                    if (hire_days >= 2)
                    {
                        over_night_stay_charge_box.Text = Convert.ToString(hire_days * stay_charge_perday);
                    }

                    double extrakmcharge = 0;
                    if (extra_km_charge_box.Text != "")
                    {
                        extrakmcharge = Convert.ToDouble(extra_km_charge_box.Text);
                    }
                    

                    double basecharge = Convert.ToDouble(base_charge_box.Text);
                    double waitingcharge = Convert.ToDouble(waiting_charge_box.Text); 
                    double nightstaycharge = Convert.ToDouble(over_night_stay_charge_box.Text);
                    hire_total_amount_box.Text = Convert.ToString(basecharge + waitingcharge + nightstaycharge);
                     
                }

                else
                {
                    MessageBox.Show("Invalid Hire ID");
                    clearLabels();
                }
            }
        }

        private void clearLabels()
        {
            //Vehicle Type Information
            vehicle_type_id.Text = "............";
            vehicle_type_name.Text = "............";

            //Vehicle Information
            vehicle_id.Text = "............";
            vehicle_number.Text = "............";
            vehicle_brand.Text = "............";

            //Driver Information
            driver_id.Text = "............";
            driver_name.Text = "............";
            driver_mobile.Text = "............";
            driver_licence_number.Text = "............";
            driver_address.Text = "............";
            driver_rate.Text = "............";
            driver_over_night_stay_rate.Text = "............";

            //Customer Information
            customer_id.Text = "............";
            customer_name.Text = "............";
            customer_mobile.Text = "............";
            customer_address.Text = "............";
            customer_NIC_number.Text = "............";
            customer_licence_number.Text = "............";

            //Hire Information
            hire_id.Text = "............";
            hire_waiting_charge_extra_hour.Text = "............";
            hire_start_KM.Text = "............";
            hire_extra_km_fees.Text = "............";
            hire_date.Text = "............";
            hire_start_time.Text = "............";
            hire_end_time.Text = "............";

            //Packages For Hire Information
            hire_package_id.Text = "............";
            h_package_name.Text = "............";
            maximum_hour.Text = "............";
            maximum_km.Text = "............";
            hire_package_rate.Text = "............";

            //Hire Payment Information
            base_charge_box.Text = "0";
            waiting_charge_box.Text = "0";
            hire_end_KM.Text = "0";
            extra_km_charge_box.Text= "0";
            over_night_stay_charge_box.Text = "0";
            hire_total_amount_box.Text = "0";
            hire_paid_amount_box.Text = "0";
            hire_balance_amount_box.Text = "0";

        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            payment_Of_HireClassobj.h_id_FK = Convert.ToInt32(hire_id.Text);
            payment_Of_HireClassobj.transaction();
        }

        private void hire_paid_amount_box_TextChanged(object sender, EventArgs e)
        {
            double Totalamount = Convert.ToDouble(hire_total_amount_box.Text);
            double Paidamount = Convert.ToDouble(hire_paid_amount_box.Text);

            hire_balance_amount_box.Text = Convert.ToString(Paidamount - Totalamount);
        }

        private void hire_package_rate_Click(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void base_charge_box_TextChanged(object sender, EventArgs e)
        {
            payment_Of_HireClassobj.basic_charge = Convert.ToInt32(base_charge_box.Text);
        }

        private void hire_end_KM_TextChanged(object sender, EventArgs e)
        {
            double start_KM = Convert.ToDouble(hire_start_KM.Text);
            double end_KM = Convert.ToDouble(hire_end_KM.Text);
            double hire_total_KM = Convert.ToDouble(end_KM - start_KM);
            double max_KM = Convert.ToDouble(maximum_km.Text);
            double extra_KM_fees = Convert.ToDouble(hire_extra_km_fees.Text);


            if (hire_total_KM > max_KM)
            {
                extra_km_charge_box.Text = Convert.ToString((hire_total_KM - max_KM) * extra_KM_fees);
            }
            else
            {
                extra_km_charge_box.Text = "0";
            }

        }

        private void extra_km_charge_box_TextChanged(object sender, EventArgs e)
        {
            payment_Of_HireClassobj.extra_KM_charge = Convert.ToInt32(extra_km_charge_box.Text);
            double totalAmount = Convert.ToDouble(hire_total_amount_box.Text);
            totalAmount += Convert.ToDouble(extra_km_charge_box.Text);
            hire_total_amount_box.Text = totalAmount.ToString();
        }

        private void payment_method_com_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            payment_Of_HireClassobj.p_m_id_FK = Convert.ToInt32(payment_method_com_box.SelectedValue.ToString());
        }

        private void waiting_charge_box_TextChanged(object sender, EventArgs e)
        {
            payment_Of_HireClassobj.waiting_charge = Convert.ToInt32(waiting_charge_box.Text);
        }

        private void over_night_stay_charge_box_TextChanged(object sender, EventArgs e)
        {
            payment_Of_HireClassobj.over_night_stay_charge = Convert.ToInt32(over_night_stay_charge_box.Text);
        }
    }
}
