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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.userdata.Location = new System.Drawing.Point(12, 53);
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
            this.userdata.TabIndex = 19;
            this.userdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userdata_CellContentClick);
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(-2, -1);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 29);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnchange
            // 
            this.btnchange.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnchange.Location = new System.Drawing.Point(210, 344);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(113, 29);
            this.btnchange.TabIndex = 21;
            this.btnchange.Text = "CHANGE";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // lbllist
            // 
            this.lbllist.AutoSize = true;
            this.lbllist.Font = new System.Drawing.Font("Centaur", 15F);
            this.lbllist.Location = new System.Drawing.Point(206, 5);
            this.lbllist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllist.Name = "lbllist";
            this.lbllist.Size = new System.Drawing.Size(140, 23);
            this.lbllist.TabIndex = 22;
            this.lbllist.Text = "LIST OF USERS";
            // 
            // lblhere
            // 
            this.lblhere.AutoSize = true;
            this.lblhere.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblhere.Location = new System.Drawing.Point(79, 318);
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
            this.Text = "LIST";
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