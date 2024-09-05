namespace Assignment
{
    partial class vehicle_emission_test
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
            this.vehicle_id_fk_combox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.test_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.expire_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.total_amount_box = new System.Windows.Forms.TextBox();
            this.load_table = new System.Windows.Forms.DataGridView();
            this.search_box = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.test_time = new System.Windows.Forms.DateTimePicker();
            this.expire_time = new System.Windows.Forms.DateTimePicker();
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
            this.label1.Location = new System.Drawing.Point(229, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle ID FK :";
            // 
            // vehicle_id_fk_combox
            // 
            this.vehicle_id_fk_combox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.vehicle_id_fk_combox.FormattingEnabled = true;
            this.vehicle_id_fk_combox.Location = new System.Drawing.Point(365, 45);
            this.vehicle_id_fk_combox.Name = "vehicle_id_fk_combox";
            this.vehicle_id_fk_combox.Size = new System.Drawing.Size(245, 24);
            this.vehicle_id_fk_combox.TabIndex = 1;
            this.vehicle_id_fk_combox.SelectedIndexChanged += new System.EventHandler(this.vehicle_id_fk_combox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Test Date :";
            // 
            // test_date
            // 
            this.test_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.test_date.Location = new System.Drawing.Point(365, 83);
            this.test_date.Name = "test_date";
            this.test_date.Size = new System.Drawing.Size(127, 22);
            this.test_date.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Expire Date :";
            // 
            // expire_date
            // 
            this.expire_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expire_date.Location = new System.Drawing.Point(365, 121);
            this.expire_date.Name = "expire_date";
            this.expire_date.Size = new System.Drawing.Size(127, 22);
            this.expire_date.TabIndex = 2;
            this.expire_date.ValueChanged += new System.EventHandler(this.expire_date_picker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Amount :";
            // 
            // total_amount_box
            // 
            this.total_amount_box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.total_amount_box.Location = new System.Drawing.Point(365, 162);
            this.total_amount_box.Name = "total_amount_box";
            this.total_amount_box.Size = new System.Drawing.Size(245, 22);
            this.total_amount_box.TabIndex = 3;
            this.total_amount_box.TextChanged += new System.EventHandler(this.total_amount_box_TextChanged);
            // 
            // load_table
            // 
            this.load_table.AllowUserToAddRows = false;
            this.load_table.AllowUserToDeleteRows = false;
            this.load_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.load_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.load_table.Location = new System.Drawing.Point(150, 269);
            this.load_table.Name = "load_table";
            this.load_table.ReadOnly = true;
            this.load_table.RowHeadersWidth = 51;
            this.load_table.RowTemplate.Height = 24;
            this.load_table.Size = new System.Drawing.Size(991, 393);
            this.load_table.TabIndex = 4;
            this.load_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.load_table_CellClick);
            this.load_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.load_table_CellContentClick);
            // 
            // search_box
            // 
            this.search_box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.search_box.Location = new System.Drawing.Point(229, 241);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(245, 22);
            this.search_box.TabIndex = 3;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(663, 58);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(86, 33);
            this.save_btn.TabIndex = 5;
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
            this.update_btn.Location = new System.Drawing.Point(663, 97);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(86, 33);
            this.update_btn.TabIndex = 5;
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
            this.delete_btn.Location = new System.Drawing.Point(663, 136);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(86, 35);
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
            this.search_btn.Location = new System.Drawing.Point(151, 222);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 40);
            this.search_btn.TabIndex = 6;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // test_time
            // 
            this.test_time.CustomFormat = "HH:mm:ss";
            this.test_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.test_time.Location = new System.Drawing.Point(498, 83);
            this.test_time.Name = "test_time";
            this.test_time.Size = new System.Drawing.Size(112, 22);
            this.test_time.TabIndex = 9;
            // 
            // expire_time
            // 
            this.expire_time.CustomFormat = "HH:mm:ss";
            this.expire_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expire_time.Location = new System.Drawing.Point(498, 121);
            this.expire_time.Name = "expire_time";
            this.expire_time.Size = new System.Drawing.Size(112, 22);
            this.expire_time.TabIndex = 9;
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
            this.close_btn.TabIndex = 25;
            this.close_btn.Text = "X";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Assignment.Properties.Resources.new1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(901, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // vehicle_emission_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Assignment.Properties.Resources.sky_1024x576;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.expire_time);
            this.Controls.Add(this.test_time);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.load_table);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.total_amount_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.expire_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.test_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vehicle_id_fk_combox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vehicle_emission_test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vehicle_emission_test";
            this.Load += new System.EventHandler(this.vehicle_emission_test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.load_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vehicle_id_fk_combox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker test_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker expire_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox total_amount_box;
        private System.Windows.Forms.DataGridView load_table;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DateTimePicker test_time;
        private System.Windows.Forms.DateTimePicker expire_time;
        private System.Windows.Forms.Label close_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}