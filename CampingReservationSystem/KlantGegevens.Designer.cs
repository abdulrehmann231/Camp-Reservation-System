namespace CampingReservationSystem
{
    partial class KlantGegevens
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
            this.btnback = new System.Windows.Forms.Button();
            this.newcustomerbox = new System.Windows.Forms.GroupBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblzipcode = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.btnsavecustomer = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtzipcode = new System.Windows.Forms.TextBox();
            this.txtadress = new System.Windows.Forms.TextBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbldetails = new System.Windows.Forms.Label();
            this.btneditcustomer = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnlist = new System.Windows.Forms.Button();
            this.newcustomerbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Maroon;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(1, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 29);
            this.btnback.TabIndex = 15;
            this.btnback.Text = "Terug";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // newcustomerbox
            // 
            this.newcustomerbox.BackColor = System.Drawing.Color.Transparent;
            this.newcustomerbox.Controls.Add(this.lblemail);
            this.newcustomerbox.Controls.Add(this.lblphone);
            this.newcustomerbox.Controls.Add(this.lblzipcode);
            this.newcustomerbox.Controls.Add(this.lbladdress);
            this.newcustomerbox.Controls.Add(this.lblsurname);
            this.newcustomerbox.Controls.Add(this.lblname);
            this.newcustomerbox.Controls.Add(this.btnsavecustomer);
            this.newcustomerbox.Controls.Add(this.txtemail);
            this.newcustomerbox.Controls.Add(this.txtphone);
            this.newcustomerbox.Controls.Add(this.txtzipcode);
            this.newcustomerbox.Controls.Add(this.txtadress);
            this.newcustomerbox.Controls.Add(this.txtsurname);
            this.newcustomerbox.Controls.Add(this.txtname);
            this.newcustomerbox.Location = new System.Drawing.Point(34, 44);
            this.newcustomerbox.Name = "newcustomerbox";
            this.newcustomerbox.Size = new System.Drawing.Size(331, 299);
            this.newcustomerbox.TabIndex = 16;
            this.newcustomerbox.TabStop = false;
            this.newcustomerbox.Text = "Klant invoeren";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblemail.Location = new System.Drawing.Point(7, 209);
            this.lblemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(76, 23);
            this.lblemail.TabIndex = 40;
            this.lblemail.Text = "E-mail :";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblphone.Location = new System.Drawing.Point(5, 173);
            this.lblphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(159, 23);
            this.lblphone.TabIndex = 39;
            this.lblphone.Text = "Telefoonnummer :";
            // 
            // lblzipcode
            // 
            this.lblzipcode.AutoSize = true;
            this.lblzipcode.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblzipcode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblzipcode.Location = new System.Drawing.Point(5, 133);
            this.lblzipcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblzipcode.Name = "lblzipcode";
            this.lblzipcode.Size = new System.Drawing.Size(95, 23);
            this.lblzipcode.TabIndex = 38;
            this.lblzipcode.Text = "Postcode :";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbladdress.Location = new System.Drawing.Point(5, 94);
            this.lbladdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(68, 23);
            this.lbladdress.TabIndex = 37;
            this.lbladdress.Text = "Adres :";
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsurname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsurname.Location = new System.Drawing.Point(5, 55);
            this.lblsurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(113, 23);
            this.lblsurname.TabIndex = 36;
            this.lblsurname.Text = "Achternaam:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblname.Location = new System.Drawing.Point(5, 19);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(70, 23);
            this.lblname.TabIndex = 35;
            this.lblname.Text = "Naam :";
            // 
            // btnsavecustomer
            // 
            this.btnsavecustomer.BackColor = System.Drawing.Color.LightGray;
            this.btnsavecustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsavecustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsavecustomer.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnsavecustomer.Location = new System.Drawing.Point(101, 248);
            this.btnsavecustomer.Name = "btnsavecustomer";
            this.btnsavecustomer.Size = new System.Drawing.Size(102, 29);
            this.btnsavecustomer.TabIndex = 17;
            this.btnsavecustomer.Text = "Opslaan";
            this.btnsavecustomer.UseVisualStyleBackColor = false;
            this.btnsavecustomer.Click += new System.EventHandler(this.btnsavecustomer_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(163, 215);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(162, 20);
            this.txtemail.TabIndex = 28;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(163, 179);
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(162, 20);
            this.txtphone.TabIndex = 26;
            // 
            // txtzipcode
            // 
            this.txtzipcode.Location = new System.Drawing.Point(163, 139);
            this.txtzipcode.Multiline = true;
            this.txtzipcode.Name = "txtzipcode";
            this.txtzipcode.Size = new System.Drawing.Size(162, 20);
            this.txtzipcode.TabIndex = 24;
            // 
            // txtadress
            // 
            this.txtadress.Location = new System.Drawing.Point(163, 100);
            this.txtadress.Multiline = true;
            this.txtadress.Name = "txtadress";
            this.txtadress.Size = new System.Drawing.Size(162, 20);
            this.txtadress.TabIndex = 22;
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(163, 61);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(162, 20);
            this.txtsurname.TabIndex = 20;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(163, 22);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(162, 20);
            this.txtname.TabIndex = 18;
            // 
            // lbldetails
            // 
            this.lbldetails.AutoSize = true;
            this.lbldetails.BackColor = System.Drawing.Color.Transparent;
            this.lbldetails.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldetails.Location = new System.Drawing.Point(216, 9);
            this.lbldetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldetails.Name = "lbldetails";
            this.lbldetails.Size = new System.Drawing.Size(111, 23);
            this.lbldetails.TabIndex = 6;
            this.lbldetails.Text = "Klant opties";
            // 
            // btneditcustomer
            // 
            this.btneditcustomer.BackColor = System.Drawing.Color.LightGray;
            this.btneditcustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneditcustomer.Font = new System.Drawing.Font("Centaur", 15F);
            this.btneditcustomer.Location = new System.Drawing.Point(427, 51);
            this.btneditcustomer.Name = "btneditcustomer";
            this.btneditcustomer.Size = new System.Drawing.Size(129, 57);
            this.btneditcustomer.TabIndex = 29;
            this.btneditcustomer.Text = "Klanten wijzigen";
            this.btneditcustomer.UseVisualStyleBackColor = false;
            this.btneditcustomer.Click += new System.EventHandler(this.btneditcustomer_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.LightGray;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Centaur", 15F);
            this.btndelete.Location = new System.Drawing.Point(427, 157);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(129, 57);
            this.btndelete.TabIndex = 30;
            this.btndelete.Text = "Klanten verwijderen";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnlist
            // 
            this.btnlist.BackColor = System.Drawing.Color.LightGray;
            this.btnlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlist.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnlist.Location = new System.Drawing.Point(427, 286);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(129, 57);
            this.btnlist.TabIndex = 31;
            this.btnlist.Text = "Klanten lijst";
            this.btnlist.UseVisualStyleBackColor = false;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // KlantGegevens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::CampingReservationSystem.Properties.Resources.logo1;
            this.ClientSize = new System.Drawing.Size(568, 371);
            this.ControlBox = false;
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btneditcustomer);
            this.Controls.Add(this.lbldetails);
            this.Controls.Add(this.newcustomerbox);
            this.Controls.Add(this.btnback);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KlantGegevens";
            this.Text = "Klant gegevens";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            this.newcustomerbox.ResumeLayout(false);
            this.newcustomerbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.GroupBox newcustomerbox;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtzipcode;
        private System.Windows.Forms.TextBox txtadress;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbldetails;
        private System.Windows.Forms.Button btnsavecustomer;
        private System.Windows.Forms.Button btneditcustomer;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblzipcode;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Label lblname;
    }
}