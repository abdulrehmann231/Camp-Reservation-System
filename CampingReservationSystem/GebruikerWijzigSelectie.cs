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
    public partial class GebruikerWijzigSelectie : Form
    {
        Methods met = new Methods();
        DataTable dtuser = new DataTable();
        gebruikersmodel gebruiker = new gebruikersmodel(); 
        public GebruikerWijzigSelectie()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ownerfeatures owner = new Ownerfeatures();
            owner.Show();
        }

        private void Edituser_Load(object sender, EventArgs e)
        {//deze code krijgt alle werknemers 
            dtuser = met.viewemployess();
            userdata.DataSource = dtuser;
            lblselect.Text = "Selecteer werknemer"; 
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            if (lblselect.Text == "Selecteer werknemer")
            {//deze code krijgt alle eignaars
                lblselect.Text = "Selecteer eigenaar";
                dtuser = met.viewowners();
                userdata.DataSource = dtuser;
            }
            else if (lblselect.Text == "Selecteer eigenaar")
            {//deze code krijgt alle werknemers 
                lblselect.Text = "Selecteer werknemer";
                dtuser = met.viewemployess();
                userdata.DataSource = dtuser;
            }
        }




        private void btnselect_Click(object sender, EventArgs e)
        {
            if (userdata.SelectedRows.Count == 0)
            {
                MessageBox.Show("Geen gegevens gevonden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                if (lblselect.Text == "Selecteer eigenaar")
                {//deze code slaat de details van de geselecteerde eignaar op in objecten 
                    gebruikersmodel.type = "eigenaar";
                    gebruiker.id = dtuser.Rows[userdata.CurrentRow.Index]["eigenaar_ID"].ToString();
                    gebruiker.gebruikersnaam = dtuser.Rows[userdata.CurrentRow.Index]["eigenaar_naam"].ToString();
                    gebruiker.wachtwoord = dtuser.Rows[userdata.CurrentRow.Index]["eigenaar_wachtwoord"].ToString();
                    this.Hide();
                    GebruikerWijzigen edit = new GebruikerWijzigen(gebruiker);
                    edit.Show();
                }
                else
                {//deze code slaat de details van de geselecteerde werknemer op in objecten 
                    gebruikersmodel.type = "werknemer";
                    gebruiker.id = dtuser.Rows[userdata.CurrentRow.Index]["werknemer_ID"].ToString();
                    gebruiker.gebruikersnaam = dtuser.Rows[userdata.CurrentRow.Index]["werknemer_naam"].ToString();
                    gebruiker.wachtwoord = dtuser.Rows[userdata.CurrentRow.Index]["werknemer_wachtwoord"].ToString();
                    this.Hide();
                    GebruikerWijzigen edit = new GebruikerWijzigen(gebruiker);
                    edit.Show();
                }

            }
        }

        private void lblenter_Click(object sender, EventArgs e)
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

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
