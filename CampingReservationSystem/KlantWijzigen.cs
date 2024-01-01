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
    public partial class KlantWijzigen : Form
    {
        Methods met = new Methods();
        CustomerModel cu;
        public KlantWijzigen(CustomerModel customer)
        {
            cu = customer ;
            InitializeComponent();
        }

        private void editdetailscustomer_Load(object sender, EventArgs e)
        {
            txtname.Text = cu.name;
            txtsurname.Text = cu.surname;
            txtadress.Text = cu.address;
            txtphone.Text = cu.phonenumber;
            txtzipcode.Text = cu.zipcode;
            txtemail.Text = cu.email;
            
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            KlantGegevens cu = new KlantGegevens();
            cu.Show();
        }

        private void btnchange_Click(object sender, EventArgs e)
        { //deze code zal de klantgegevens bewerken door de respectieve methode aan te roepen
            cu.name = txtname.Text   ;
            cu.surname = txtsurname .Text ;
            cu.address = txtadress.Text  ;
            cu.phonenumber = txtphone .Text ;
            cu.zipcode = txtzipcode.Text  ;
            cu.email = txtemail.Text  ;
            
            int output = met.changecustomerdetails(cu);
            if (output == 1)
            {
                MessageBox.Show("Wijzigingen opgeslagen ");
                this.Hide();
                KlantWijzigSelectie edit = new KlantWijzigSelectie();
                edit.Show();
            }
            else
            {
                MessageBox.Show("breng alstublieft opnieuw wijzigingen aan ");
                this.Hide();
                KlantWijzigSelectie edit = new KlantWijzigSelectie();
                edit.Show();
            }
        }
    }
}
