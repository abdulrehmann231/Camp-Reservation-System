namespace CampingReservationSystem
{
    partial class WijzigWerker
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lbledit = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(203, 120);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(162, 20);
            this.txtname.TabIndex = 25;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(203, 194);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(162, 20);
            this.txtpassword.TabIndex = 24;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblpassword.Location = new System.Drawing.Point(81, 189);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(108, 23);
            this.lblpassword.TabIndex = 23;
            this.lblpassword.Text = "wachtwoord :";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(59, 117);
            this.lblusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(130, 23);
            this.lblusername.TabIndex = 22;
            this.lblusername.Text = "gebruikersnaam :";
            // 
            // lbledit
            // 
            this.lbledit.AutoSize = true;
            this.lbledit.Font = new System.Drawing.Font("Centaur", 15F);
            this.lbledit.Location = new System.Drawing.Point(142, 33);
            this.lbledit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbledit.Name = "lbledit";
            this.lbledit.Size = new System.Drawing.Size(98, 23);
            this.lbledit.TabIndex = 21;
            this.lbledit.Text = "Edit Details";
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(-1, -1);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 29);
            this.btnback.TabIndex = 28;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnedit.Location = new System.Drawing.Point(169, 242);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(78, 29);
            this.btnedit.TabIndex = 29;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // Edituserdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(396, 329);
            this.ControlBox = false;
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lbledit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edituserdetails";
            this.Text = "Edituserdetails";
            this.Load += new System.EventHandler(this.Edituserdetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lbledit;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnedit;
    }
}