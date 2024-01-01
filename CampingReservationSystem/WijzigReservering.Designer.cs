namespace CampingReservationSystem
{
    partial class WijzigReservering
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
            this.lblidvalue = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblfill = new System.Windows.Forms.Label();
            this.dtpend = new System.Windows.Forms.DateTimePicker();
            this.dtpstart = new System.Windows.Forms.DateTimePicker();
            this.listplaces = new System.Windows.Forms.ComboBox();
            this.lblplace = new System.Windows.Forms.Label();
            this.lblstart = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.nusmalltent = new System.Windows.Forms.NumericUpDown();
            this.lblsmalltent = new System.Windows.Forms.Label();
            this.chkno = new System.Windows.Forms.CheckBox();
            this.chkyes = new System.Windows.Forms.CheckBox();
            this.lblpet = new System.Windows.Forms.Label();
            this.nuwash = new System.Windows.Forms.NumericUpDown();
            this.lblwash = new System.Windows.Forms.Label();
            this.nushower = new System.Windows.Forms.NumericUpDown();
            this.lblshower = new System.Windows.Forms.Label();
            this.nuelectricty = new System.Windows.Forms.NumericUpDown();
            this.lblelectricty = new System.Windows.Forms.Label();
            this.nubigtents = new System.Windows.Forms.NumericUpDown();
            this.lblbigtents = new System.Windows.Forms.Label();
            this.nusmallcaravan = new System.Windows.Forms.NumericUpDown();
            this.lblsmallcaravan = new System.Windows.Forms.Label();
            this.nubigcaravan = new System.Windows.Forms.NumericUpDown();
            this.lblbigcaravan = new System.Windows.Forms.Label();
            this.nuvisitors = new System.Windows.Forms.NumericUpDown();
            this.lblvisitors = new System.Windows.Forms.Label();
            this.nucars = new System.Windows.Forms.NumericUpDown();
            this.nukids = new System.Windows.Forms.NumericUpDown();
            this.lblkids = new System.Windows.Forms.Label();
            this.nuadults = new System.Windows.Forms.NumericUpDown();
            this.lbladults = new System.Windows.Forms.Label();
            this.lblcars = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nusmalltent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuwash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nushower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuelectricty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubigtents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nusmallcaravan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubigcaravan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuvisitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nucars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nukids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuadults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(-1, -2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(78, 29);
            this.btnback.TabIndex = 15;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lblidvalue
            // 
            this.lblidvalue.AutoSize = true;
            this.lblidvalue.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblidvalue.Location = new System.Drawing.Point(546, 43);
            this.lblidvalue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblidvalue.Name = "lblidvalue";
            this.lblidvalue.Size = new System.Drawing.Size(30, 23);
            this.lblidvalue.TabIndex = 76;
            this.lblidvalue.Text = "ID";
            this.lblidvalue.Click += new System.EventHandler(this.lblidvalue_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblid.Location = new System.Drawing.Point(335, 43);
            this.lblid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(177, 23);
            this.lblid.TabIndex = 75;
            this.lblid.Text = "RESERVATION ID :";
            // 
            // lblfill
            // 
            this.lblfill.AutoSize = true;
            this.lblfill.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblfill.Location = new System.Drawing.Point(373, 4);
            this.lblfill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfill.Name = "lblfill";
            this.lblfill.Size = new System.Drawing.Size(149, 23);
            this.lblfill.TabIndex = 77;
            this.lblfill.Text = "Vul de gegevens in ";
            // 
            // dtpend
            // 
            this.dtpend.CustomFormat = "dd-MM-yyyy";
            this.dtpend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpend.Location = new System.Drawing.Point(271, 237);
            this.dtpend.MinDate = new System.DateTime(2022, 11, 9, 0, 0, 0, 0);
            this.dtpend.Name = "dtpend";
            this.dtpend.Size = new System.Drawing.Size(200, 20);
            this.dtpend.TabIndex = 81;
            // 
            // dtpstart
            // 
            this.dtpstart.CustomFormat = "dd-MM-yyyy";
            this.dtpstart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpstart.Location = new System.Drawing.Point(271, 171);
            this.dtpstart.MinDate = new System.DateTime(2022, 11, 9, 0, 0, 0, 0);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(200, 20);
            this.dtpstart.TabIndex = 80;
            this.dtpstart.ValueChanged += new System.EventHandler(this.dtpstart_ValueChanged);
            // 
            // listplaces
            // 
            this.listplaces.FormattingEnabled = true;
            this.listplaces.Location = new System.Drawing.Point(350, 106);
            this.listplaces.Name = "listplaces";
            this.listplaces.Size = new System.Drawing.Size(121, 21);
            this.listplaces.TabIndex = 79;
            // 
            // lblplace
            // 
            this.lblplace.AutoSize = true;
            this.lblplace.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblplace.Location = new System.Drawing.Point(26, 103);
            this.lblplace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblplace.Name = "lblplace";
            this.lblplace.Size = new System.Drawing.Size(293, 23);
            this.lblplace.TabIndex = 78;
            this.lblplace.Text = " Selecteer een nieuwe reserveringsplaats ";
            // 
            // lblstart
            // 
            this.lblstart.AutoSize = true;
            this.lblstart.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblstart.Location = new System.Drawing.Point(26, 170);
            this.lblstart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(215, 23);
            this.lblstart.TabIndex = 82;
            this.lblstart.Text = "Selecteer nieuwe startdatum ";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblend.Location = new System.Drawing.Point(26, 237);
            this.lblend.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(214, 23);
            this.lblend.TabIndex = 83;
            this.lblend.Text = "Selecteer nieuwe einddatum ";
            // 
            // btnconfirm
            // 
            this.btnconfirm.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnconfirm.Location = new System.Drawing.Point(408, 476);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(114, 29);
            this.btnconfirm.TabIndex = 84;
            this.btnconfirm.Text = "CONFIRM";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // nusmalltent
            // 
            this.nusmalltent.Location = new System.Drawing.Point(920, 366);
            this.nusmalltent.Name = "nusmalltent";
            this.nusmalltent.Size = new System.Drawing.Size(45, 20);
            this.nusmalltent.TabIndex = 101;
            // 
            // lblsmalltent
            // 
            this.lblsmalltent.AutoSize = true;
            this.lblsmalltent.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblsmalltent.Location = new System.Drawing.Point(572, 366);
            this.lblsmalltent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsmalltent.Name = "lblsmalltent";
            this.lblsmalltent.Size = new System.Drawing.Size(307, 23);
            this.lblsmalltent.TabIndex = 100;
            this.lblsmalltent.Text = "Selecteer het nieuwe aantal kleine tenten: ";
            // 
            // chkno
            // 
            this.chkno.AutoSize = true;
            this.chkno.Font = new System.Drawing.Font("Centaur", 15F);
            this.chkno.Location = new System.Drawing.Point(978, 407);
            this.chkno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkno.Name = "chkno";
            this.chkno.Size = new System.Drawing.Size(59, 27);
            this.chkno.TabIndex = 99;
            this.chkno.Text = "NO";
            this.chkno.UseVisualStyleBackColor = true;
            // 
            // chkyes
            // 
            this.chkyes.AutoSize = true;
            this.chkyes.Font = new System.Drawing.Font("Centaur", 15F);
            this.chkyes.Location = new System.Drawing.Point(874, 404);
            this.chkyes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkyes.Name = "chkyes";
            this.chkyes.Size = new System.Drawing.Size(62, 27);
            this.chkyes.TabIndex = 98;
            this.chkyes.Text = "YES";
            this.chkyes.UseVisualStyleBackColor = true;
            // 
            // lblpet
            // 
            this.lblpet.AutoSize = true;
            this.lblpet.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblpet.Location = new System.Drawing.Point(572, 404);
            this.lblpet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpet.Name = "lblpet";
            this.lblpet.Size = new System.Drawing.Size(284, 23);
            this.lblpet.TabIndex = 97;
            this.lblpet.Text = "neem je een huisdier mee (slechts 1) ? ";
            // 
            // nuwash
            // 
            this.nuwash.Location = new System.Drawing.Point(920, 199);
            this.nuwash.Name = "nuwash";
            this.nuwash.Size = new System.Drawing.Size(45, 20);
            this.nuwash.TabIndex = 96;
            // 
            // lblwash
            // 
            this.lblwash.AutoSize = true;
            this.lblwash.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblwash.Location = new System.Drawing.Point(572, 199);
            this.lblwash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblwash.Name = "lblwash";
            this.lblwash.Size = new System.Drawing.Size(296, 23);
            this.lblwash.TabIndex = 95;
            this.lblwash.Text = "Selecteer het nieuwe aantal wasmunten: ";
            // 
            // nushower
            // 
            this.nushower.Location = new System.Drawing.Point(920, 153);
            this.nushower.Name = "nushower";
            this.nushower.Size = new System.Drawing.Size(45, 20);
            this.nushower.TabIndex = 94;
            // 
            // lblshower
            // 
            this.lblshower.AutoSize = true;
            this.lblshower.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblshower.Location = new System.Drawing.Point(572, 153);
            this.lblshower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblshower.Name = "lblshower";
            this.lblshower.Size = new System.Drawing.Size(322, 23);
            this.lblshower.TabIndex = 93;
            this.lblshower.Text = "Selecteer het nieuwe aantal douchemunten: ";
            // 
            // nuelectricty
            // 
            this.nuelectricty.Location = new System.Drawing.Point(966, 103);
            this.nuelectricty.Name = "nuelectricty";
            this.nuelectricty.Size = new System.Drawing.Size(45, 20);
            this.nuelectricty.TabIndex = 92;
            // 
            // lblelectricty
            // 
            this.lblelectricty.AutoSize = true;
            this.lblelectricty.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblelectricty.Location = new System.Drawing.Point(572, 103);
            this.lblelectricty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblelectricty.Name = "lblelectricty";
            this.lblelectricty.Size = new System.Drawing.Size(393, 23);
            this.lblelectricty.TabIndex = 91;
            this.lblelectricty.Text = "Kies het nieuwe aantal dagen dat je elektriciteit wilt: ";
            // 
            // nubigtents
            // 
            this.nubigtents.Location = new System.Drawing.Point(920, 331);
            this.nubigtents.Name = "nubigtents";
            this.nubigtents.Size = new System.Drawing.Size(45, 20);
            this.nubigtents.TabIndex = 90;
            // 
            // lblbigtents
            // 
            this.lblbigtents.AutoSize = true;
            this.lblbigtents.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblbigtents.Location = new System.Drawing.Point(572, 330);
            this.lblbigtents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbigtents.Name = "lblbigtents";
            this.lblbigtents.Size = new System.Drawing.Size(301, 23);
            this.lblbigtents.TabIndex = 89;
            this.lblbigtents.Text = "Selecteer het nieuwe aantal grote tenten: ";
            // 
            // nusmallcaravan
            // 
            this.nusmallcaravan.Location = new System.Drawing.Point(920, 287);
            this.nusmallcaravan.Name = "nusmallcaravan";
            this.nusmallcaravan.Size = new System.Drawing.Size(45, 20);
            this.nusmallcaravan.TabIndex = 88;
            // 
            // lblsmallcaravan
            // 
            this.lblsmallcaravan.AutoSize = true;
            this.lblsmallcaravan.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblsmallcaravan.Location = new System.Drawing.Point(572, 288);
            this.lblsmallcaravan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsmallcaravan.Name = "lblsmallcaravan";
            this.lblsmallcaravan.Size = new System.Drawing.Size(334, 23);
            this.lblsmallcaravan.TabIndex = 87;
            this.lblsmallcaravan.Text = "Selecteer het nieuwe aantal kleine  caravans : ";
            // 
            // nubigcaravan
            // 
            this.nubigcaravan.Location = new System.Drawing.Point(920, 246);
            this.nubigcaravan.Name = "nubigcaravan";
            this.nubigcaravan.Size = new System.Drawing.Size(45, 20);
            this.nubigcaravan.TabIndex = 86;
            // 
            // lblbigcaravan
            // 
            this.lblbigcaravan.AutoSize = true;
            this.lblbigcaravan.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblbigcaravan.Location = new System.Drawing.Point(572, 246);
            this.lblbigcaravan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbigcaravan.Name = "lblbigcaravan";
            this.lblbigcaravan.Size = new System.Drawing.Size(323, 23);
            this.lblbigcaravan.TabIndex = 85;
            this.lblbigcaravan.Text = "Selecteer het nieuwe aantal grote caravans : ";
            // 
            // nuvisitors
            // 
            this.nuvisitors.Location = new System.Drawing.Point(369, 407);
            this.nuvisitors.Name = "nuvisitors";
            this.nuvisitors.Size = new System.Drawing.Size(45, 20);
            this.nuvisitors.TabIndex = 108;
            // 
            // lblvisitors
            // 
            this.lblvisitors.AutoSize = true;
            this.lblvisitors.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblvisitors.Location = new System.Drawing.Point(26, 403);
            this.lblvisitors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvisitors.Name = "lblvisitors";
            this.lblvisitors.Size = new System.Drawing.Size(284, 23);
            this.lblvisitors.TabIndex = 107;
            this.lblvisitors.Text = "Selecteer het nieuwe aantal bezoekers: ";
            // 
            // nucars
            // 
            this.nucars.Location = new System.Drawing.Point(369, 370);
            this.nucars.Name = "nucars";
            this.nucars.Size = new System.Drawing.Size(45, 20);
            this.nucars.TabIndex = 106;
            // 
            // nukids
            // 
            this.nukids.Location = new System.Drawing.Point(420, 330);
            this.nukids.Name = "nukids";
            this.nukids.Size = new System.Drawing.Size(45, 20);
            this.nukids.TabIndex = 105;
            // 
            // lblkids
            // 
            this.lblkids.AutoSize = true;
            this.lblkids.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblkids.Location = new System.Drawing.Point(26, 327);
            this.lblkids.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblkids.Name = "lblkids";
            this.lblkids.Size = new System.Drawing.Size(378, 23);
            this.lblkids.TabIndex = 104;
            this.lblkids.Text = "Selecteer het nieuwe aantal kinderen (meer dan 4): ";
            // 
            // nuadults
            // 
            this.nuadults.Location = new System.Drawing.Point(420, 291);
            this.nuadults.Name = "nuadults";
            this.nuadults.Size = new System.Drawing.Size(45, 20);
            this.nuadults.TabIndex = 103;
            // 
            // lbladults
            // 
            this.lbladults.AutoSize = true;
            this.lbladults.Font = new System.Drawing.Font("Centaur", 15F);
            this.lbladults.Location = new System.Drawing.Point(26, 287);
            this.lbladults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladults.Name = "lbladults";
            this.lbladults.Size = new System.Drawing.Size(307, 23);
            this.lbladults.TabIndex = 102;
            this.lbladults.Text = "Selecteer het nieuwe aantal volwassenen : ";
            // 
            // lblcars
            // 
            this.lblcars.AutoSize = true;
            this.lblcars.Font = new System.Drawing.Font("Centaur", 15F);
            this.lblcars.Location = new System.Drawing.Point(26, 367);
            this.lblcars.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcars.Name = "lblcars";
            this.lblcars.Size = new System.Drawing.Size(258, 23);
            this.lblcars.TabIndex = 109;
            this.lblcars.Text = "Selecteer het nieuwe aantal auto\'s: ";
            this.lblcars.Click += new System.EventHandler(this.lblcars_Click);
            // 
            // ChangeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(1066, 517);
            this.ControlBox = false;
            this.Controls.Add(this.lblcars);
            this.Controls.Add(this.nuvisitors);
            this.Controls.Add(this.lblvisitors);
            this.Controls.Add(this.nucars);
            this.Controls.Add(this.nukids);
            this.Controls.Add(this.lblkids);
            this.Controls.Add(this.nuadults);
            this.Controls.Add(this.lbladults);
            this.Controls.Add(this.nusmalltent);
            this.Controls.Add(this.lblsmalltent);
            this.Controls.Add(this.chkno);
            this.Controls.Add(this.chkyes);
            this.Controls.Add(this.lblpet);
            this.Controls.Add(this.nuwash);
            this.Controls.Add(this.lblwash);
            this.Controls.Add(this.nushower);
            this.Controls.Add(this.lblshower);
            this.Controls.Add(this.nuelectricty);
            this.Controls.Add(this.lblelectricty);
            this.Controls.Add(this.nubigtents);
            this.Controls.Add(this.lblbigtents);
            this.Controls.Add(this.nusmallcaravan);
            this.Controls.Add(this.lblsmallcaravan);
            this.Controls.Add(this.nubigcaravan);
            this.Controls.Add(this.lblbigcaravan);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.lblstart);
            this.Controls.Add(this.dtpend);
            this.Controls.Add(this.dtpstart);
            this.Controls.Add(this.listplaces);
            this.Controls.Add(this.lblplace);
            this.Controls.Add(this.lblfill);
            this.Controls.Add(this.lblidvalue);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnback);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeReservation";
            this.Text = "ChangeReservation";
            this.Load += new System.EventHandler(this.ChangeReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nusmalltent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuwash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nushower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuelectricty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubigtents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nusmallcaravan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubigcaravan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuvisitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nucars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nukids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuadults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblidvalue;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblfill;
        private System.Windows.Forms.DateTimePicker dtpend;
        private System.Windows.Forms.DateTimePicker dtpstart;
        private System.Windows.Forms.ComboBox listplaces;
        private System.Windows.Forms.Label lblplace;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.NumericUpDown nusmalltent;
        private System.Windows.Forms.Label lblsmalltent;
        private System.Windows.Forms.CheckBox chkno;
        private System.Windows.Forms.CheckBox chkyes;
        private System.Windows.Forms.Label lblpet;
        private System.Windows.Forms.NumericUpDown nuwash;
        private System.Windows.Forms.Label lblwash;
        private System.Windows.Forms.NumericUpDown nushower;
        private System.Windows.Forms.Label lblshower;
        private System.Windows.Forms.NumericUpDown nuelectricty;
        private System.Windows.Forms.Label lblelectricty;
        private System.Windows.Forms.NumericUpDown nubigtents;
        private System.Windows.Forms.Label lblbigtents;
        private System.Windows.Forms.NumericUpDown nusmallcaravan;
        private System.Windows.Forms.Label lblsmallcaravan;
        private System.Windows.Forms.NumericUpDown nubigcaravan;
        private System.Windows.Forms.Label lblbigcaravan;
        private System.Windows.Forms.NumericUpDown nuvisitors;
        private System.Windows.Forms.Label lblvisitors;
        private System.Windows.Forms.NumericUpDown nucars;
        private System.Windows.Forms.NumericUpDown nukids;
        private System.Windows.Forms.Label lblkids;
        private System.Windows.Forms.NumericUpDown nuadults;
        private System.Windows.Forms.Label lbladults;
        private System.Windows.Forms.Label lblcars;
    }
}