namespace CampingReservationSystem
{
    partial class WerkerVoegen
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
            this.lblenter = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.chkowner = new System.Windows.Forms.CheckBox();
            this.chkemployee = new System.Windows.Forms.CheckBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblenter
            // 
            this.lblenter.AutoSize = true;
            this.lblenter.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblenter.Location = new System.Drawing.Point(169, 9);
            this.lblenter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblenter.Name = "lblenter";
            this.lblenter.Size = new System.Drawing.Size(105, 23);
            this.lblenter.TabIndex = 7;
            this.lblenter.Text = "Enter Details";
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(-1, -1);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 29);
            this.btnback.TabIndex = 16;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnadd.Location = new System.Drawing.Point(173, 295);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(102, 29);
            this.btnadd.TabIndex = 23;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // chkowner
            // 
            this.chkowner.AutoSize = true;
            this.chkowner.Font = new System.Drawing.Font("Centaur", 15F);
            this.chkowner.Location = new System.Drawing.Point(266, 244);
            this.chkowner.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkowner.Name = "chkowner";
            this.chkowner.Size = new System.Drawing.Size(78, 27);
            this.chkowner.TabIndex = 22;
            this.chkowner.Text = "Owner";
            this.chkowner.UseVisualStyleBackColor = true;
            // 
            // chkemployee
            // 
            this.chkemployee.AutoSize = true;
            this.chkemployee.Font = new System.Drawing.Font("Centaur", 15F);
            this.chkemployee.Location = new System.Drawing.Point(113, 244);
            this.chkemployee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkemployee.Name = "chkemployee";
            this.chkemployee.Size = new System.Drawing.Size(123, 27);
            this.chkemployee.TabIndex = 21;
            this.chkemployee.Text = "Medewerker ";
            this.chkemployee.UseVisualStyleBackColor = true;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(207, 94);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(162, 20);
            this.txtname.TabIndex = 20;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(207, 168);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(162, 20);
            this.txtpassword.TabIndex = 19;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblpassword.Location = new System.Drawing.Point(85, 163);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(108, 23);
            this.lblpassword.TabIndex = 18;
            this.lblpassword.Text = "wachtwoord :";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(73, 90);
            this.lblusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(130, 23);
            this.lblusername.TabIndex = 17;
            this.lblusername.Text = "gebruikersnaam :";
            // 
            // adduser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(459, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.chkowner);
            this.Controls.Add(this.chkemployee);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblenter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "adduser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.adduser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblenter;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.CheckBox chkowner;
        private System.Windows.Forms.CheckBox chkemployee;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
    }
}