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
    public partial class WerkerVoegen : Form
    {
        Methods met = new Methods();
        gebruikersmodel gebruiker = new gebruikersmodel();
        public WerkerVoegen()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {//deze code brengt u naar het overzichtsformulier eigenaar 
            this.Hide();
            Ownerfeatures owner = new Ownerfeatures();
            owner.Show(); 
        }

        private void btnadd_Click(object sender, EventArgs e)
        {//deze code controleert of een tekstvak leeg is 
            if((txtname.Text == null || txtpassword.Text == null ) ||(txtname.Text == null || txtpassword.Text != null ) || (txtname.Text != null || txtpassword.Text == null) || (chkWerknemer.Checked == false && chkEigenaar.Checked == false   ) )
            {
                MessageBox.Show("voer alle gegevens in"); 
            }
            else if (chkWerknemer.Checked == true  && chkEigenaar.Checked == true )
            {
                MessageBox.Show(" kies een ");
            }
            else if (chkEigenaar.Checked == true  )
            {//deze code slaat gegevens op in het gebruikersobject en roept de respectieve methode uit de klasse aan 
                gebruiker.gebruikersnaam = txtname.Text;
                gebruiker.wachtwoord = txtpassword.Text;
                int result = met.addowner(gebruiker);
                  if (result == 1)
                  {
                      MessageBox.Show("Eigenaar succesvol toegevoegd!");
                      this.Hide();
                      Ownerfeatures owner = new Ownerfeatures();
                      owner.Show();
                  }
                  else
                  {
                      MessageBox.Show("Eigenaar niet toegevoegd, probeer nogmaals");
                      this.Hide();
                      Ownerfeatures owner = new Ownerfeatures();
                      owner.Show();
                  }
            }
            else if (chkWerknemer.Checked == true  )
            {
                gebruiker.gebruikersnaam = txtname.Text;
                gebruiker.wachtwoord= txtpassword.Text;
                int result = met.addemployee(gebruiker);
                if (result == 1)
                {
                    MessageBox.Show("Werknemer succesvol toegevoegd!");
                    this.Hide();
                    Ownerfeatures owner = new Ownerfeatures();
                    owner.Show();
                }
                else
                {
                    MessageBox.Show("Werknemer niet toegevoegd, probeer nogmaals");
                    this.Hide();
                    Ownerfeatures owner = new Ownerfeatures();
                    owner.Show();
                }
            }
        }

        private void adduser_Load(object sender, EventArgs e)
        {

        }

        private void chkemployee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWerknemer.Checked)
            {
                chkEigenaar.Checked = false;
            }
        }

        private void chkowner_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEigenaar.Checked)
            {
                chkWerknemer.Checked = false;
            }
        }
    }
}
