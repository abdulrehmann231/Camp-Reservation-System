namespace CampingReservationSystem
{
    partial class ReserveringMaken
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lblfill.BackColor = System.Drawing.Color.Transparent;
            this.lblfill.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblfill.Location = new System.Drawing.Point(469, 1);
            this.lblfill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfill.Name = "lblfill";
            this.lblfill.Size = new System.Drawing.Size(178, 23);
            this.lblfill.TabIndex = 17;
            this.lblfill.Text = "Vul alle gegevens in ";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblname.Location = new System.Drawing.Point(100, 47);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(70, 23);
            this.lblname.TabIndex = 18;
            this.lblname.Text = "Naam :";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblnamevalue
            // 
            this.lblnamevalue.AutoSize = true;
            this.lblnamevalue.BackColor = System.Drawing.Color.Transparent;
            this.lblnamevalue.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamevalue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblnamevalue.Location = new System.Drawing.Point(206, 47);
            this.lblnamevalue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnamevalue.Name = "lblnamevalue";
            this.lblnamevalue.Size = new System.Drawing.Size(53, 23);
            this.lblnamevalue.TabIndex = 19;
            this.lblnamevalue.Text = "naam";
            this.lblnamevalue.Click += new System.EventHandler(this.lblnamevalue_Click);
            // 
            // lblplace
            // 
            this.lblplace.AutoSize = true;
            this.lblplace.BackColor = System.Drawing.Color.Transparent;
            this.lblplace.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblplace.Location = new System.Drawing.Point(23, 83);
            this.lblplace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblplace.Name = "lblplace";
            this.lblplace.Size = new System.Drawing.Size(350, 23);
            this.lblplace.TabIndex = 20;
            this.lblplace.Text = "*Selecteer een plaats voor uw reservering: ";
            // 
            // listplaces
            // 
            this.listplaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listplaces.FormattingEnabled = true;
            this.listplaces.Location = new System.Drawing.Point(473, 94);
            this.listplaces.Name = "listplaces";
            this.listplaces.Size = new System.Drawing.Size(121, 21);
            this.listplaces.TabIndex = 22;
            // 
            // lblarrival
            // 
            this.lblarrival.AutoSize = true;
            this.lblarrival.BackColor = System.Drawing.Color.Transparent;
            this.lblarrival.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarrival.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblarrival.Location = new System.Drawing.Point(23, 126);
            this.lblarrival.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblarrival.Name = "lblarrival";
            this.lblarrival.Size = new System.Drawing.Size(155, 23);
            this.lblarrival.TabIndex = 23;
            this.lblarrival.Text = "*kies startdatum :";
            // 
            // lbldeparture
            // 
            this.lbldeparture.AutoSize = true;
            this.lbldeparture.BackColor = System.Drawing.Color.Transparent;
            this.lbldeparture.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeparture.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldeparture.Location = new System.Drawing.Point(23, 167);
            this.lbldeparture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldeparture.Name = "lbldeparture";
            this.lbldeparture.Size = new System.Drawing.Size(153, 23);
            this.lbldeparture.TabIndex = 24;
            this.lbldeparture.Text = "*kies einddatum: ";
            // 
            // dtpstart
            // 
            this.dtpstart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpstart.CustomFormat = "dd-MM-yyyy";
            this.dtpstart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpstart.Location = new System.Drawing.Point(395, 126);
            this.dtpstart.MinDate = new System.DateTime(2022, 11, 9, 0, 0, 0, 0);
            this.dtpstart.Name = "dtpstart";
            this.dtpstart.Size = new System.Drawing.Size(200, 20);
            this.dtpstart.TabIndex = 40;
            this.dtpstart.ValueChanged += new System.EventHandler(this.dtpstart_ValueChanged);
            // 
            // dtpend
            // 
            this.dtpend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpend.CustomFormat = "dd-MM-yyyy";
            this.dtpend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpend.Location = new System.Drawing.Point(395, 167);
            this.dtpend.MinDate = new System.DateTime(2022, 11, 9, 0, 0, 0, 0);
            this.dtpend.Name = "dtpend";
            this.dtpend.Size = new System.Drawing.Size(200, 20);
            this.dtpend.TabIndex = 41;
            // 
            // lbladults
            // 
            this.lbladults.AutoSize = true;
            this.lbladults.BackColor = System.Drawing.Color.Transparent;
            this.lbladults.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladults.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbladults.Location = new System.Drawing.Point(23, 226);
            this.lbladults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladults.Name = "lbladults";
            this.lbladults.Size = new System.Drawing.Size(453, 23);
            this.lbladults.TabIndex = 42;
            this.lbladults.Text = "*Selecteer het aantal volwassenen voor uw reservering: ";
            // 
            // nuadults
            // 
            this.nuadults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuadults.Location = new System.Drawing.Point(550, 230);
            this.nuadults.Name = "nuadults";
            this.nuadults.Size = new System.Drawing.Size(45, 20);
            this.nuadults.TabIndex = 43;
            // 
            // lblkids
            // 
            this.lblkids.AutoSize = true;
            this.lblkids.BackColor = System.Drawing.Color.Transparent;
            this.lblkids.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkids.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblkids.Location = new System.Drawing.Point(23, 254);
            this.lblkids.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblkids.Name = "lblkids";
            this.lblkids.Size = new System.Drawing.Size(536, 23);
            this.lblkids.TabIndex = 44;
            this.lblkids.Text = "selecteer het aantal kinderen (ouder dan 4) voor uw reservering: ";
            // 
            // nukids
            // 
            this.nukids.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nukids.Location = new System.Drawing.Point(550, 258);
            this.nukids.Name = "nukids";
            this.nukids.Size = new System.Drawing.Size(45, 20);
            this.nukids.TabIndex = 45;
            // 
            // lblcars
            // 
            this.lblcars.AutoSize = true;
            this.lblcars.BackColor = System.Drawing.Color.Transparent;
            this.lblcars.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcars.Location = new System.Drawing.Point(23, 279);
            this.lblcars.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcars.Name = "lblcars";
            this.lblcars.Size = new System.Drawing.Size(362, 23);
            this.lblcars.TabIndex = 46;
            this.lblcars.Text = "selecteer aantal auto\'s voor uw reservering: ";
            // 
            // nucars
            // 
            this.nucars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nucars.Location = new System.Drawing.Point(549, 283);
            this.nucars.Name = "nucars";
            this.nucars.Size = new System.Drawing.Size(45, 20);
            this.nucars.TabIndex = 47;
            // 
            // lblvisitors
            // 
            this.lblvisitors.AutoSize = true;
            this.lblvisitors.BackColor = System.Drawing.Color.Transparent;
            this.lblvisitors.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvisitors.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblvisitors.Location = new System.Drawing.Point(23, 308);
            this.lblvisitors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblvisitors.Name = "lblvisitors";
            this.lblvisitors.Size = new System.Drawing.Size(416, 23);
            this.lblvisitors.TabIndex = 48;
            this.lblvisitors.Text = "selecteer het aantal bezoekers voor uw reservering:";
            // 
            // nuvisitors
            // 
            this.nuvisitors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuvisitors.Location = new System.Drawing.Point(550, 312);
            this.nuvisitors.Name = "nuvisitors";
            this.nuvisitors.Size = new System.Drawing.Size(45, 20);
            this.nuvisitors.TabIndex = 49;
            // 
            // lblbigcaravan
            // 
            this.lblbigcaravan.AutoSize = true;
            this.lblbigcaravan.BackColor = System.Drawing.Color.Transparent;
            this.lblbigcaravan.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbigcaravan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblbigcaravan.Location = new System.Drawing.Point(611, 204);
            this.lblbigcaravan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbigcaravan.Name = "lblbigcaravan";
            this.lblbigcaravan.Size = new System.Drawing.Size(309, 23);
            this.lblbigcaravan.TabIndex = 50;
            this.lblbigcaravan.Text = "‡Selecteer het aantal grote caravans :";
            // 
            // nubigcaravan
            // 
            this.nubigcaravan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nubigcaravan.Location = new System.Drawing.Point(1057, 208);
            this.nubigcaravan.Name = "nubigcaravan";
            this.nubigcaravan.Size = new System.Drawing.Size(45, 20);
            this.nubigcaravan.TabIndex = 51;
            // 
            // lblsmallcaravan
            // 
            this.lblsmallcaravan.AutoSize = true;
            this.lblsmallcaravan.BackColor = System.Drawing.Color.Transparent;
            this.lblsmallcaravan.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsmallcaravan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsmallcaravan.Location = new System.Drawing.Point(611, 236);
            this.lblsmallcaravan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsmallcaravan.Name = "lblsmallcaravan";
            this.lblsmallcaravan.Size = new System.Drawing.Size(316, 23);
            this.lblsmallcaravan.TabIndex = 52;
            this.lblsmallcaravan.Text = "‡Selecteer het aantal kleine caravans :";
            // 
            // nusmallcaravan
            // 
            this.nusmallcaravan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nusmallcaravan.Location = new System.Drawing.Point(1057, 240);
            this.nusmallcaravan.Name = "nusmallcaravan";
            this.nusmallcaravan.Size = new System.Drawing.Size(45, 20);
            this.nusmallcaravan.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(611, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 23);
            this.label1.TabIndex = 54;
            this.label1.Text = "‡selecteer het aantal grote tents :";
            // 
            // nubigtents
            // 
            this.nubigtents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nubigtents.Location = new System.Drawing.Point(1057, 267);
            this.nubigtents.Name = "nubigtents";
            this.nubigtents.Size = new System.Drawing.Size(45, 20);
            this.nubigtents.TabIndex = 55;
            // 
            // lblelectricty
            // 
            this.lblelectricty.AutoSize = true;
            this.lblelectricty.BackColor = System.Drawing.Color.Transparent;
            this.lblelectricty.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblelectricty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblelectricty.Location = new System.Drawing.Point(611, 81);
            this.lblelectricty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblelectricty.Name = "lblelectricty";
            this.lblelectricty.Size = new System.Drawing.Size(505, 23);
            this.lblelectricty.TabIndex = 56;
            this.lblelectricty.Text = "selecteer het aantal dagen dat je elektriciteit wilt gebruiken: ";
            // 
            // nuelectricty
            // 
            this.nuelectricty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuelectricty.Location = new System.Drawing.Point(1057, 87);
            this.nuelectricty.Name = "nuelectricty";
            this.nuelectricty.Size = new System.Drawing.Size(45, 20);
            this.nuelectricty.TabIndex = 57;
            // 
            // lblshower
            // 
            this.lblshower.AutoSize = true;
            this.lblshower.BackColor = System.Drawing.Color.Transparent;
            this.lblshower.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshower.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblshower.Location = new System.Drawing.Point(611, 118);
            this.lblshower.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblshower.Name = "lblshower";
            this.lblshower.Size = new System.Drawing.Size(441, 23);
            this.lblshower.TabIndex = 58;
            this.lblshower.Text = "selecteer het aantal douchemunten dat u nodig heeft:";
            // 
            // nushower
            // 
            this.nushower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nushower.Location = new System.Drawing.Point(1057, 122);
            this.nushower.Name = "nushower";
            this.nushower.Size = new System.Drawing.Size(45, 20);
            this.nushower.TabIndex = 59;
            // 
            // lblwash
            // 
            this.lblwash.AutoSize = true;
            this.lblwash.BackColor = System.Drawing.Color.Transparent;
            this.lblwash.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwash.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblwash.Location = new System.Drawing.Point(611, 157);
            this.lblwash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblwash.Name = "lblwash";
            this.lblwash.Size = new System.Drawing.Size(424, 23);
            this.lblwash.TabIndex = 60;
            this.lblwash.Text = "selecteer het aantal wasmunten dat u nodig heeft : ";
            // 
            // nuwash
            // 
            this.nuwash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuwash.Location = new System.Drawing.Point(1057, 161);
            this.nuwash.Name = "nuwash";
            this.nuwash.Size = new System.Drawing.Size(45, 20);
            this.nuwash.TabIndex = 61;
            // 
            // lblpet
            // 
            this.lblpet.AutoSize = true;
            this.lblpet.BackColor = System.Drawing.Color.Transparent;
            this.lblpet.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblpet.Location = new System.Drawing.Point(611, 336);
            this.lblpet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpet.Name = "lblpet";
            this.lblpet.Size = new System.Drawing.Size(325, 23);
            this.lblpet.TabIndex = 62;
            this.lblpet.Text = "*Neem je een huisdier mee (Max. 1) ? ";
            // 
            // chkNee
            // 
            this.chkNee.AutoSize = true;
            this.chkNee.BackColor = System.Drawing.Color.Transparent;
            this.chkNee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkNee.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkNee.Location = new System.Drawing.Point(1044, 336);
            this.chkNee.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkNee.Name = "chkNee";
            this.chkNee.Size = new System.Drawing.Size(61, 27);
            this.chkNee.TabIndex = 64;
            this.chkNee.Text = "Nee";
            this.chkNee.UseVisualStyleBackColor = false;
            this.chkNee.CheckedChanged += new System.EventHandler(this.chkno_CheckedChanged);
            // 
            // chkJa
            // 
            this.chkJa.AutoSize = true;
            this.chkJa.BackColor = System.Drawing.Color.Transparent;
            this.chkJa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkJa.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkJa.Location = new System.Drawing.Point(989, 335);
            this.chkJa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chkJa.Name = "chkJa";
            this.chkJa.Size = new System.Drawing.Size(45, 27);
            this.chkJa.TabIndex = 63;
            this.chkJa.Text = "Ja";
            this.chkJa.UseVisualStyleBackColor = false;
            this.chkJa.CheckedChanged += new System.EventHandler(this.chkemployee_CheckedChanged);
            // 
            // btninvoice
            // 
            this.btninvoice.BackColor = System.Drawing.Color.LightGray;
            this.btninvoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btninvoice.Font = new System.Drawing.Font("Centaur", 15F);
            this.btninvoice.Location = new System.Drawing.Point(490, 374);
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
            this.lblsmalltent.BackColor = System.Drawing.Color.Transparent;
            this.lblsmalltent.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsmalltent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsmalltent.Location = new System.Drawing.Point(611, 292);
            this.lblsmalltent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsmalltent.Name = "lblsmalltent";
            this.lblsmalltent.Size = new System.Drawing.Size(286, 23);
            this.lblsmalltent.TabIndex = 66;
            this.lblsmalltent.Text = "‡Selecteer het aantal kleine tents :";
            // 
            // nusmalltent
            // 
            this.nusmalltent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nusmalltent.Location = new System.Drawing.Point(1057, 296);
            this.nusmalltent.Name = "nusmalltent";
            this.nusmalltent.Size = new System.Drawing.Size(45, 20);
            this.nusmalltent.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 23);
            this.label3.TabIndex = 69;
            this.label3.Text = "‡ = Selecteer op z\'n minst 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 70;
            this.label2.Text = "* = verplicht!";
            // 
            // ReserveringMaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::CampingReservationSystem.Properties.Resources.logo1;
            this.ClientSize = new System.Drawing.Size(1126, 457);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
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
            this.Name = "ReserveringMaken";
            this.Text = "Reservering maken";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}