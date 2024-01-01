namespace CampingReservationSystem
{
    partial class NieuweReservering
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
            this.lblfill = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblnamevalue = new System.Windows.Forms.Label();
            this.lblplace = new System.Windows.Forms.Label();
            this.listplaces = new System.Windows.Forms.ComboBox();
            this.lblarrival = new System.Windows.Forms.Label();
            this.lbldeparture = new System.Windows.Forms.Label();
            this.dtpstart = new System.Windows.Forms.DateTimePicker();
            this.dtpend = new System.Windows.Forms.DateTimePicker();
            this.lbladults = new System.Windows.Forms.Label();
            this.nuadults = new System.Windows.Forms.NumericUpDown();
            this.lblkids = new System.Windows.Forms.Label();
            this.nukids = new System.Windows.Forms.NumericUpDown();
            this.lblcars = new System.Windows.Forms.Label();
            this.nucars = new System.Windows.Forms.NumericUpDown();
            this.lblvisitors = new System.Windows.Forms.Label();
            this.nuvisitors = new System.Windows.Forms.NumericUpDown();
            this.lblbigcaravan = new System.Windows.Forms.Label();
            this.nubigcaravan = new System.Windows.Forms.NumericUpDown();
            this.lblsmallcaravan = new System.Windows.Forms.Label();
            this.nusmallcaravan = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nubigtents = new System.Windows.Forms.NumericUpDown();
            this.lblelectricty = new System.Windows.Forms.Label();
            this.nuelectricty = new System.Windows.Forms.NumericUpDown();
            this.lblshower = new System.Windows.Forms.Label();
            this.nushower = new System.Windows.Forms.NumericUpDown();
            this.lblwash = new System.Windows.Forms.Label();
            this.nuwash = new System.Windows.Forms.NumericUpDown();
            this.lblpet = new System.Windows.Forms.Label();
            this.chkNee = new System.Windows.Forms.CheckBox();
            this.chkJa = new System.Windows.Forms.CheckBox();
            this.btninvoice = new System.Windows.Forms.Button();
            this.lblsmalltent = new System.Windows.Forms.Label();
            this.nusmalltent = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nuadults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nukids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nucars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuvisitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubigcaravan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nusmallcaravan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubigtents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuelectricty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nushower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuwash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nusmalltent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Maroon;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(6, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 35);
            this.btnback.TabIndex = 16;
            this.btnback.Text = "Terug";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblfill
            // 
            this.lblfill.AutoSize = true;
            this.lblfill.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblfill.Location = new System.Drawing.Point(469, 1);
            this.lblfill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfill.Name = "lblfill";
            this.lblfill.Size = new System.Drawing.Size(157, 23);
            this.lblfill.TabIndex = 17;
            this.lblfill.Text = "Vul alle gegevens in ";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblname.Location = new System.Drawing.Point(100, 47);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(64, 23);
            this.lblname.TabIndex = 18;
            this.lblname.Text = "Naam :";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblnamevalue
            // 
            this.lblnamevalue.AutoSize = true;
            this.lblnamevalue.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblnamevalue.Location = new System.Drawing.Point(206, 47);
            this.lblnamevalue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnamevalue.Name = "lblnamevalue";
            this.lblnamevalue.Size = new System.Drawing.Size(49, 23);
            this.lblnamevalue.TabIndex = 19;
            this.lblnamevalue.Text = "naam";
            this.lblnamevalue.Click += new System.EventHandler(this.lblnamevalue_Click);
            // 
            // lblplace
            // 
            this.lblplace.AutoSize = true;
            this.lblplace.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblplace.Location = new System.Drawing.Point(23, 83);
            this.lblplace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblplace.Name = "lblplace";
            this.lblplace.Size = new System.Drawing.Size(300, 23);
            this.lblplace.TabIndex = 20;
            this.lblplace.Text = "Selecteer een plaats voor uw reservering: ";
            // 
            // listplaces
            // 
            this.listplaces.FormattingEnabled = true;
            this.listplaces.Location = new System.Drawing.Point(341, 83);
            this.listplaces.Name = "listplaces";
            this.listplaces.Size = new System.Drawing.Size(121, 21);
            this.listplaces.TabIndex = 22;
            // 
            // lblarrival
            // 
            this.lblarrival.AutoSize = true;
            this.lblarrival.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblarrival.Location = new System.Drawing.Point(23, 126);
            this.lblarrival.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblarrival.Name = "lblarrival";
            this.lblarrival.Size = new System.Drawing.Size(130, 23);
            this.lblarrival.TabIndex = 23;
            this.lblarrival.Text = "kies startdatum :";
            // 
            // lbldeparture
            // 
            this.lbldeparture.AutoSize = true;
            this.lbldeparture.Font = new System.Drawing.Font("Centaur", 15F);
            this.lbldeparture.Location = new System.Drawing.Point(23, 167);
            this.lbldeparture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldeparture.Name = "lbldeparture";
            this.lbldeparture.Size = new System.Drawing.Size(129, 23);
            this.lbldeparture.TabIndex = 24;
            this.lbldeparture.Text = "kies einddatum: ";
            // 
            // dtpstart
            // 
            this.dtpstart.CustomFormat = "dd-MM-yyyy";
            this.dtpstart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpstart.Location = new System.Drawing.Point(200, 124);
            this.dtpstart.MinDate = new System.DateTime(2022, 11, 9, 0, 0, 0, 0);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(200, 20);
            this.dtpstart.TabIndex = 40;
            this.dtpstart.ValueChanged += new System.EventHandler(this.dtpstart_ValueChanged);
            // 
            // dtpend
            // 
            this.dtpend.CustomFormat = "dd-MM-yyyy";
            this.dtpend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpend.Location = new System.Drawing.Point(200, 165);
            this.dtpend.MinDate = new System.DateTime(2022, 11, 9, 0, 0, 0, 0);
            this.dtpend.Name = "dtpend";
            this.dtpend.Size = new System.Drawing.Size(200, 20);
            this.dtpend.TabIndex = 41;
            // 
            // lbladults
            // 
            this.lbladults.AutoSize = true;
            this.lbladults.Font = new System.Drawing.Font("Centaur", 15F);
            this.lbladults.Location = new System.Drawing.Point(23, 209);
            this.lbladults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladults.Name = "lbladults";
            this.lbladults.Size = new System.Drawing.Size(388, 23);
            this.lbladults.TabIndex = 42;
            this.lbladults.Text = "selecteer het aantal volwassenen voor uw reservering: ";
            // 
            // nuadults
            // 
            this.nuadults.Location = new System.Drawing.Point(417, 213);
            this.nuadults.Name = "nuadults";
            this.nuadults.Size = new System.Drawing.Size(45, 20);
            this.nuadults.TabIndex = 43;
            // 
            // lblkids
            // 
            this.lblkids.AutoSize = true;
            this.lblkids.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblkids.Location = new System.Drawing.Point(23, 249);
            this.lblkids.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblkids.Name = "lblkids";
            this.lblkids.Size = new System.Drawing.Size(471, 23);
            this.lblkids.TabIndex = 44;
            this.lblkids.Text = "selecteer het aantal kinderen (ouder dan 4) voor uw reservering: ";
            // 
            // nukids
            // 
            this.nukids.Location = new System.Drawing.Point(499, 249);
            this.nukids.Name = "nukids";
            this.nukids.Size = new System.Drawing.Size(45, 20);
            this.nukids.TabIndex = 45;
            // 
            // lblcars
            // 
            this.lblcars.AutoSize = true;
            this.lblcars.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblcars.Location = new System.Drawing.Point(23, 288);
            this.lblcars.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcars.Name = "lblcars";
            this.lblcars.Size = new System.Drawing.Size(317, 23);
            this.lblcars.TabIndex = 46;
            this.lblcars.Text = "selecteer aantal auto\'s voor uw reservering: ";
            // 
            // nucars
            // 
            this.nucars.Location = new System.Drawing.Point(366, 292);
            this.nucars.Name = "nucars";
            this.nucars.Size = new System.Drawing.Size(45, 20);
            this.nucars.TabIndex = 47;
            // 
            // lblvisitors
            // 
            this.lblvisitors.AutoSize = true;
            this.lblvisitors.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblvisitors.Location = new System.Drawing.Point(23, 325);
            this.lblvisitors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvisitors.Name = "lblvisitors";
            this.lblvisitors.Size = new System.Drawing.Size(365, 23);
            this.lblvisitors.TabIndex = 48;
            this.lblvisitors.Text = "selecteer het aantal bezoekers voor uw reservering:";
            // 
            // nuvisitors
            // 
            this.nuvisitors.Location = new System.Drawing.Point(417, 328);
            this.nuvisitors.Name = "nuvisitors";
            this.nuvisitors.Size = new System.Drawing.Size(45, 20);
            this.nuvisitors.TabIndex = 49;
            // 
            // lblbigcaravan
            // 
            this.lblbigcaravan.AutoSize = true;
            this.lblbigcaravan.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblbigcaravan.Location = new System.Drawing.Point(611, 195);
            this.lblbigcaravan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbigcaravan.Name = "lblbigcaravan";
            this.lblbigcaravan.Size = new System.Drawing.Size(261, 23);
            this.lblbigcaravan.TabIndex = 50;
            this.lblbigcaravan.Text = "selecteer het aantal grote caravans :";
            // 
            // nubigcaravan
            // 
            this.nubigcaravan.Location = new System.Drawing.Point(888, 199);
            this.nubigcaravan.Name = "nubigcaravan";
            this.nubigcaravan.Size = new System.Drawing.Size(45, 20);
            this.nubigcaravan.TabIndex = 51;
            // 
            // lblsmallcaravan
            // 
            this.lblsmallcaravan.AutoSize = true;
            this.lblsmallcaravan.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblsmallcaravan.Location = new System.Drawing.Point(611, 236);
            this.lblsmallcaravan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsmallcaravan.Name = "lblsmallcaravan";
            this.lblsmallcaravan.Size = new System.Drawing.Size(267, 23);
            this.lblsmallcaravan.TabIndex = 52;
            this.lblsmallcaravan.Text = "selecteer het aantal kleine caravans :";
            // 
            // nusmallcaravan
            // 
            this.nusmallcaravan.Location = new System.Drawing.Point(888, 239);
            this.nusmallcaravan.Name = "nusmallcaravan";
            this.nusmallcaravan.Size = new System.Drawing.Size(45, 20);
            this.nusmallcaravan.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Centaur", 15F);
            this.label1.Location = new System.Drawing.Point(611, 275);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 23);
            this.label1.TabIndex = 54;
            this.label1.Text = "selecteer het aantal grote tents :";
            // 
            // nubigtents
            // 
            this.nubigtents.Location = new System.Drawing.Point(888, 278);
            this.nubigtents.Name = "nubigtents";
            this.nubigtents.Size = new System.Drawing.Size(45, 20);
            this.nubigtents.TabIndex = 55;
            // 
            // lblelectricty
            // 
            this.lblelectricty.AutoSize = true;
            this.lblelectricty.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblelectricty.Location = new System.Drawing.Point(611, 81);
            this.lblelectricty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblelectricty.Name = "lblelectricty";
            this.lblelectricty.Size = new System.Drawing.Size(441, 23);
            this.lblelectricty.TabIndex = 56;
            this.lblelectricty.Text = "selecteer het aantal dagen dat je elektriciteit wilt gebruiken: ";
            // 
            // nuelectricty
            // 
            this.nuelectricty.Location = new System.Drawing.Point(1057, 82);
            this.nuelectricty.Name = "nuelectricty";
            this.nuelectricty.Size = new System.Drawing.Size(45, 20);
            this.nuelectricty.TabIndex = 57;
            // 
            // lblshower
            // 
            this.lblshower.AutoSize = true;
            this.lblshower.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblshower.Location = new System.Drawing.Point(611, 118);
            this.lblshower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblshower.Name = "lblshower";
            this.lblshower.Size = new System.Drawing.Size(389, 23);
            this.lblshower.TabIndex = 58;
            this.lblshower.Text = "selecteer het aantal douchemunten dat u nodig heeft:";
            // 
            // nushower
            // 
            this.nushower.Location = new System.Drawing.Point(1005, 118);
            this.nushower.Name = "nushower";
            this.nushower.Size = new System.Drawing.Size(45, 20);
            this.nushower.TabIndex = 59;
            // 
            // lblwash
            // 
            this.lblwash.AutoSize = true;
            this.lblwash.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblwash.Location = new System.Drawing.Point(611, 157);
            this.lblwash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblwash.Name = "lblwash";
            this.lblwash.Size = new System.Drawing.Size(373, 23);
            this.lblwash.TabIndex = 60;
            this.lblwash.Text = "selecteer het aantal wasmunten dat u nodig heeft : ";
            // 
            // nuwash
            // 
            this.nuwash.Location = new System.Drawing.Point(1005, 161);
            this.nuwash.Name = "nuwash";
            this.nuwash.Size = new System.Drawing.Size(45, 20);
            this.nuwash.TabIndex = 61;
            // 
            // lblpet
            // 
            this.lblpet.AutoSize = true;
            this.lblpet.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblpet.Location = new System.Drawing.Point(611, 339);
            this.lblpet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpet.Name = "lblpet";
            this.lblpet.Size = new System.Drawing.Size(284, 23);
            this.lblpet.TabIndex = 62;
            this.lblpet.Text = "neem je een huisdier mee (slechts 1) ? ";
            // 
            // chkNee
            // 
            this.chkNee.AutoSize = true;
            this.chkNee.Font = new System.Drawing.Font("Centaur", 15F);
            this.chkNee.Location = new System.Drawing.Point(1012, 339);
            this.chkNee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkNee.Name = "chkNee";
            this.chkNee.Size = new System.Drawing.Size(58, 27);
            this.chkNee.TabIndex = 64;
            this.chkNee.Text = "Nee";
            this.chkNee.UseVisualStyleBackColor = true;
            this.chkNee.CheckedChanged += new System.EventHandler(this.chkno_CheckedChanged);
            // 
            // chkJa
            // 
            this.chkJa.AutoSize = true;
            this.chkJa.Font = new System.Drawing.Font("Centaur", 15F);
            this.chkJa.Location = new System.Drawing.Point(910, 338);
            this.chkJa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkJa.Name = "chkJa";
            this.chkJa.Size = new System.Drawing.Size(43, 27);
            this.chkJa.TabIndex = 63;
            this.chkJa.Text = "Ja";
            this.chkJa.UseVisualStyleBackColor = true;
            this.chkJa.CheckedChanged += new System.EventHandler(this.chkemployee_CheckedChanged);
            // 
            // btninvoice
            // 
            this.btninvoice.BackColor = System.Drawing.Color.LightGray;
            this.btninvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btninvoice.Font = new System.Drawing.Font("Centaur", 15F);
            this.btninvoice.Location = new System.Drawing.Point(490, 383);
            this.btninvoice.Name = "btninvoice";
            this.btninvoice.Size = new System.Drawing.Size(136, 34);
            this.btninvoice.TabIndex = 65;
            this.btninvoice.Text = "Bevestigen";
            this.btninvoice.UseVisualStyleBackColor = false;
            this.btninvoice.Click += new System.EventHandler(this.btninvoice_Click);
            // 
            // lblsmalltent
            // 
            this.lblsmalltent.AutoSize = true;
            this.lblsmalltent.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblsmalltent.Location = new System.Drawing.Point(611, 309);
            this.lblsmalltent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsmalltent.Name = "lblsmalltent";
            this.lblsmalltent.Size = new System.Drawing.Size(240, 23);
            this.lblsmalltent.TabIndex = 66;
            this.lblsmalltent.Text = "selecteer het aantal kleine tents :";
            // 
            // nusmalltent
            // 
            this.nusmalltent.Location = new System.Drawing.Point(888, 312);
            this.nusmalltent.Name = "nusmalltent";
            this.nusmalltent.Size = new System.Drawing.Size(45, 20);
            this.nusmalltent.TabIndex = 67;
            // 
            // NieuweReservering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1126, 439);
            this.ControlBox = false;
            this.Controls.Add(this.nusmalltent);
            this.Controls.Add(this.lblsmalltent);
            this.Controls.Add(this.btninvoice);
            this.Controls.Add(this.chkNee);
            this.Controls.Add(this.chkJa);
            this.Controls.Add(this.lblpet);
            this.Controls.Add(this.nuwash);
            this.Controls.Add(this.lblwash);
            this.Controls.Add(this.nushower);
            this.Controls.Add(this.lblshower);
            this.Controls.Add(this.nuelectricty);
            this.Controls.Add(this.lblelectricty);
            this.Controls.Add(this.nubigtents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nusmallcaravan);
            this.Controls.Add(this.lblsmallcaravan);
            this.Controls.Add(this.nubigcaravan);
            this.Controls.Add(this.lblbigcaravan);
            this.Controls.Add(this.nuvisitors);
            this.Controls.Add(this.lblvisitors);
            this.Controls.Add(this.nucars);
            this.Controls.Add(this.lblcars);
            this.Controls.Add(this.nukids);
            this.Controls.Add(this.lblkids);
            this.Controls.Add(this.nuadults);
            this.Controls.Add(this.lbladults);
            this.Controls.Add(this.dtpend);
            this.Controls.Add(this.dtpstart);
            this.Controls.Add(this.lbldeparture);
            this.Controls.Add(this.lblarrival);
            this.Controls.Add(this.listplaces);
            this.Controls.Add(this.lblplace);
            this.Controls.Add(this.lblnamevalue);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblfill);
            this.Controls.Add(this.btnback);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NieuweReservering";
            this.Text = "Create_Reservation";
            this.Load += new System.EventHandler(this.Create_Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuadults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nukids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nucars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuvisitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubigcaravan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nusmallcaravan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubigtents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuelectricty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nushower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuwash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nusmalltent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblfill;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblnamevalue;
        private System.Windows.Forms.Label lblplace;
        private System.Windows.Forms.ComboBox listplaces;
        private System.Windows.Forms.Label lblarrival;
        private System.Windows.Forms.Label lbldeparture;
        private System.Windows.Forms.DateTimePicker dtpstart;
        private System.Windows.Forms.DateTimePicker dtpend;
        private System.Windows.Forms.Label lbladults;
        private System.Windows.Forms.NumericUpDown nuadults;
        private System.Windows.Forms.Label lblkids;
        private System.Windows.Forms.NumericUpDown nukids;
        private System.Windows.Forms.Label lblcars;
        private System.Windows.Forms.NumericUpDown nucars;
        private System.Windows.Forms.Label lblvisitors;
        private System.Windows.Forms.NumericUpDown nuvisitors;
        private System.Windows.Forms.Label lblbigcaravan;
        private System.Windows.Forms.NumericUpDown nubigcaravan;
        private System.Windows.Forms.Label lblsmallcaravan;
        private System.Windows.Forms.NumericUpDown nusmallcaravan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nubigtents;
        private System.Windows.Forms.Label lblelectricty;
        private System.Windows.Forms.NumericUpDown nuelectricty;
        private System.Windows.Forms.Label lblshower;
        private System.Windows.Forms.NumericUpDown nushower;
        private System.Windows.Forms.Label lblwash;
        private System.Windows.Forms.NumericUpDown nuwash;
        private System.Windows.Forms.Label lblpet;
        private System.Windows.Forms.CheckBox chkNee;
        private System.Windows.Forms.CheckBox chkJa;
        private System.Windows.Forms.Button btninvoice;
        private System.Windows.Forms.Label lblsmalltent;
        private System.Windows.Forms.NumericUpDown nusmalltent;
    }
}