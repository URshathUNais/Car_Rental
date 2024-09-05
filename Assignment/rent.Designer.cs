namespace Assignment
{
    partial class rent
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_id_fk_combox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vehicle_id_fk_combox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.driver_id_fk_combox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rent_days_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rent_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.rent_start_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.rent_end_date = new System.Windows.Forms.DateTimePicker();
            this.load_table = new System.Windows.Forms.DataGridView();
            this.search_box = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.rent_time = new System.Windows.Forms.DateTimePicker();
            this.rent_start_time = new System.Windows.Forms.DateTimePicker();
            this.rent_end_time = new System.Windows.Forms.DateTimePicker();
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
            this.label1.Location = new System.Drawing.Point(211, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID FK :";
            // 
            // customer_id_fk_combox
            // 
            this.customer_id_fk_combox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.customer_id_fk_combox.FormattingEnabled = true;
            this.customer_id_fk_combox.Location = new System.Drawing.Point(361, 38);
            this.customer_id_fk_combox.Name = "customer_id_fk_combox";
            this.customer_id_fk_combox.Size = new System.Drawing.Size(267, 24);
            this.customer_id_fk_combox.TabIndex = 1;
            this.customer_id_fk_combox.SelectedIndexChanged += new System.EventHandler(this.customer_id_fk_combox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vehicle ID FK :";
            // 
            // vehicle_id_fk_combox
            // 
            this.vehicle_id_fk_combox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.vehicle_id_fk_combox.FormattingEnabled = true;
            this.vehicle_id_fk_combox.Location = new System.Drawing.Point(361, 68);
            this.vehicle_id_fk_combox.Name = "vehicle_id_fk_combox";
            this.vehicle_id_fk_combox.Size = new System.Drawing.Size(267, 24);
            this.vehicle_id_fk_combox.TabIndex = 1;
            this.vehicle_id_fk_combox.SelectedIndexChanged += new System.EventHandler(this.vehicle_id_fk_combox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Driver ID FK :";
            // 
            // driver_id_fk_combox
            // 
            this.driver_id_fk_combox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.driver_id_fk_combox.FormattingEnabled = true;
            this.driver_id_fk_combox.Location = new System.Drawing.Point(361, 98);
            this.driver_id_fk_combox.Name = "driver_id_fk_combox";
            this.driver_id_fk_combox.Size = new System.Drawing.Size(267, 24);
            this.driver_id_fk_combox.TabIndex = 1;
            this.driver_id_fk_combox.SelectedIndexChanged += new System.EventHandler(this.driver_id_fk_combox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rent Days :";
            // 
            // rent_days_box
            // 
            this.rent_days_box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rent_days_box.Location = new System.Drawing.Point(361, 129);
            this.rent_days_box.Name = "rent_days_box";
            this.rent_days_box.Size = new System.Drawing.Size(267, 22);
            this.rent_days_box.TabIndex = 2;
            this.rent_days_box.TextChanged += new System.EventHandler(this.rent_days_box_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rent Date :";
            // 
            // rent_date
            // 
            this.rent_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rent_date.Location = new System.Drawing.Point(361, 158);
            this.rent_date.Name = "rent_date";
            this.rent_date.Size = new System.Drawing.Size(123, 22);
            this.rent_date.TabIndex = 3;
            this.rent_date.Value = new System.DateTime(2022, 6, 15, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(211, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Rent Start Date :";
            // 
            // rent_start_date
            // 
            this.rent_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rent_start_date.Location = new System.Drawing.Point(361, 186);
            this.rent_start_date.Name = "rent_start_date";
            this.rent_start_date.Size = new System.Drawing.Size(123, 22);
            this.rent_start_date.TabIndex = 3;
            this.rent_start_date.Value = new System.DateTime(2022, 6, 15, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rent End Date :";
            // 
            // rent_end_date
            // 
            this.rent_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rent_end_date.Location = new System.Drawing.Point(361, 214);
            this.rent_end_date.Name = "rent_end_date";
            this.rent_end_date.Size = new System.Drawing.Size(123, 22);
            this.rent_end_date.TabIndex = 3;
            this.rent_end_date.Value = new System.DateTime(2022, 6, 15, 0, 0, 0, 0);
            // 
            // load_table
            // 
            this.load_table.AllowUserToAddRows = false;
            this.load_table.AllowUserToDeleteRows = false;
            this.load_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.load_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.load_table.Location = new System.Drawing.Point(132, 316);
            this.load_table.Name = "load_table";
            this.load_table.ReadOnly = true;
            this.load_table.RowHeadersWidth = 51;
            this.load_table.RowTemplate.Height = 24;
            this.load_table.Size = new System.Drawing.Size(1035, 372);
            this.load_table.TabIndex = 4;
            this.load_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.load_table_CellClick);
            this.load_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.load_table_CellContentClick);
            // 
            // search_box
            // 
            this.search_box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.search_box.Location = new System.Drawing.Point(209, 288);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(267, 22);
            this.search_box.TabIndex = 2;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(701, 68);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(95, 37);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Blue;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(701, 111);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(95, 37);
            this.update_btn.TabIndex = 5;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(701, 157);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(95, 37);
            this.delete_btn.TabIndex = 5;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(128, 273);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 38);
            this.search_btn.TabIndex = 6;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // rent_time
            // 
            this.rent_time.CustomFormat = "HH:mm:ss";
            this.rent_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rent_time.Location = new System.Drawing.Point(487, 158);
            this.rent_time.Name = "rent_time";
            this.rent_time.Size = new System.Drawing.Size(140, 22);
            this.rent_time.TabIndex = 9;
            // 
            // rent_start_time
            // 
            this.rent_start_time.CustomFormat = "HH:mm:ss";
            this.rent_start_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rent_start_time.Location = new System.Drawing.Point(487, 186);
            this.rent_start_time.Name = "rent_start_time";
            this.rent_start_time.Size = new System.Drawing.Size(140, 22);
            this.rent_start_time.TabIndex = 9;
            // 
            // rent_end_time
            // 
            this.rent_end_time.CustomFormat = "HH:mm:ss";
            this.rent_end_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rent_end_time.Location = new System.Drawing.Point(487, 214);
            this.rent_end_time.Name = "rent_end_time";
            this.rent_end_time.Size = new System.Drawing.Size(140, 22);
            this.rent_end_time.TabIndex = 9;
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.BackColor = System.Drawing.Color.Red;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(1261, 9);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(27, 25);
            this.close_btn.TabIndex = 21;
            this.close_btn.Text = "X";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Assignment.Properties.Resources.new1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(927, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Assignment.Properties.Resources.sky_1024x576;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.rent_end_time);
            this.Controls.Add(this.rent_start_time);
            this.Controls.Add(this.rent_time);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.load_table);
            this.Controls.Add(this.rent_end_date);
            this.Controls.Add(this.rent_start_date);
            this.Controls.Add(this.rent_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.rent_days_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.driver_id_fk_combox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vehicle_id_fk_combox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customer_id_fk_combox);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rent";
            this.Load += new System.EventHandler(this.rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.load_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox customer_id_fk_combox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox vehicle_id_fk_combox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox driver_id_fk_combox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rent_days_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker rent_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker rent_start_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker rent_end_date;
        private System.Windows.Forms.DataGridView load_table;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.DateTimePicker rent_time;
        private System.Windows.Forms.DateTimePicker rent_start_time;
        private System.Windows.Forms.DateTimePicker rent_end_time;
        private System.Windows.Forms.Label close_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}