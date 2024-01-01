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
        usermodel user = new usermodel();
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
            if((txtname.Text == null || txtpassword.Text == null ) ||(chkemployee.Checked == false && chkowner.Checked == false   ) )
            {
                MessageBox.Show("voer alle gegevens in"); 
            }
            else if (chkemployee.Checked == true  && chkowner.Checked == true )
            {
                MessageBox.Show(" kies een ");
            }
            else if (chkowner.Checked == true  )
            {//deze code slaat gegevens op in het gebruikersobject en roept de respectieve methode uit de klasse aan 
                user.username = txtname.Text;
                user.password = txtpassword.Text;
                int result = met.addowner(user );
                  if (result == 1)
                  {
                      MessageBox.Show("owner toegevoegd ");
                      this.Hide();
                      Ownerfeatures owner = new Ownerfeatures();
                      owner.Show();
                  }
                  else
                  {
                      MessageBox.Show("owner niet toegevoegd....probeer het opnieuw ");
                      this.Hide();
                      Ownerfeatures owner = new Ownerfeatures();
                      owner.Show();
                  }
            }
            else if (chkemployee.Checked == true  )
            {
                user.username = txtname.Text;
                user.password = txtpassword.Text;
                int result = met.addemployee(user);
                if (result == 1)
                {
                    MessageBox.Show("eigenaar toegevoegd ");
                    this.Hide();
                    Ownerfeatures owner = new Ownerfeatures();
                    owner.Show();
                }
                else
                {
                    MessageBox.Show("eigenaar niet toegevoegd....probeer het opnieuw ");
                    this.Hide();
                    Ownerfeatures owner = new Ownerfeatures();
                    owner.Show();
                }
            }
        }

        private void adduser_Load(object sender, EventArgs e)
        {

        }
    }
}
