namespace CampingReservationSystem
{
    partial class KlantWijzigen
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
            this.lblchange = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.newcustomerbox = new System.Windows.Forms.GroupBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblzipcode = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.btnchange = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtzipcode = new System.Windows.Forms.TextBox();
            this.txtadress = new System.Windows.Forms.TextBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.newcustomerbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblchange
            // 
            this.lblchange.AutoSize = true;
            this.lblchange.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblchange.Location = new System.Drawing.Point(156, 9);
            this.lblchange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblchange.Name = "lblchange";
            this.lblchange.Size = new System.Drawing.Size(139, 23);
            this.lblchange.TabIndex = 8;
            this.lblchange.Text = "gegevens wijzigen ";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Maroon;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(8, 5);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 29);
            this.btnback.TabIndex = 17;
            this.btnback.Text = "Terug";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // newcustomerbox
            // 
            this.newcustomerbox.BackgroundImage = global::CampingReservationSystem.Properties.Resources.logo1;
            this.newcustomerbox.Controls.Add(this.lblemail);
            this.newcustomerbox.Controls.Add(this.lblphone);
            this.newcustomerbox.Controls.Add(this.lblzipcode);
            this.newcustomerbox.Controls.Add(this.lbladdress);
            this.newcustomerbox.Controls.Add(this.lblsurname);
            this.newcustomerbox.Controls.Add(this.lblname);
            this.newcustomerbox.Controls.Add(this.btnchange);
            this.newcustomerbox.Controls.Add(this.txtemail);
            this.newcustomerbox.Controls.Add(this.txtphone);
            this.newcustomerbox.Controls.Add(this.txtzipcode);
            this.newcustomerbox.Controls.Add(this.txtadress);
            this.newcustomerbox.Controls.Add(this.txtsurname);
            this.newcustomerbox.Controls.Add(this.txtname);
            this.newcustomerbox.Location = new System.Drawing.Point(88, 51);
            this.newcustomerbox.Name = "newcustomerbox";
            this.newcustomerbox.Size = new System.Drawing.Size(345, 310);
            this.newcustomerbox.TabIndex = 18;
            this.newcustomerbox.TabStop = false;
            this.newcustomerbox.Text = "Klant gegevens wijzigen";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblemail.Location = new System.Drawing.Point(7, 209);
            this.lblemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(68, 23);
            this.lblemail.TabIndex = 40;
            this.lblemail.Text = "E-mail :";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblphone.Location = new System.Drawing.Point(5, 173);
            this.lblphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(143, 23);
            this.lblphone.TabIndex = 39;
            this.lblphone.Text = "Telefoonnummer :";
            // 
            // lblzipcode
            // 
            this.lblzipcode.AutoSize = true;
            this.lblzipcode.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblzipcode.Location = new System.Drawing.Point(5, 133);
            this.lblzipcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblzipcode.Name = "lblzipcode";
            this.lblzipcode.Size = new System.Drawing.Size(85, 23);
            this.lblzipcode.TabIndex = 38;
            this.lblzipcode.Text = "Postcode :";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Centaur", 15F);
            this.lbladdress.Location = new System.Drawing.Point(5, 94);
            this.lbladdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(61, 23);
            this.lbladdress.TabIndex = 37;
            this.lbladdress.Text = "Adres :";
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblsurname.Location = new System.Drawing.Point(5, 55);
            this.lblsurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(102, 23);
            this.lblsurname.TabIndex = 36;
            this.lblsurname.Text = "Achternaam:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblname.Location = new System.Drawing.Point(5, 19);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(64, 23);
            this.lblname.TabIndex = 35;
            this.lblname.Text = "Naam :";
            // 
            // btnchange
            // 
            this.btnchange.BackColor = System.Drawing.Color.LightGray;
            this.btnchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnchange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnchange.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnchange.Location = new System.Drawing.Point(101, 248);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(102, 36);
            this.btnchange.TabIndex = 17;
            this.btnchange.Text = "Wijzig";
            this.btnchange.UseVisualStyleBackColor = false;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(177, 212);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(162, 20);
            this.txtemail.TabIndex = 28;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(177, 176);
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(162, 20);
            this.txtphone.TabIndex = 26;
            // 
            // txtzipcode
            // 
            this.txtzipcode.Location = new System.Drawing.Point(177, 136);
            this.txtzipcode.Multiline = true;
            this.txtzipcode.Name = "txtzipcode";
            this.txtzipcode.Size = new System.Drawing.Size(162, 20);
            this.txtzipcode.TabIndex = 24;
            // 
            // txtadress
            // 
            this.txtadress.Location = new System.Drawing.Point(177, 97);
            this.txtadress.Multiline = true;
            this.txtadress.Name = "txtadress";
            this.txtadress.Size = new System.Drawing.Size(162, 20);
            this.txtadress.TabIndex = 22;
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(177, 58);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(162, 20);
            this.txtsurname.TabIndex = 20;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(177, 19);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(162, 20);
            this.txtname.TabIndex = 18;
            // 
            // KlantWijzigen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(486, 401);
            this.ControlBox = false;
            this.Controls.Add(this.newcustomerbox);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblchange);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KlantWijzigen";
            this.Text = "Gegevens wijzigen";
            this.Load += new System.EventHandler(this.editdetailscustomer_Load);
            this.newcustomerbox.ResumeLayout(false);
            this.newcustomerbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblchange;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.GroupBox newcustomerbox;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtzipcode;
        private System.Windows.Forms.TextBox txtadress;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblzipcode;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Label lblname;
    }
}