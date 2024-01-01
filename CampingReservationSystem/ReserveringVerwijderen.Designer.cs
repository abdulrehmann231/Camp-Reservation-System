namespace CampingReservationSystem
{
    partial class ReserveringVerwijderen
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
            this.reservationdata = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.lblselect = new System.Windows.Forms.Label();
            this.btndelte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reservationdata)).BeginInit();
            this.SuspendLayout();
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
            this.reservationdata.Location = new System.Drawing.Point(19, 69);
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
            this.reservationdata.TabIndex = 19;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Maroon;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(2, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 32);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "Terug";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblselect.Location = new System.Drawing.Point(299, 9);
            this.lblselect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(180, 23);
            this.lblselect.TabIndex = 21;
            this.lblselect.Text = "Selecteer een reservering";
            // 
            // btndelte
            // 
            this.btndelte.BackColor = System.Drawing.Color.LightGray;
            this.btndelte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelte.Font = new System.Drawing.Font("Centaur", 15F);
            this.btndelte.Location = new System.Drawing.Point(336, 333);
            this.btndelte.Name = "btndelte";
            this.btndelte.Size = new System.Drawing.Size(97, 29);
            this.btndelte.TabIndex = 22;
            this.btndelte.Text = "Verwijder";
            this.btndelte.UseVisualStyleBackColor = false;
            this.btndelte.Click += new System.EventHandler(this.btndelte_Click);
            // 
            // ReserveringVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::CampingReservationSystem.Properties.Resources.logo1;
            this.ClientSize = new System.Drawing.Size(832, 374);
            this.ControlBox = false;
            this.Controls.Add(this.btndelte);
            this.Controls.Add(this.lblselect);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.reservationdata);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReserveringVerwijderen";
            this.Text = "Reservering verwijderen";
            this.Load += new System.EventHandler(this.DeleteReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservationdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reservationdata;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.Button btndelte;
    }
}