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
            this.chkEigenaar = new System.Windows.Forms.CheckBox();
            this.chkWerknemer = new System.Windows.Forms.CheckBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblenter
            // 
            this.lblenter.AutoSize = true;
            this.lblenter.BackColor = System.Drawing.Color.Transparent;
            this.lblenter.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblenter.Location = new System.Drawing.Point(169, 9);
            this.lblenter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblenter.Name = "lblenter";
            this.lblenter.Size = new System.Drawing.Size(146, 23);
            this.lblenter.TabIndex = 7;
            this.lblenter.Text = "Voer gegevens in";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Maroon;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(5, 5);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 31);
            this.btnback.TabIndex = 16;
            this.btnback.Text = "Terug";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.LightGray;
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnadd.Location = new System.Drawing.Point(146, 290);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(102, 31);
            this.btnadd.TabIndex = 23;
            this.btnadd.Text = "Voeg toe";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // chkEigenaar
            // 
            this.chkEigenaar.AutoSize = true;
            this.chkEigenaar.BackColor = System.Drawing.Color.Transparent;
            this.chkEigenaar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkEigenaar.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEigenaar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkEigenaar.Location = new System.Drawing.Point(239, 239);
            this.chkEigenaar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkEigenaar.Name = "chkEigenaar";
            this.chkEigenaar.Size = new System.Drawing.Size(83, 27);
            this.chkEigenaar.TabIndex = 22;
            this.chkEigenaar.Text = "Owner";
            this.chkEigenaar.UseVisualStyleBackColor = false;
            this.chkEigenaar.CheckedChanged += new System.EventHandler(this.chkowner_CheckedChanged);
            // 
            // chkWerknemer
            // 
            this.chkWerknemer.AutoSize = true;
            this.chkWerknemer.BackColor = System.Drawing.Color.Transparent;
            this.chkWerknemer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkWerknemer.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWerknemer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkWerknemer.Location = new System.Drawing.Point(86, 239);
            this.chkWerknemer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkWerknemer.Name = "chkWerknemer";
            this.chkWerknemer.Size = new System.Drawing.Size(134, 27);
            this.chkWerknemer.TabIndex = 21;
            this.chkWerknemer.Text = "Medewerker ";
            this.chkWerknemer.UseVisualStyleBackColor = false;
            this.chkWerknemer.CheckedChanged += new System.EventHandler(this.chkemployee_CheckedChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(197, 88);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(162, 20);
            this.txtname.TabIndex = 20;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(197, 161);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(162, 20);
            this.txtpassword.TabIndex = 19;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblpassword.Location = new System.Drawing.Point(46, 158);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(128, 23);
            this.lblpassword.TabIndex = 18;
            this.lblpassword.Text = "Wachtwoord :";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblusername.Location = new System.Drawing.Point(46, 85);
            this.lblusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(152, 23);
            this.lblusername.TabIndex = 17;
            this.lblusername.Text = "Gebruikersnaam :";
            // 
            // WerkerVoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::CampingReservationSystem.Properties.Resources.logo1;
            this.ClientSize = new System.Drawing.Size(402, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.chkEigenaar);
            this.Controls.Add(this.chkWerknemer);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblenter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WerkerVoegen";
            this.Text = "Voeg gebruiker";
            this.Load += new System.EventHandler(this.adduser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblenter;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.CheckBox chkEigenaar;
        private System.Windows.Forms.CheckBox chkWerknemer;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblusername;
    }
}