﻿namespace TheatreApplication
{
    partial class ReservationsSuperManagerForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpectacleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpectacleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(499, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 54);
            this.label1.TabIndex = 20;
            this.label1.Text = "Manage Reservations";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1197, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 54);
            this.button1.TabIndex = 21;
            this.button1.Text = "EXIT APPLICATION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 54);
            this.button2.TabIndex = 22;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.SpectacleName,
            this.SpectacleDate,
            this.CreatedBy,
            this.CreatedAt});
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1464, 639);
            this.dataGridView1.TabIndex = 23;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 8;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 150;
            // 
            // SpectacleName
            // 
            this.SpectacleName.HeaderText = "Spectacle Name";
            this.SpectacleName.MinimumWidth = 8;
            this.SpectacleName.Name = "SpectacleName";
            this.SpectacleName.ReadOnly = true;
            this.SpectacleName.Width = 150;
            // 
            // SpectacleDate
            // 
            this.SpectacleDate.HeaderText = "Spectacle Date";
            this.SpectacleDate.MinimumWidth = 8;
            this.SpectacleDate.Name = "SpectacleDate";
            this.SpectacleDate.ReadOnly = true;
            this.SpectacleDate.Width = 150;
            // 
            // CreatedBy
            // 
            this.CreatedBy.HeaderText = "Created By";
            this.CreatedBy.MinimumWidth = 8;
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.ReadOnly = true;
            this.CreatedBy.Width = 150;
            // 
            // CreatedAt
            // 
            this.CreatedAt.HeaderText = "Created At";
            this.CreatedAt.MinimumWidth = 8;
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Width = 150;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 738);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(259, 54);
            this.button3.TabIndex = 24;
            this.button3.Text = "APPROVE REFUND";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OrangeRed;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(277, 738);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(259, 54);
            this.button4.TabIndex = 25;
            this.button4.Text = "DENY REFUND";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ReservationsSuperManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1488, 804);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ReservationsSuperManagerForm";
            this.Text = "ReservationsSuperManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReservationsSuperManagerForm_FormClosing);
            this.Load += new System.EventHandler(this.ReservationsSuperManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpectacleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpectacleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
    }
}