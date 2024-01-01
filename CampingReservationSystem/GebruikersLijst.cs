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
    public partial class userlist : Form
    {
        Methods met = new Methods();
        DataTable dtusers = new DataTable();
        public userlist()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ownerfeatures owner = new Ownerfeatures();
            owner.Show(); 
        }

        private void userlist_Load(object sender, EventArgs e)
        {//dit zal alles krijgen employees 
            lbllist.Text = "Lijst van werknemers";
            dtusers = met.viewemployess();
            userdata.DataSource = dtusers;  
        }


        private void btnchange_Click(object sender, EventArgs e)
        {
            if (userdata.SelectedRows.Count == 0)
            {
                MessageBox.Show("Geen gegevens gevonden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (lbllist.Text == "Lijst van werknemers")
                {//dit zal alles krijgen owners
                    lbllist.Text = "Lijst van eigenaren";
                    dtusers = met.viewowners();
                    userdata.DataSource = dtusers;
                }
                else if (lbllist.Text == "Lijst van eigenaren")
                {//dit zal alles krijgen employees
                    lbllist.Text = "Lijst van werknemers";
                    dtusers = met.viewemployess();
                    userdata.DataSource = dtusers;
                }
            }
        }

        private void userdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
