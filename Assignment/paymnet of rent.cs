using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment
{
    public partial class paymnet_of_rent : Form
    {
        Payment_Of_RentClass Payment_Of_RentClassobj = new Payment_Of_RentClass();
        Method_Of_PaymentClass Method_Of_PaymentClassobj = new Method_Of_PaymentClass();

        public paymnet_of_rent()
        {
            InitializeComponent();
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            string rentID = rent_id_box.Text;
            
            if (rentID == "")
            {
                MessageBox.Show("Please Enter Your Rent ID Before Search");
                clearLabels();
            }

            else
            {
                DataTable dt = Payment_Of_RentClassobj.findBtnClick(rentID);

                if (dt.Rows.Count > 0)
                {
                    //Vehicle Type Information
                    vehicle_type_id.Text = dt.Rows[0]["v_t_id"].ToString();
                    vehicle_type_name.Text = dt.Rows[0]["v_t_name"].ToString();

                    //Vehicle Information
                    vehicle_id.Text = dt.Rows[0]["v_id"].ToString();
                    vehicle_number.Text = dt.Rows[0]["v_no"].ToString();
                    vehicle_brand.Text = dt.Rows[0]["v_brand"].ToString();

                    //Rates Information
                    rates_id.Text = dt.Rows[0]["r_id"].ToString();
                    rates_per_day.Text = dt.Rows[0]["per_day"].ToString();
                    rates_per_week.Text = dt.Rows[0]["per_week"].ToString();
                    rates_per_month.Text = dt.Rows[0]["per_month"].ToString();

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

                    //Rent Information
                    rent_id.Text = dt.Rows[0]["r_id"].ToString();
                    rent_days.Text = dt.Rows[0]["r_days"].ToString();
                    rent_date_time.Text = dt.Rows[0]["date_time"].ToString();
                    rent_start_date.Text = dt.Rows[0]["start_date_time"].ToString();
                    rent_end_date.Text = dt.Rows[0]["end_date_time"].ToString();

                    //Rent Calculation Information
                    double Days = Convert.ToDouble(rent_days.Text);
                    double DayPayment = Convert.ToDouble(rates_per_day.Text);
                    double Weekpayment = Convert.ToDouble(rates_per_week.Text);
                    double MonthPaymet = Convert.ToDouble(rates_per_month.Text);
                    double DriverPerDayCharge = Convert.ToDouble(driver_rate.Text);
                    double DumDays = (Days);

                    int MonthsInDays = 0, WeeksInDays = 0, BalanceDays = 0;
                    //Month Calculate
                    if(Days >= 30)
                    {
                        MonthsInDays = (int)Days / 30;
                        Days -= (MonthsInDays * 30);
                    }
                    //Week Calculate
                    if (Days >= 7)
                    {
                        WeeksInDays = (int)Days / 7;
                        Days -= (WeeksInDays * 7);
                    }
                    //Days Calculate
                    BalanceDays = (int)Days;
                    //Rent Charge
                    rent_base_charge_box.Text = Convert.ToString((MonthsInDays * MonthPaymet) + (WeeksInDays * Weekpayment) + (BalanceDays * DayPayment));
                    //Driver Charge
                    rent_driver_charge_box.Text = Convert.ToString(DriverPerDayCharge * DumDays);

                    double basecharge = Convert.ToDouble(rent_base_charge_box.Text);
                    double drivercharge = Convert.ToDouble(rent_driver_charge_box.Text);
                    //Rent & Driver Charge Total amount
                    rent_total_amount_box.Text = Convert.ToString(basecharge + drivercharge);
                }

                else
                {
                    MessageBox.Show("Invalid Rent ID");
                    clearLabels();
                }
            }
        }

        private void label62_Click(object sender, EventArgs e)
        {

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

            //Rates Information
            rates_id.Text = "............";
            rates_per_day.Text = "............";
            rates_per_week.Text = "............";
            rates_per_month.Text = "............";

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

            //Rent Information
            rent_id.Text = "............";
            rent_days.Text = "............";
            rent_date_time.Text = "............";
            rent_start_date.Text = "............";
            rent_end_date.Text = "............";

            //Payment Of Rent Information
            rent_base_charge_box.Text = "0";
            rent_driver_charge_box.Text = "0";
            payment_method_com_box.Text = "0";
            rent_total_amount_box.Text = "0";
            rent_paid_amount_box.Text = "0";
            rent_balance_amount_box.Text = "0";
        }

        private void rent_paid_amount_box_TextChanged(object sender, EventArgs e)
        {
           double TotalAmount = Convert.ToDouble(rent_total_amount_box.Text);
           double PaidAmount = Convert.ToDouble(rent_paid_amount_box.Text);

            rent_balance_amount_box.Text = Convert.ToString(PaidAmount - TotalAmount);
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            Payment_Of_RentClassobj.r_id_FK = Convert.ToInt32(rent_id.Text);
            Payment_Of_RentClassobj.transaction();
        }

        private void rent_base_charge_box_TextChanged(object sender, EventArgs e)
        {
            Payment_Of_RentClassobj.basic_charge = Convert.ToInt32(rent_base_charge_box.Text);
        }

        private void rent_driver_charge_box_TextChanged(object sender, EventArgs e)
        {
            Payment_Of_RentClassobj.driver_charge = Convert.ToInt32(rent_driver_charge_box.Text);
        }

        private void payment_method_com_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Payment_Of_RentClassobj.p_m_id_FK = Convert.ToInt32(payment_method_com_box.SelectedValue.ToString());
        }

        private void paymnet_of_rent_Load(object sender, EventArgs e)
        {
            Method_Of_PaymentClassobj.loadlistInComboBox(payment_method_com_box);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void vehicle_type_id_Click(object sender, EventArgs e)
        {

        }
    }
}
