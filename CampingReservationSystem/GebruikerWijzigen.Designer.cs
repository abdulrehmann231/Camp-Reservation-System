namespace CampingReservationSystem
{
    partial class GebruikerWijzigen
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
            this.txtname.Location = new System.Drawing.Point(216, 120);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(162, 20);
            this.txtname.TabIndex = 25;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(216, 194);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(162, 20);
            this.txtpassword.TabIndex = 24;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblpassword.Location = new System.Drawing.Point(59, 191);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(128, 23);
            this.lblpassword.TabIndex = 23;
            this.lblpassword.Text = "Wachtwoord :";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblusername.Location = new System.Drawing.Point(59, 117);
            this.lblusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(152, 23);
            this.lblusername.TabIndex = 22;
            this.lblusername.Text = "Gebruikersnaam :";
            // 
            // lbledit
            // 
            this.lbledit.AutoSize = true;
            this.lbledit.BackColor = System.Drawing.Color.Transparent;
            this.lbledit.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbledit.Location = new System.Drawing.Point(142, 33);
            this.lbledit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbledit.Name = "lbledit";
            this.lbledit.Size = new System.Drawing.Size(141, 23);
            this.lbledit.TabIndex = 21;
            this.lbledit.Text = "Wijzig gegevens";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Maroon;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(6, 6);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 35);
            this.btnback.TabIndex = 28;
            this.btnback.Text = "Terug";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.LightGray;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnedit.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnedit.Location = new System.Drawing.Point(169, 242);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(78, 32);
            this.btnedit.TabIndex = 29;
            this.btnedit.Text = "Bevestig wijziging";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // GebruikerWijzigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::CampingReservationSystem.Properties.Resources.logo1;
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
            this.Name = "GebruikerWijzigen";
            this.Text = "Gebruikers gegevens wijzigen";
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