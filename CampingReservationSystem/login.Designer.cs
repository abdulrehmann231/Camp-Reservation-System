namespace CampingReservationSystem
{
    partial class login
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
            this.lbllogin = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.chkWerknemer = new System.Windows.Forms.CheckBox();
            this.chkEigenaar = new System.Windows.Forms.CheckBox();
            this.btnsignin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.Color.Transparent;
            this.lbllogin.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbllogin.Location = new System.Drawing.Point(151, 21);
            this.lbllogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(79, 23);
            this.lbllogin.TabIndex = 5;
            this.lbllogin.Text = "Inloggen";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblusername.Location = new System.Drawing.Point(65, 110);
            this.lblusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(152, 23);
            this.lblusername.TabIndex = 6;
            this.lblusername.Text = "Gebruikersnaam :";
            this.lblusername.Click += new System.EventHandler(this.lblusername_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblpassword.Location = new System.Drawing.Point(65, 183);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(128, 23);
            this.lblpassword.TabIndex = 7;
            this.lblpassword.Text = "Wachtwoord :";
            this.lblpassword.Click += new System.EventHandler(this.lblpassword_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(216, 186);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(162, 20);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(216, 113);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(162, 20);
            this.txtname.TabIndex = 0;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // chkWerknemer
            // 
            this.chkWerknemer.AutoSize = true;
            this.chkWerknemer.BackColor = System.Drawing.Color.Transparent;
            this.chkWerknemer.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWerknemer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkWerknemer.Location = new System.Drawing.Point(105, 264);
            this.chkWerknemer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkWerknemer.Name = "chkWerknemer";
            this.chkWerknemer.Size = new System.Drawing.Size(123, 27);
            this.chkWerknemer.TabIndex = 2;
            this.chkWerknemer.Text = "Werknemer";
            this.chkWerknemer.UseVisualStyleBackColor = false;
            this.chkWerknemer.CheckedChanged += new System.EventHandler(this.chkemployee_CheckedChanged);
            // 
            // chkEigenaar
            // 
            this.chkEigenaar.AutoSize = true;
            this.chkEigenaar.BackColor = System.Drawing.Color.Transparent;
            this.chkEigenaar.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEigenaar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkEigenaar.Location = new System.Drawing.Point(258, 264);
            this.chkEigenaar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkEigenaar.Name = "chkEigenaar";
            this.chkEigenaar.Size = new System.Drawing.Size(99, 27);
            this.chkEigenaar.TabIndex = 3;
            this.chkEigenaar.Text = "Eigenaar";
            this.chkEigenaar.UseVisualStyleBackColor = false;
            this.chkEigenaar.CheckedChanged += new System.EventHandler(this.chkowner_CheckedChanged);
            // 
            // btnsignin
            // 
            this.btnsignin.BackColor = System.Drawing.Color.LightGray;
            this.btnsignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsignin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsignin.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnsignin.Location = new System.Drawing.Point(155, 315);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(102, 29);
            this.btnsignin.TabIndex = 4;
            this.btnsignin.Text = "LOG IN";
            this.btnsignin.UseVisualStyleBackColor = false;
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Maroon;
            this.btnexit.BackgroundImage = global::CampingReservationSystem.Properties.Resources.shutdown_1;
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnexit.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnexit.Location = new System.Drawing.Point(314, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(88, 41);
            this.btnexit.TabIndex = 5;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::CampingReservationSystem.Properties.Resources.logo1;
            this.ClientSize = new System.Drawing.Size(405, 408);
            this.ControlBox = false;
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.chkEigenaar);
            this.Controls.Add(this.chkWerknemer);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lbllogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.CheckBox chkWerknemer;
        private System.Windows.Forms.CheckBox chkEigenaar;
        private System.Windows.Forms.Button btnsignin;
        private System.Windows.Forms.Button btnexit;

    }
}

