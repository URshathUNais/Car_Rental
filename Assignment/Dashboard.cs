using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Assignment.come_code;

namespace Assignment
{
    public partial class Dashboard : Form
    {
        ComClass com = new ComClass();
        
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new CoverPage(), formLoadArea);
        }

        private void hireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new hire(), formLoadArea);
        }

        private void packagesForHireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new packages_for_hire(), formLoadArea);
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new customer(), formLoadArea);
        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new driver(), formLoadArea);
        }

        private void rentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new rent(), formLoadArea);
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new vehicles(), formLoadArea);
        }

        private void typeOfVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new type_of_vehicle(), formLoadArea);
        }

        private void vehicleEmissionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new vehicle_emission_test(), formLoadArea);
        }

        private void ratesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new rates(), formLoadArea);
        }

        private void paymentMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new method_of_payment(), formLoadArea);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new CoverPage(), formLoadArea);
        }

        private void paymentOfHireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new payment_of_hire(), formLoadArea);
        }

        private void paymentOfRentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new paymnet_of_rent(), formLoadArea);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void hiredVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new vehicles_hire(), formLoadArea);
        }

        private void emisssionTestDeadlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new vehicles_test_expiry_date(), formLoadArea);
        }

        private void rentChargeFromCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            com.appsFormLoadInsidePanel(new customer_rent_charge(), formLoadArea);
        }

        private void formLoadArea_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
