namespace Assignment
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formLoadArea = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packagesForHireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeOfVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleEmissionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ratesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentOfHireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentOfRentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiredVehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emisssionTestDeadlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentChargeFromCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.close_btn = new System.Windows.Forms.Label();
            this.formLoadArea.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formLoadArea
            // 
            this.formLoadArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.formLoadArea.BackgroundImage = global::Assignment.Properties.Resources.sky_1024x576;
            this.formLoadArea.Controls.Add(this.groupBox1);
            this.formLoadArea.Location = new System.Drawing.Point(12, 43);
            this.formLoadArea.Name = "formLoadArea";
            this.formLoadArea.Size = new System.Drawing.Size(1315, 745);
            this.formLoadArea.TabIndex = 0;
            this.formLoadArea.Paint += new System.Windows.Forms.PaintEventHandler(this.formLoadArea_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, -31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 28);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formsToolStripMenuItem,
            this.driverToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.hireToolStripMenuItem,
            this.rentToolStripMenuItem,
            this.vehiclesToolStripMenuItem,
            this.ratesToolStripMenuItem,
            this.paymentMethodToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1345, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.formsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.formsToolStripMenuItem.Text = "File";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // driverToolStripMenuItem
            // 
            this.driverToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            this.driverToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.driverToolStripMenuItem.Text = "Driver";
            this.driverToolStripMenuItem.Click += new System.EventHandler(this.driverToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // hireToolStripMenuItem
            // 
            this.hireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.packagesForHireToolStripMenuItem});
            this.hireToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hireToolStripMenuItem.Name = "hireToolStripMenuItem";
            this.hireToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.hireToolStripMenuItem.Text = "Hire";
            this.hireToolStripMenuItem.Click += new System.EventHandler(this.hireToolStripMenuItem_Click);
            // 
            // packagesForHireToolStripMenuItem
            // 
            this.packagesForHireToolStripMenuItem.Name = "packagesForHireToolStripMenuItem";
            this.packagesForHireToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.packagesForHireToolStripMenuItem.Text = "Packages For Hire";
            this.packagesForHireToolStripMenuItem.Click += new System.EventHandler(this.packagesForHireToolStripMenuItem_Click);
            // 
            // rentToolStripMenuItem
            // 
            this.rentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentToolStripMenuItem.Name = "rentToolStripMenuItem";
            this.rentToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.rentToolStripMenuItem.Text = "Rent";
            this.rentToolStripMenuItem.Click += new System.EventHandler(this.rentToolStripMenuItem_Click);
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeOfVehicleToolStripMenuItem,
            this.vehicleEmissionTestToolStripMenuItem});
            this.vehiclesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.vehiclesToolStripMenuItem.Text = "Vehicles";
            this.vehiclesToolStripMenuItem.Click += new System.EventHandler(this.vehiclesToolStripMenuItem_Click);
            // 
            // typeOfVehicleToolStripMenuItem
            // 
            this.typeOfVehicleToolStripMenuItem.Name = "typeOfVehicleToolStripMenuItem";
            this.typeOfVehicleToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.typeOfVehicleToolStripMenuItem.Text = "Type Of Vehicle";
            this.typeOfVehicleToolStripMenuItem.Click += new System.EventHandler(this.typeOfVehicleToolStripMenuItem_Click);
            // 
            // vehicleEmissionTestToolStripMenuItem
            // 
            this.vehicleEmissionTestToolStripMenuItem.Name = "vehicleEmissionTestToolStripMenuItem";
            this.vehicleEmissionTestToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.vehicleEmissionTestToolStripMenuItem.Text = "Vehicle Emission Test";
            this.vehicleEmissionTestToolStripMenuItem.Click += new System.EventHandler(this.vehicleEmissionTestToolStripMenuItem_Click);
            // 
            // ratesToolStripMenuItem
            // 
            this.ratesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratesToolStripMenuItem.Name = "ratesToolStripMenuItem";
            this.ratesToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ratesToolStripMenuItem.Text = "Rates";
            this.ratesToolStripMenuItem.Click += new System.EventHandler(this.ratesToolStripMenuItem_Click);
            // 
            // paymentMethodToolStripMenuItem
            // 
            this.paymentMethodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentOfHireToolStripMenuItem,
            this.paymentOfRentToolStripMenuItem});
            this.paymentMethodToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodToolStripMenuItem.Name = "paymentMethodToolStripMenuItem";
            this.paymentMethodToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.paymentMethodToolStripMenuItem.Text = "Payment Method";
            this.paymentMethodToolStripMenuItem.Click += new System.EventHandler(this.paymentMethodToolStripMenuItem_Click);
            // 
            // paymentOfHireToolStripMenuItem
            // 
            this.paymentOfHireToolStripMenuItem.Name = "paymentOfHireToolStripMenuItem";
            this.paymentOfHireToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.paymentOfHireToolStripMenuItem.Text = "Payment Of Hire";
            this.paymentOfHireToolStripMenuItem.Click += new System.EventHandler(this.paymentOfHireToolStripMenuItem_Click);
            // 
            // paymentOfRentToolStripMenuItem
            // 
            this.paymentOfRentToolStripMenuItem.Name = "paymentOfRentToolStripMenuItem";
            this.paymentOfRentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.paymentOfRentToolStripMenuItem.Text = "Payment Of Rent";
            this.paymentOfRentToolStripMenuItem.Click += new System.EventHandler(this.paymentOfRentToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiredVehiclesToolStripMenuItem,
            this.emisssionTestDeadlineToolStripMenuItem,
            this.rentChargeFromCustomerToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // hiredVehiclesToolStripMenuItem
            // 
            this.hiredVehiclesToolStripMenuItem.Name = "hiredVehiclesToolStripMenuItem";
            this.hiredVehiclesToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.hiredVehiclesToolStripMenuItem.Text = "Hired Vehicles";
            this.hiredVehiclesToolStripMenuItem.Click += new System.EventHandler(this.hiredVehiclesToolStripMenuItem_Click);
            // 
            // emisssionTestDeadlineToolStripMenuItem
            // 
            this.emisssionTestDeadlineToolStripMenuItem.Name = "emisssionTestDeadlineToolStripMenuItem";
            this.emisssionTestDeadlineToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.emisssionTestDeadlineToolStripMenuItem.Text = "Emisssion Test Deadline";
            this.emisssionTestDeadlineToolStripMenuItem.Click += new System.EventHandler(this.emisssionTestDeadlineToolStripMenuItem_Click);
            // 
            // rentChargeFromCustomerToolStripMenuItem
            // 
            this.rentChargeFromCustomerToolStripMenuItem.Name = "rentChargeFromCustomerToolStripMenuItem";
            this.rentChargeFromCustomerToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.rentChargeFromCustomerToolStripMenuItem.Text = "Hire Driver Rate";
            this.rentChargeFromCustomerToolStripMenuItem.Click += new System.EventHandler(this.rentChargeFromCustomerToolStripMenuItem_Click);
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.BackColor = System.Drawing.Color.Red;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(1306, 3);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(27, 25);
            this.close_btn.TabIndex = 21;
            this.close_btn.Text = "X";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1345, 800);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.formLoadArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.formLoadArea.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formLoadArea;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packagesForHireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeOfVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleEmissionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ratesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentOfHireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentOfRentToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label close_btn;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiredVehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emisssionTestDeadlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentChargeFromCustomerToolStripMenuItem;
    }
}