namespace Assignment
{
    partial class vehicles_hire
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
            this.find_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicle_id_box = new System.Windows.Forms.TextBox();
            this.load_table = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close_btn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.load_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // find_btn
            // 
            this.find_btn.BackColor = System.Drawing.Color.SpringGreen;
            this.find_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.find_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_btn.Location = new System.Drawing.Point(527, 147);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(112, 41);
            this.find_btn.TabIndex = 7;
            this.find_btn.Text = "Find";
            this.find_btn.UseVisualStyleBackColor = false;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vehicles ID :";
            // 
            // vehicle_id_box
            // 
            this.vehicle_id_box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.vehicle_id_box.Location = new System.Drawing.Point(395, 96);
            this.vehicle_id_box.Name = "vehicle_id_box";
            this.vehicle_id_box.Size = new System.Drawing.Size(244, 22);
            this.vehicle_id_box.TabIndex = 5;
            // 
            // load_table
            // 
            this.load_table.AllowUserToAddRows = false;
            this.load_table.AllowUserToDeleteRows = false;
            this.load_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.load_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.load_table.Location = new System.Drawing.Point(92, 268);
            this.load_table.Name = "load_table";
            this.load_table.ReadOnly = true;
            this.load_table.RowHeadersWidth = 51;
            this.load_table.RowTemplate.Height = 24;
            this.load_table.Size = new System.Drawing.Size(1116, 382);
            this.load_table.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Assignment.Properties.Resources.new1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(968, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
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
            this.close_btn.TabIndex = 29;
            this.close_btn.Text = "X";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // vehicles_hire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment.Properties.Resources.sky_1024x576;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.find_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicle_id_box);
            this.Controls.Add(this.load_table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vehicles_hire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vehicles_hire";
            ((System.ComponentModel.ISupportInitialize)(this.load_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vehicle_id_box;
        private System.Windows.Forms.DataGridView load_table;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label close_btn;
    }
}