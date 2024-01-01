namespace CampingReservationSystem
{
    partial class GebruikerWijzigSelectie
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
            this.userdata = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.lblselect = new System.Windows.Forms.Label();
            this.lblhere = new System.Windows.Forms.Label();
            this.btnchange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).BeginInit();
            this.SuspendLayout();
            // 
            // userdata
            // 
            this.userdata.AllowUserToAddRows = false;
            this.userdata.AllowUserToDeleteRows = false;
            this.userdata.AllowUserToResizeColumns = false;
            this.userdata.AllowUserToResizeRows = false;
            this.userdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userdata.DefaultCellStyle = dataGridViewCellStyle2;
            this.userdata.GridColor = System.Drawing.Color.DodgerBlue;
            this.userdata.Location = new System.Drawing.Point(17, 51);
            this.userdata.MultiSelect = false;
            this.userdata.Name = "userdata";
            this.userdata.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.userdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userdata.Size = new System.Drawing.Size(497, 242);
            this.userdata.TabIndex = 26;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Maroon;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(1, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 37);
            this.btnback.TabIndex = 27;
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
            this.btnselect.Location = new System.Drawing.Point(213, 312);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(90, 29);
            this.btnselect.TabIndex = 28;
            this.btnselect.Text = "Selecteer";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblselect.Location = new System.Drawing.Point(177, 9);
            this.lblselect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(145, 23);
            this.lblselect.TabIndex = 29;
            this.lblselect.Text = "selecteer gebruiker ";
            // 
            // lblhere
            // 
            this.lblhere.AutoSize = true;
            this.lblhere.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblhere.Location = new System.Drawing.Point(26, 357);
            this.lblhere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhere.Name = "lblhere";
            this.lblhere.Size = new System.Drawing.Size(325, 23);
            this.lblhere.TabIndex = 31;
            this.lblhere.Text = " klik hier om het gebruikerstype te wijzigen ";
            // 
            // btnchange
            // 
            this.btnchange.BackColor = System.Drawing.Color.LightGray;
            this.btnchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnchange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnchange.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnchange.Location = new System.Drawing.Point(356, 352);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(113, 33);
            this.btnchange.TabIndex = 30;
            this.btnchange.Text = "Wijzig";
            this.btnchange.UseVisualStyleBackColor = false;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // WijzigWerkerSelectie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(538, 393);
            this.ControlBox = false;
            this.Controls.Add(this.lblhere);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.lblselect);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.userdata);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WijzigWerkerSelectie";
            this.Text = "gebruikers selectie";
            this.Load += new System.EventHandler(this.Edituser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userdata;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.Label lblhere;
        private System.Windows.Forms.Button btnchange;
    }
}