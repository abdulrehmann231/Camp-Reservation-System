namespace CampingReservationSystem
{
    partial class Home
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
            this.btnmake = new System.Windows.Forms.Button();
            this.btncustomers = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnchange = new System.Windows.Forms.Button();
            this.btnplaces = new System.Windows.Forms.Button();
            this.btnowner = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Maroon;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnback.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnback.Location = new System.Drawing.Point(10, 8);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(85, 70);
            this.btnback.TabIndex = 6;
            this.btnback.Text = "Loguit";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnmake
            // 
            this.btnmake.BackColor = System.Drawing.Color.LightGray;
            this.btnmake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmake.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmake.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnmake.Location = new System.Drawing.Point(117, 358);
            this.btnmake.Name = "btnmake";
            this.btnmake.Size = new System.Drawing.Size(110, 55);
            this.btnmake.TabIndex = 0;
            this.btnmake.Text = "Nieuwe reservering";
            this.btnmake.UseVisualStyleBackColor = false;
            this.btnmake.Click += new System.EventHandler(this.btnmake_Click);
            // 
            // btncustomers
            // 
            this.btncustomers.BackColor = System.Drawing.Color.LightGray;
            this.btncustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncustomers.Font = new System.Drawing.Font("Centaur", 15F);
            this.btncustomers.Location = new System.Drawing.Point(243, 419);
            this.btncustomers.Name = "btncustomers";
            this.btncustomers.Size = new System.Drawing.Size(110, 58);
            this.btncustomers.TabIndex = 5;
            this.btncustomers.Text = "Klanten gegevens";
            this.btncustomers.UseVisualStyleBackColor = false;
            this.btncustomers.Click += new System.EventHandler(this.btncustomers_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.LightGray;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Centaur", 15F);
            this.btndelete.Location = new System.Drawing.Point(243, 358);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(110, 55);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "Reservering verwijderen";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnchange
            // 
            this.btnchange.BackColor = System.Drawing.Color.LightGray;
            this.btnchange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnchange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnchange.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnchange.Location = new System.Drawing.Point(373, 358);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(110, 55);
            this.btnchange.TabIndex = 2;
            this.btnchange.Text = "Reservering wijzigen";
            this.btnchange.UseVisualStyleBackColor = false;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // btnplaces
            // 
            this.btnplaces.BackColor = System.Drawing.Color.LightGray;
            this.btnplaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnplaces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnplaces.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnplaces.Location = new System.Drawing.Point(117, 419);
            this.btnplaces.Name = "btnplaces";
            this.btnplaces.Size = new System.Drawing.Size(110, 55);
            this.btnplaces.TabIndex = 3;
            this.btnplaces.Text = "Beschikbaar-heid";
            this.btnplaces.UseVisualStyleBackColor = false;
            this.btnplaces.Click += new System.EventHandler(this.btnplaces_Click);
            // 
            // btnowner
            // 
            this.btnowner.BackColor = System.Drawing.Color.LightGray;
            this.btnowner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnowner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnowner.Font = new System.Drawing.Font("Centaur", 15F);
            this.btnowner.Location = new System.Drawing.Point(373, 419);
            this.btnowner.Name = "btnowner";
            this.btnowner.Size = new System.Drawing.Size(110, 55);
            this.btnowner.TabIndex = 4;
            this.btnowner.Text = "Eigenaar";
            this.btnowner.UseVisualStyleBackColor = false;
            this.btnowner.Click += new System.EventHandler(this.btnowner_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox1.Image = global::CampingReservationSystem.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(109, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 354);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(601, 479);
            this.ControlBox = false;
            this.Controls.Add(this.btnowner);
            this.Controls.Add(this.btnplaces);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btncustomers);
            this.Controls.Add(this.btnmake);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnmake;
        private System.Windows.Forms.Button btncustomers;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.Button btnplaces;
        private System.Windows.Forms.Button btnowner;
    }
}