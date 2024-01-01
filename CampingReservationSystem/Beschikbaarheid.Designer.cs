namespace CampingReservationSystem
{
    partial class Beschikbaarheid
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
            this.placesdata = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.lbllist = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.dtpend = new System.Windows.Forms.DateTimePicker();
            this.dtpstart = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.placesdata)).BeginInit();
            this.SuspendLayout();
            // 
            // placesdata
            // 
            this.placesdata.AllowUserToAddRows = false;
            this.placesdata.AllowUserToDeleteRows = false;
            this.placesdata.AllowUserToResizeColumns = false;
            this.placesdata.AllowUserToResizeRows = false;
            this.placesdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.placesdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.placesdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.placesdata.DefaultCellStyle = dataGridViewCellStyle2;
            this.placesdata.GridColor = System.Drawing.Color.DodgerBlue;
            this.placesdata.Location = new System.Drawing.Point(395, 32);
            this.placesdata.MultiSelect = false;
            this.placesdata.Name = "placesdata";
            this.placesdata.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.placesdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.placesdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.placesdata.Size = new System.Drawing.Size(357, 320);
            this.placesdata.TabIndex = 18;
            this.placesdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.placesdata_CellContentClick);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Maroon;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(3, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 35);
            this.btnback.TabIndex = 19;
            this.btnback.Text = "Terug";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lbllist
            // 
            this.lbllist.AutoSize = true;
            this.lbllist.Font = new System.Drawing.Font("Centaur", 15F);
            this.lbllist.Location = new System.Drawing.Point(525, 6);
            this.lbllist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllist.Name = "lbllist";
            this.lbllist.Size = new System.Drawing.Size(135, 23);
            this.lbllist.TabIndex = 20;
            this.lbllist.Text = "Beschikbaarheid :";
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.LightGray;
            this.btncheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncheck.Font = new System.Drawing.Font("Centaur", 15F);
            this.btncheck.Location = new System.Drawing.Point(501, 358);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(179, 29);
            this.btncheck.TabIndex = 21;
            this.btncheck.Text = "Controleer datums ";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btnok_Click);
            // 
            // dtpend
            // 
            this.dtpend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpend.CustomFormat = "dd-MM-yyyy";
            this.dtpend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpend.Location = new System.Drawing.Point(103, 187);
            this.dtpend.MinDate = new System.DateTime(2022, 11, 9, 0, 0, 0, 0);
            this.dtpend.Name = "dtpend";
            this.dtpend.Size = new System.Drawing.Size(200, 20);
            this.dtpend.TabIndex = 43;
            // 
            // dtpstart
            // 
            this.dtpstart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpstart.CustomFormat = "dd-MM-yyyy";
            this.dtpstart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpstart.Location = new System.Drawing.Point(103, 111);
            this.dtpstart.MinDate = new System.DateTime(2022, 11, 9, 0, 0, 0, 0);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(200, 20);
            this.dtpstart.TabIndex = 42;
            this.dtpstart.ValueChanged += new System.EventHandler(this.dtpstart_ValueChanged);
            // 
            // Beschikbaarheid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::CampingReservationSystem.Properties.Resources.logo1;
            this.ClientSize = new System.Drawing.Size(852, 394);
            this.ControlBox = false;
            this.Controls.Add(this.dtpend);
            this.Controls.Add(this.dtpstart);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.lbllist);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.placesdata);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Beschikbaarheid";
            this.Text = "Beschikbaarheid";
            this.Load += new System.EventHandler(this.Availibleplaces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.placesdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView placesdata;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lbllist;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.DateTimePicker dtpend;
        private System.Windows.Forms.DateTimePicker dtpstart;
    }
}