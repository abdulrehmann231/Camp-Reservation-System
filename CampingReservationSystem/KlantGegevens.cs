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
    public partial class KlantGegevens : Form
    {
        Methods met = new Methods();
        int output = 0;
        CustomerModel customer = new CustomerModel();
        public KlantGegevens()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (KlantSelectie.fromklant == false)
            {
                this.Hide();
                Home home = new Home();
                home.ShowDialog();
            }  
            else if (KlantSelectie.fromklant == true  ){
                this.Hide();
                KlantSelectie kl = new KlantSelectie();
                kl.Show();
            }

            
        }

        private void btnsavecustomer_Click(object sender, EventArgs e)
        {//deze code slaat gegevens op in objecten en roept vervolgens de respectieve methoden aan
            customer.name = txtname.Text;
            customer.surname = txtsurname.Text;
            customer.address = txtadress.Text;
            customer.zipcode = txtzipcode.Text;
            customer.phonenumber = txtphone.Text;
            customer.email = txtemail.Text;
            output = met.savecustomers(customer );
            if (output == 1)
            {
                MessageBox.Show("klant gered ");
                this.Hide();
                KlantGegevens cu = new KlantGegevens();
                cu.Show(); 
            }
            else
            {
                MessageBox.Show("klant niet opgeslagen voer gegevens opnieuw in ");
                this.Hide();
                KlantGegevens cu = new KlantGegevens();
                cu.Show();
            }
        }

        private void btnlist_Click(object sender, EventArgs e)
        {//deze code zal verschijnen customerlist form
            this.Hide();
            KlantLijst cu = new KlantLijst();
            cu.Show();
        }

        private void btneditcustomer_Click(object sender, EventArgs e)
        {//deze code zal verschijnen edit customer form
            this.Hide();
            KlantWijzigSelectie edit = new KlantWijzigSelectie();
            edit.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {//deze code zal verschijnen  delete custome form
            this.Hide();
            KlantVerwijderen delete = new KlantVerwijderen();
            delete.Show(); 
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
