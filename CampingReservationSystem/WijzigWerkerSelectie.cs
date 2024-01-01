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
    public partial class WijzigWerkerSelectie : Form
    {
        Methods met = new Methods();
        DataTable dtuser = new DataTable();
        usermodel user = new usermodel(); 
        public WijzigWerkerSelectie()
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
            lblselect.Text = "Select employee"; 
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            if (lblselect.Text == "Select employee")
            {//deze code krijgt alle eignaars
                lblselect.Text = "Select owner";
                dtuser = met.viewowners();
                userdata.DataSource = dtuser;
            }
            else if (lblselect.Text == "Select owner")
            {//deze code krijgt alle werknemers 
                lblselect.Text = "Select employee";
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

                if (lblselect.Text == "Select owner")
                {//deze code slaat de details van de geselecteerde eignaar op in objecten 
                    usermodel.type = "owner";
                    user.id = dtuser.Rows[userdata.CurrentRow.Index]["Owner_ID"].ToString();
                    user.username = dtuser.Rows[userdata.CurrentRow.Index]["Owner_name"].ToString();
                    user.password = dtuser.Rows[userdata.CurrentRow.Index]["Owner_password"].ToString();
                    this.Hide();
                    WijzigWerker edit = new WijzigWerker(user);
                    edit.Show();
                }
                else
                {//deze code slaat de details van de geselecteerde werknemer op in objecten 
                    usermodel.type = "employee";
                    user.id = dtuser.Rows[userdata.CurrentRow.Index]["employee_ID"].ToString();
                    user.username = dtuser.Rows[userdata.CurrentRow.Index]["employee_name"].ToString();
                    user.password = dtuser.Rows[userdata.CurrentRow.Index]["employee_password"].ToString();
                    this.Hide();
                    WijzigWerker edit = new WijzigWerker(user);
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
