namespace CampingReservationSystem
{
    partial class ReserveringSelecctie
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
            this.btnback = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.lblselect = new System.Windows.Forms.Label();
            this.reservationdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.reservationdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Maroon;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(7, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 33);
            this.btnback.TabIndex = 23;
            this.btnback.Text = "Terug";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.LightGray;
            this.btnselect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnselect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnselect.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnselect.Location = new System.Drawing.Point(353, 329);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(97, 29);
            this.btnselect.TabIndex = 26;
            this.btnselect.Text = "Selecteer";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblselect.Location = new System.Drawing.Point(328, 9);
            this.lblselect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(189, 23);
            this.lblselect.TabIndex = 25;
            this.lblselect.Text = "Selecteer een reservering :";
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
            this.reservationdata.Location = new System.Drawing.Point(21, 56);
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
            this.reservationdata.TabIndex = 24;
            this.reservationdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationdata_CellContentClick);
            // 
            // ReserveringSelecctie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::CampingReservationSystem.Properties.Resources.logo1;
            this.ClientSize = new System.Drawing.Size(840, 383);
            this.ControlBox = false;
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.lblselect);
            this.Controls.Add(this.reservationdata);
            this.Controls.Add(this.btnback);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReserveringSelecctie";
            this.Text = "Selecteer een reeservering";
            this.Load += new System.EventHandler(this.selectReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.DataGridView reservationdata;
    }
}