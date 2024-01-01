using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampingReservationSystem
{
    public partial class GebruikerWijzigen : Form
    {
        Methods met = new Methods();
        gebruikersmodel gebruiker;
        public GebruikerWijzigen( gebruikersmodel test)
        {
            gebruiker = test;
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            GebruikerWijzigSelectie edit = new GebruikerWijzigSelectie();
            edit.Show();
        }

        private void Edituserdetails_Load(object sender, EventArgs e)
        {
            txtname.Text = gebruiker.gebruikersnaam;
            txtpassword.Text = gebruiker.wachtwoord;  
        }

        private void btnedit_Click(object sender, EventArgs e)
        {// this code will edit the detail of user 
            if (gebruikersmodel.type == "eigenaar")
            {
                gebruiker.gebruikersnaam = txtname.Text;
                gebruiker.wachtwoord = txtpassword.Text;
                int result = met.changownerdetails(gebruiker);
                if (result == 1)
                {
                    MessageBox.Show("Gegevens succesvol opgeslagen!");
                    this.Hide();
                    GebruikerWijzigSelectie owner = new GebruikerWijzigSelectie();
                    owner.Show();
                }
                else
                {
                    MessageBox.Show("Gegevens zijn niet opgeslagen, probeer opnieuw!");
                    this.Hide();
                    GebruikerWijzigSelectie owner = new GebruikerWijzigSelectie();
                    owner.Show();
                }
            }
            else if (gebruikersmodel.type == "werknemer")
            {
                gebruiker.gebruikersnaam = txtname.Text;
                gebruiker.wachtwoord = txtpassword.Text;
                int result = met.changemployeedetails (gebruiker);
                if (result == 1)
                {
                    MessageBox.Show("Gegevens succesvol opgeslagen!");
                    this.Hide();
                    GebruikerWijzigSelectie owner = new GebruikerWijzigSelectie();
                    owner.Show();
                }
                else
                {
                    MessageBox.Show("Gegevens niet opgeslagen, probeer opnieuw!");
                    this.Hide();
                    GebruikerWijzigSelectie owner = new GebruikerWijzigSelectie();
                    owner.Show();
                }
            }
        }
    }
}
