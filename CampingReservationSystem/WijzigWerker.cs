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
    public partial class WijzigWerker : Form
    {
        Methods met = new Methods();
        usermodel user;
        public WijzigWerker( usermodel test)
        {
            user = test;
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            WijzigWerkerSelectie edit = new WijzigWerkerSelectie();
            edit.Show();
        }

        private void Edituserdetails_Load(object sender, EventArgs e)
        {
            txtname.Text = user.username;
            txtpassword.Text = user.password;  
        }

        private void btnedit_Click(object sender, EventArgs e)
        {// this code will edit the detail of user 
            if (usermodel.type == "owner")
            {
                user.username = txtname.Text;
                user.password = txtpassword.Text;
                int result = met.changownerdetails(user );
                if (result == 1)
                {
                    MessageBox.Show("Owner edited");
                    this.Hide();
                    WijzigWerkerSelectie owner = new WijzigWerkerSelectie();
                    owner.Show();
                }
                else
                {
                    MessageBox.Show("Owner not edited");
                    this.Hide();
                    WijzigWerkerSelectie owner = new WijzigWerkerSelectie();
                    owner.Show();
                }
            }
            else if (usermodel.type == "employee")
            {
                user.username = txtname.Text;
                user.password = txtpassword.Text;
                int result = met.changemployeedetails (user);
                if (result == 1)
                {
                    MessageBox.Show("Employee edited");
                    this.Hide();
                    WijzigWerkerSelectie owner = new WijzigWerkerSelectie();
                    owner.Show();
                }
                else
                {
                    MessageBox.Show("Employee not edited");
                    this.Hide();
                    WijzigWerkerSelectie owner = new WijzigWerkerSelectie();
                    owner.Show();
                }
            }
        }
    }
}
