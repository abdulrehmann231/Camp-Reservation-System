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
    public partial class VerwijderWerknemer : Form
    {
        Methods met = new Methods();
        DataTable dtuser = new DataTable();
        public VerwijderWerknemer()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ownerfeatures owner = new Ownerfeatures();
            owner.Show();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {//deze code krijgt alle werknemers 
            lblselect.Text = "Select employee";
            dtuser = met.viewemployess() ;
            userdata.DataSource = dtuser; 
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            if (lblselect.Text == "Select employee")
            {  //deze code krijgt alle eignaars
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
        public void test()
        {
            if (userdata.SelectedRows.Count == 0)
            {
                MessageBox.Show("Geen gegevens gevonden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
               
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {//deze code verwijdert de gebruiker door de respectieve methode aan te roepen

            if (userdata.RowCount <= 1)
            {
                MessageBox.Show("Minimaal een werknemer/eigenaar houden!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                DialogResult answer = MessageBox.Show("Are you sure", "attention", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    if (lblselect.Text == "Select owner")
                    {
                        string id = dtuser.Rows[userdata.CurrentRow.Index]["Owner_ID"].ToString();
                        int result = met.deleteowner(id);
                        if (result == 1)
                        {
                            MessageBox.Show("Owner deleted");
                            this.Hide();
                            Ownerfeatures owner = new Ownerfeatures();
                            owner.Show();
                        }
                        else
                        {
                            MessageBox.Show("Owner not deleted .... try again");

                            this.Hide();
                            Ownerfeatures owner = new Ownerfeatures();
                            owner.Show();
                        }
                    }
                    else
                    {
                        string id = dtuser.Rows[userdata.CurrentRow.Index]["employee_ID"].ToString();
                        int result = met.deleteemployee(id);
                        if (result == 1)
                        {
                            MessageBox.Show("employee deleted");
                            this.Hide();
                            Ownerfeatures owner = new Ownerfeatures();
                            owner.Show();
                        }
                        else
                        {
                            MessageBox.Show("employee not deleted .... try again");
                            this.Hide();
                            Ownerfeatures owner = new Ownerfeatures();
                            owner.Show();
                        }
                    }
                }

            }
        }

        private void lblhere_Click(object sender, EventArgs e)
        {

        }
    }
}
