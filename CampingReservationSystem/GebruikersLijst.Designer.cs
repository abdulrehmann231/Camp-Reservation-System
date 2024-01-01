namespace CampingReservationSystem
{
    partial class userlist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userdata = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.lbllist = new System.Windows.Forms.Label();
            this.lblhere = new System.Windows.Forms.Label();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.userdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userdata.DefaultCellStyle = dataGridViewCellStyle5;
            this.userdata.GridColor = System.Drawing.Color.DodgerBlue;
            this.userdata.Location = new System.Drawing.Point(12, 53);
            this.userdata.MultiSelect = false;
            this.userdata.Name = "userdata";
            this.userdata.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.userdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userdata.Size = new System.Drawing.Size(529, 242);
            this.userdata.TabIndex = 19;
            this.userdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userdata_CellContentClick);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Maroon;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(12, 5);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 32);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "Terug";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnchange
            // 
            this.btnchange.BackColor = System.Drawing.Color.LightGray;
            this.btnchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnchange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnchange.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnchange.Location = new System.Drawing.Point(210, 354);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(113, 34);
            this.btnchange.TabIndex = 21;
            this.btnchange.Text = "Wijzig";
            this.btnchange.UseVisualStyleBackColor = false;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // lbllist
            // 
            this.lbllist.AutoSize = true;
            this.lbllist.Font = new System.Drawing.Font("Centaur", 15F);
            this.lbllist.Location = new System.Drawing.Point(206, 5);
            this.lbllist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllist.Name = "lbllist";
            this.lbllist.Size = new System.Drawing.Size(150, 23);
            this.lbllist.TabIndex = 22;
            this.lbllist.Text = "Lijst van gebruikers";
            // 
            // lblhere
            // 
            this.lblhere.AutoSize = true;
            this.lblhere.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblhere.Location = new System.Drawing.Point(105, 319);
            this.lblhere.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhere.Name = "lblhere";
            this.lblhere.Size = new System.Drawing.Size(325, 23);
            this.lblhere.TabIndex = 23;
            this.lblhere.Text = " klik hier om het gebruikerstype te wijzigen ";
            // 
            // userlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::CampingReservationSystem.Properties.Resources.logo1;
            this.ClientSize = new System.Drawing.Size(553, 430);
            this.ControlBox = false;
            this.Controls.Add(this.lblhere);
            this.Controls.Add(this.lbllist);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.userdata);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "userlist";
            this.Text = "Gebruikers lijst";
            this.Load += new System.EventHandler(this.userlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userdata;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Label lbllist;
        private System.Windows.Forms.Label lblhere;
    }
}