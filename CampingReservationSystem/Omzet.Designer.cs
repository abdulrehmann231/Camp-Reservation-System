namespace CampingReservationSystem
{
    partial class Omzet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblrevenue = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.reservationdata = new System.Windows.Forms.DataGridView();
            this.btninvoice = new System.Windows.Forms.Button();
            this.lblclick = new System.Windows.Forms.Label();
            this.lblearned = new System.Windows.Forms.Label();
            this.lblearnedd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reservationdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblrevenue
            // 
            this.lblrevenue.AutoSize = true;
            this.lblrevenue.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblrevenue.Location = new System.Drawing.Point(452, 9);
            this.lblrevenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrevenue.Name = "lblrevenue";
            this.lblrevenue.Size = new System.Drawing.Size(60, 23);
            this.lblrevenue.TabIndex = 7;
            this.lblrevenue.Text = "Omzet";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Maroon;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(5, 4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 32);
            this.btnback.TabIndex = 16;
            this.btnback.Text = "Terug";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // reservationdata
            // 
            this.reservationdata.AllowUserToAddRows = false;
            this.reservationdata.AllowUserToDeleteRows = false;
            this.reservationdata.AllowUserToResizeColumns = false;
            this.reservationdata.AllowUserToResizeRows = false;
            this.reservationdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservationdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.reservationdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.reservationdata.DefaultCellStyle = dataGridViewCellStyle2;
            this.reservationdata.GridColor = System.Drawing.Color.DodgerBlue;
            this.reservationdata.Location = new System.Drawing.Point(161, 42);
            this.reservationdata.MultiSelect = false;
            this.reservationdata.Name = "reservationdata";
            this.reservationdata.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservationdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.reservationdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservationdata.Size = new System.Drawing.Size(796, 242);
            this.reservationdata.TabIndex = 18;
            // 
            // btninvoice
            // 
            this.btninvoice.BackColor = System.Drawing.Color.LightGray;
            this.btninvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btninvoice.Font = new System.Drawing.Font("Centaur", 15F);
            this.btninvoice.Location = new System.Drawing.Point(752, 338);
            this.btninvoice.Name = "btninvoice";
            this.btninvoice.Size = new System.Drawing.Size(120, 68);
            this.btninvoice.TabIndex = 19;
            this.btninvoice.Text = "Factuur bekijken";
            this.btninvoice.UseVisualStyleBackColor = false;
            this.btninvoice.Click += new System.EventHandler(this.btninvoice_Click);
            // 
            // lblclick
            // 
            this.lblclick.AutoSize = true;
            this.lblclick.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblclick.Location = new System.Drawing.Point(351, 354);
            this.lblclick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblclick.Name = "lblclick";
            this.lblclick.Size = new System.Drawing.Size(381, 23);
            this.lblclick.TabIndex = 20;
            this.lblclick.Text = " klik hier om de factuur van deze reservering te zien";
            // 
            // lblearned
            // 
            this.lblearned.AutoSize = true;
            this.lblearned.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblearned.Location = new System.Drawing.Point(545, 303);
            this.lblearned.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblearned.Name = "lblearned";
            this.lblearned.Size = new System.Drawing.Size(131, 23);
            this.lblearned.TabIndex = 21;
            this.lblearned.Text = "Totaal verdient :";
            // 
            // lblearnedd
            // 
            this.lblearnedd.AutoSize = true;
            this.lblearnedd.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblearnedd.Location = new System.Drawing.Point(734, 303);
            this.lblearnedd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblearnedd.Name = "lblearnedd";
            this.lblearnedd.Size = new System.Drawing.Size(60, 23);
            this.lblearnedd.TabIndex = 22;
            this.lblearnedd.Text = "Omzet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CampingReservationSystem.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(5, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Omzet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(960, 418);
            this.ControlBox = false;
            this.Controls.Add(this.lblearnedd);
            this.Controls.Add(this.lblearned);
            this.Controls.Add(this.lblclick);
            this.Controls.Add(this.btninvoice);
            this.Controls.Add(this.reservationdata);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblrevenue);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Omzet";
            this.Text = "Omzet";
            this.Load += new System.EventHandler(this.Revenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrevenue;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView reservationdata;
        private System.Windows.Forms.Button btninvoice;
        private System.Windows.Forms.Label lblclick;
        private System.Windows.Forms.Label lblearned;
        private System.Windows.Forms.Label lblearnedd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}