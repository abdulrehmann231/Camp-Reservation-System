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
    public partial class login : Form
    {
        string message;
        gebruikersmodel gebruiker = new gebruikersmodel();
        Methods met = new Methods();
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                    }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // this will exit application from background as well
            Application.Exit(); 

        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            //deze voorwaarden controleren of een tekstvak leeg is
            if (txtname.Text == "" || txtpassword.Text == "" || (chkWerknemer.Checked == false && chkEigenaar.Checked == false))
            {
                MessageBox.Show("voer alle details in ");
            }
            if (chkWerknemer.Checked == true && chkEigenaar.Checked == true)
            {
                MessageBox.Show("Selecteer er maar één");
            }
            else if (chkWerknemer.Checked == true  )
            {
                gebruiker.gebruikersnaam = txtname.Text;
                gebruiker.wachtwoord = txtpassword.Text;
                gebruikersmodel.type = "werknemer";
                message = met.checkemployee(gebruiker);
                MessageBox.Show(message);
                if (message == " Succesvol ingelogd ")
                {
                    met.recordlogin (gebruiker);
                    this.Hide();
                    Home home = new Home();
                    home.Show();
                }
            }
            else if (chkEigenaar.Checked == true  )
            {
                gebruiker.gebruikersnaam = txtname.Text;
                gebruiker.wachtwoord = txtpassword.Text;
                gebruikersmodel.type = "eigenaar";
                message = met.checkowner(gebruiker);
                MessageBox.Show(message );
                if (message == " Succesvol ingelogd ")
                {
                    met.recordlogin(gebruiker);
                    this.Hide();
                    Home home = new Home( );
                    home.Show();
                }
            }

        }

        private void chkowner_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEigenaar.Checked)
            {
                chkWerknemer.Checked = false;
            }
        }

        private void chkemployee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWerknemer.Checked)
            {
                chkEigenaar.Checked = false;
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
