namespace CampingReservationSystem
{
    partial class GebruikerVerwijderen
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
            this.lblselect = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.userdata = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.lblhere = new System.Windows.Forms.Label();
            this.btnchange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).BeginInit();
            this.SuspendLayout();
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblselect.Location = new System.Drawing.Point(196, 9);
            this.lblselect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(145, 23);
            this.lblselect.TabIndex = 23;
            this.lblselect.Text = "selecteer gebruiker ";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Maroon;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(5, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 32);
            this.btnback.TabIndex = 24;
            this.btnback.Text = "Terug";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
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
            this.userdata.Location = new System.Drawing.Point(5, 50);
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
            this.userdata.Size = new System.Drawing.Size(529, 242);
            this.userdata.TabIndex = 25;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.LightGray;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Centaur", 15F);
            this.btndelete.Location = new System.Drawing.Point(219, 298);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(92, 29);
            this.btndelete.TabIndex = 26;
            this.btndelete.Text = "Verwijder";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // lblhere
            // 
            this.lblhere.AutoSize = true;
            this.lblhere.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblhere.Location = new System.Drawing.Point(16, 358);
            this.lblhere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhere.Name = "lblhere";
            this.lblhere.Size = new System.Drawing.Size(325, 23);
            this.lblhere.TabIndex = 28;
            this.lblhere.Text = " klik hier om het gebruikerstype te wijzigen ";
            this.lblhere.Click += new System.EventHandler(this.lblhere_Click);
            // 
            // btnchange
            // 
            this.btnchange.BackColor = System.Drawing.Color.LightGray;
            this.btnchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnchange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnchange.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnchange.Location = new System.Drawing.Point(355, 358);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(113, 32);
            this.btnchange.TabIndex = 27;
            this.btnchange.Text = "Wijzig";
            this.btnchange.UseVisualStyleBackColor = false;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // GebruikerVerwijderen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(539, 399);
            this.ControlBox = false;
            this.Controls.Add(this.lblhere);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.userdata);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblselect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GebruikerVerwijderen";
            this.Text = "Gebruiker verwijderen";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DataGridView userdata;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label lblhere;
        private System.Windows.Forms.Button btnchange;
    }
}