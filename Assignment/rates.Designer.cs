namespace Assignment
{
    partial class rates
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
            this.vehicle_type_id_fk_combox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.per_day_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.per_week_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.per_month_box = new System.Windows.Forms.TextBox();
            this.load_table = new System.Windows.Forms.DataGridView();
            this.search_box = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(204, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Type ID FK :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // vehicle_type_id_fk_combox
            // 
            this.vehicle_type_id_fk_combox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.vehicle_type_id_fk_combox.FormattingEnabled = true;
            this.vehicle_type_id_fk_combox.Location = new System.Drawing.Point(370, 69);
            this.vehicle_type_id_fk_combox.Name = "vehicle_type_id_fk_combox";
            this.vehicle_type_id_fk_combox.Size = new System.Drawing.Size(272, 24);
            this.vehicle_type_id_fk_combox.TabIndex = 2;
            this.vehicle_type_id_fk_combox.SelectedIndexChanged += new System.EventHandler(this.vehicle_type_id_fk_combox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Per Day :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // per_day_box
            // 
            this.per_day_box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.per_day_box.Location = new System.Drawing.Point(370, 108);
            this.per_day_box.Name = "per_day_box";
            this.per_day_box.Size = new System.Drawing.Size(272, 22);
            this.per_day_box.TabIndex = 4;
            this.per_day_box.TextChanged += new System.EventHandler(this.per_day_box_TextChanged_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Per Week :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // per_week_box
            // 
            this.per_week_box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.per_week_box.Location = new System.Drawing.Point(370, 147);
            this.per_week_box.Name = "per_week_box";
            this.per_week_box.Size = new System.Drawing.Size(272, 22);
            this.per_week_box.TabIndex = 4;
            this.per_week_box.TextChanged += new System.EventHandler(this.per_week_box_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Per Month :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // per_month_box
            // 
            this.per_month_box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.per_month_box.Location = new System.Drawing.Point(370, 188);
            this.per_month_box.Name = "per_month_box";
            this.per_month_box.Size = new System.Drawing.Size(272, 22);
            this.per_month_box.TabIndex = 4;
            this.per_month_box.TextChanged += new System.EventHandler(this.per_month_box_TextChanged);
            // 
            // load_table
            // 
            this.load_table.AllowUserToAddRows = false;
            this.load_table.AllowUserToDeleteRows = false;
            this.load_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.load_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.load_table.Location = new System.Drawing.Point(119, 328);
            this.load_table.Name = "load_table";
            this.load_table.ReadOnly = true;
            this.load_table.RowHeadersWidth = 51;
            this.load_table.RowTemplate.Height = 24;
            this.load_table.Size = new System.Drawing.Size(1065, 348);
            this.load_table.TabIndex = 5;
            this.load_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.load_table_CellClick);
            this.load_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.load_table_CellContentClick);
            // 
            // search_box
            // 
            this.search_box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.search_box.Location = new System.Drawing.Point(208, 300);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(237, 22);
            this.search_box.TabIndex = 4;
            this.search_box.TextChanged += new System.EventHandler(this.search_box_TextChanged);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(709, 89);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(79, 32);
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
            this.update_btn.Location = new System.Drawing.Point(709, 130);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(79, 36);
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
            this.delete_btn.Location = new System.Drawing.Point(709, 172);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(79, 37);
            this.delete_btn.TabIndex = 6;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(120, 282);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 41);
            this.search_btn.TabIndex = 7;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
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
            this.close_btn.TabIndex = 20;
            this.close_btn.Text = "X";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Assignment.Properties.Resources.new1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(944, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // rates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Assignment.Properties.Resources.sky_1024x576;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.load_table);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.per_month_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.per_week_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.per_day_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vehicle_type_id_fk_combox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rates";
            this.Load += new System.EventHandler(this.rates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.load_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vehicle_type_id_fk_combox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox per_day_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox per_week_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox per_month_box;
        private System.Windows.Forms.DataGridView load_table;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label close_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}