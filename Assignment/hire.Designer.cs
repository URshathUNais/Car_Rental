namespace Assignment
{
    partial class hire
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
            this.label1 = new System.Windows.Forms.Label();
            this.hire_package_id_combox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vehicle_id_combox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customer_id_combox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.driver_id_combox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hire_waiting_extra_hour_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hire_extra_km_fees_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hire_date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.hire_start_date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.hire_end_date = new System.Windows.Forms.DateTimePicker();
            this.load_table = new System.Windows.Forms.DataGridView();
            this.save_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.hire_time = new System.Windows.Forms.DateTimePicker();
            this.hire_start_time = new System.Windows.Forms.DateTimePicker();
            this.hire_end_time = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.hire_start_km_box = new System.Windows.Forms.TextBox();
            this.close_btn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.load_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hire Package ID FK :";
            // 
            // hire_package_id_combox
            // 
            this.hire_package_id_combox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hire_package_id_combox.FormattingEnabled = true;
            this.hire_package_id_combox.Location = new System.Drawing.Point(406, 23);
            this.hire_package_id_combox.Name = "hire_package_id_combox";
            this.hire_package_id_combox.Size = new System.Drawing.Size(314, 24);
            this.hire_package_id_combox.TabIndex = 1;
            this.hire_package_id_combox.SelectedIndexChanged += new System.EventHandler(this.hire_package_id_combox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vehicle ID FK :";
            // 
            // vehicle_id_combox
            // 
            this.vehicle_id_combox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.vehicle_id_combox.FormattingEnabled = true;
            this.vehicle_id_combox.Location = new System.Drawing.Point(406, 54);
            this.vehicle_id_combox.Name = "vehicle_id_combox";
            this.vehicle_id_combox.Size = new System.Drawing.Size(314, 24);
            this.vehicle_id_combox.TabIndex = 1;
            this.vehicle_id_combox.SelectedIndexChanged += new System.EventHandler(this.vehicle_id_combox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer ID FK :";
            // 
            // customer_id_combox
            // 
            this.customer_id_combox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.customer_id_combox.FormattingEnabled = true;
            this.customer_id_combox.Location = new System.Drawing.Point(406, 84);
            this.customer_id_combox.Name = "customer_id_combox";
            this.customer_id_combox.Size = new System.Drawing.Size(314, 24);
            this.customer_id_combox.TabIndex = 1;
            this.customer_id_combox.SelectedIndexChanged += new System.EventHandler(this.customer_id_combox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Driver ID FK :";
            // 
            // driver_id_combox
            // 
            this.driver_id_combox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.driver_id_combox.FormattingEnabled = true;
            this.driver_id_combox.Location = new System.Drawing.Point(406, 114);
            this.driver_id_combox.Name = "driver_id_combox";
            this.driver_id_combox.Size = new System.Drawing.Size(314, 24);
            this.driver_id_combox.TabIndex = 1;
            this.driver_id_combox.SelectedIndexChanged += new System.EventHandler(this.driver_id_combox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hire Waiting Charge Extra Hour :";
            // 
            // hire_waiting_extra_hour_box
            // 
            this.hire_waiting_extra_hour_box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hire_waiting_extra_hour_box.Location = new System.Drawing.Point(406, 148);
            this.hire_waiting_extra_hour_box.Name = "hire_waiting_extra_hour_box";
            this.hire_waiting_extra_hour_box.Size = new System.Drawing.Size(314, 22);
            this.hire_waiting_extra_hour_box.TabIndex = 2;
            this.hire_waiting_extra_hour_box.TextChanged += new System.EventHandler(this.hire_waiting_extra_hour_box_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hire Extra KM Fees :";
            // 
            // hire_extra_km_fees_box
            // 
            this.hire_extra_km_fees_box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hire_extra_km_fees_box.Location = new System.Drawing.Point(406, 203);
            this.hire_extra_km_fees_box.Name = "hire_extra_km_fees_box";
            this.hire_extra_km_fees_box.Size = new System.Drawing.Size(314, 22);
            this.hire_extra_km_fees_box.TabIndex = 2;
            this.hire_extra_km_fees_box.TextChanged += new System.EventHandler(this.hire_waiting_charge_fees_box_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(170, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Hire Date Time :";
            // 
            // hire_date
            // 
            this.hire_date.CalendarTitleBackColor = System.Drawing.SystemColors.ScrollBar;
            this.hire_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hire_date.Location = new System.Drawing.Point(406, 232);
            this.hire_date.Name = "hire_date";
            this.hire_date.Size = new System.Drawing.Size(137, 22);
            this.hire_date.TabIndex = 4;
            this.hire_date.Value = new System.DateTime(2022, 6, 15, 6, 4, 16, 0);
            this.hire_date.ValueChanged += new System.EventHandler(this.hire_date_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(170, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Hire Start Date Time :";
            // 
            // hire_start_date
            // 
            this.hire_start_date.CalendarTitleBackColor = System.Drawing.SystemColors.ScrollBar;
            this.hire_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hire_start_date.Location = new System.Drawing.Point(406, 260);
            this.hire_start_date.Name = "hire_start_date";
            this.hire_start_date.Size = new System.Drawing.Size(137, 22);
            this.hire_start_date.TabIndex = 4;
            this.hire_start_date.Value = new System.DateTime(2022, 6, 15, 6, 3, 44, 0);
            this.hire_start_date.ValueChanged += new System.EventHandler(this.hire_start_date_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(170, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Hire End Date Time :";
            // 
            // hire_end_date
            // 
            this.hire_end_date.CalendarTitleBackColor = System.Drawing.SystemColors.ScrollBar;
            this.hire_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hire_end_date.Location = new System.Drawing.Point(406, 288);
            this.hire_end_date.Name = "hire_end_date";
            this.hire_end_date.Size = new System.Drawing.Size(137, 22);
            this.hire_end_date.TabIndex = 4;
            this.hire_end_date.ValueChanged += new System.EventHandler(this.hire_end_date_time_ValueChanged);
            // 
            // load_table
            // 
            this.load_table.AllowUserToAddRows = false;
            this.load_table.AllowUserToDeleteRows = false;
            this.load_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.load_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.load_table.Location = new System.Drawing.Point(83, 354);
            this.load_table.Name = "load_table";
            this.load_table.ReadOnly = true;
            this.load_table.RowHeadersWidth = 51;
            this.load_table.RowTemplate.Height = 24;
            this.load_table.Size = new System.Drawing.Size(1123, 334);
            this.load_table.TabIndex = 5;
            this.load_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.load_table_CellClick);
            this.load_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.load_table_CellContentClick);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(786, 84);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(89, 37);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Blue;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(786, 139);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(89, 42);
            this.update_btn.TabIndex = 6;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(786, 203);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(89, 36);
            this.delete_btn.TabIndex = 6;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // search_box
            // 
            this.search_box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.search_box.Location = new System.Drawing.Point(171, 326);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(237, 22);
            this.search_box.TabIndex = 2;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(86, 311);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(79, 37);
            this.search_btn.TabIndex = 7;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // hire_time
            // 
            this.hire_time.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.hire_time.CalendarTitleBackColor = System.Drawing.SystemColors.ScrollBar;
            this.hire_time.CustomFormat = "HH:mm:ss";
            this.hire_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hire_time.Location = new System.Drawing.Point(550, 232);
            this.hire_time.Name = "hire_time";
            this.hire_time.Size = new System.Drawing.Size(170, 22);
            this.hire_time.TabIndex = 8;
            this.hire_time.ValueChanged += new System.EventHandler(this.hire_time_ValueChanged);
            // 
            // hire_start_time
            // 
            this.hire_start_time.CalendarTitleBackColor = System.Drawing.SystemColors.ScrollBar;
            this.hire_start_time.CustomFormat = "HH:mm:ss";
            this.hire_start_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hire_start_time.Location = new System.Drawing.Point(549, 260);
            this.hire_start_time.Name = "hire_start_time";
            this.hire_start_time.Size = new System.Drawing.Size(170, 22);
            this.hire_start_time.TabIndex = 8;
            this.hire_start_time.ValueChanged += new System.EventHandler(this.hire_start_time_ValueChanged);
            // 
            // hire_end_time
            // 
            this.hire_end_time.CalendarTitleBackColor = System.Drawing.SystemColors.ScrollBar;
            this.hire_end_time.CustomFormat = "HH:mm:ss";
            this.hire_end_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hire_end_time.Location = new System.Drawing.Point(549, 287);
            this.hire_end_time.Name = "hire_end_time";
            this.hire_end_time.Size = new System.Drawing.Size(170, 22);
            this.hire_end_time.TabIndex = 8;
            this.hire_end_time.ValueChanged += new System.EventHandler(this.hire_end_time_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(170, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Hire Start KM :";
            // 
            // hire_start_km_box
            // 
            this.hire_start_km_box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hire_start_km_box.Location = new System.Drawing.Point(406, 177);
            this.hire_start_km_box.Name = "hire_start_km_box";
            this.hire_start_km_box.Size = new System.Drawing.Size(314, 22);
            this.hire_start_km_box.TabIndex = 10;
            this.hire_start_km_box.TextChanged += new System.EventHandler(this.hire_start_km_box_TextChanged);
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.BackColor = System.Drawing.Color.Red;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(1261, 8);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(27, 25);
            this.close_btn.TabIndex = 22;
            this.close_btn.Text = "X";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Assignment.Properties.Resources.new1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(966, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // hire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Assignment.Properties.Resources.sky_1024x576;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.hire_start_km_box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.hire_end_time);
            this.Controls.Add(this.hire_start_time);
            this.Controls.Add(this.hire_time);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.load_table);
            this.Controls.Add(this.hire_end_date);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.hire_start_date);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hire_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hire_extra_km_fees_box);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.hire_waiting_extra_hour_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.driver_id_combox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customer_id_combox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vehicle_id_combox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hire_package_id_combox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hire";
            this.Load += new System.EventHandler(this.hire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.load_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hire_package_id_combox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vehicle_id_combox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox customer_id_combox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox driver_id_combox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hire_waiting_extra_hour_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hire_extra_km_fees_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker hire_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker hire_start_date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker hire_end_date;
        private System.Windows.Forms.DataGridView load_table;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DateTimePicker hire_time;
        private System.Windows.Forms.DateTimePicker hire_start_time;
        private System.Windows.Forms.DateTimePicker hire_end_time;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox hire_start_km_box;
        private System.Windows.Forms.Label close_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}