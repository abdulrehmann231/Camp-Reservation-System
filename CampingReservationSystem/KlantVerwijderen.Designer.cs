namespace CampingReservationSystem
{
    partial class KlantVerwijderen
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
            this.customerdata = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.lblselect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerdata)).BeginInit();
            this.SuspendLayout();
            // 
            // customerdata
            // 
            this.customerdata.AllowUserToAddRows = false;
            this.customerdata.AllowUserToDeleteRows = false;
            this.customerdata.AllowUserToResizeColumns = false;
            this.customerdata.AllowUserToResizeRows = false;
            this.customerdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.customerdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerdata.DefaultCellStyle = dataGridViewCellStyle2;
            this.customerdata.GridColor = System.Drawing.Color.DodgerBlue;
            this.customerdata.Location = new System.Drawing.Point(8, 45);
            this.customerdata.MultiSelect = false;
            this.customerdata.Name = "customerdata";
            this.customerdata.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.customerdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerdata.Size = new System.Drawing.Size(796, 242);
            this.customerdata.TabIndex = 18;
            this.customerdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerdata_CellContentClick);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Maroon;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(7, 4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 35);
            this.btnback.TabIndex = 19;
            this.btnback.Text = "Terug";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.LightGray;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Centaur", 15F);
            this.btndelete.Location = new System.Drawing.Point(328, 304);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(105, 29);
            this.btndelete.TabIndex = 20;
            this.btndelete.Text = "Verwijder";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblselect.Location = new System.Drawing.Point(311, 5);
            this.lblselect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(144, 23);
            this.lblselect.TabIndex = 21;
            this.lblselect.Text = "selecteer een klant ";
            this.lblselect.Click += new System.EventHandler(this.lbldetails_Click);
            // 
            // KlantVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::CampingReservationSystem.Properties.Resources.logo1;
            this.ClientSize = new System.Drawing.Size(810, 355);
            this.ControlBox = false;
            this.Controls.Add(this.lblselect);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.customerdata);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KlantVerwijderen";
            this.Text = "Klant verwijderen";
            this.Load += new System.EventHandler(this.DeleteCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerdata;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label lblselect;
    }
}