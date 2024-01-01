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
    public partial class Home : Form
    {
        
        public Home()
        {
            ;
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {//deze code zal creëren login form
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void btncustomers_Click(object sender, EventArgs e)
        {//deze code zal creëren customer details form
            KlantSelectie.fromklant = false; 
            this.Hide();
            KlantGegevens klant = new KlantGegevens();
            klant.ShowDialog();
        }

        private void btnowner_Click(object sender, EventArgs e)
        {

            if(gebruikersmodel.type =="eigenaar")
            {//deze code zal creëren owner features form
            this.Hide();
            Ownerfeatures owner = new Ownerfeatures();
            owner.Show();
            }
           else
           {
                MessageBox.Show("Toegang geweigerd!"); 
           }

        }

        private void btnplaces_Click(object sender, EventArgs e)
        {//deze code zal creëren  availible places form
            this.Hide();
            Beschikbaarheid places = new Beschikbaarheid();
            places.Show(); 
        }

        private void btnmake_Click(object sender, EventArgs e)
        {//deze code zal creëren select customer form
            this.Hide();
            KlantSelectie create = new KlantSelectie();
            create.Show(); 
        }

        private void btndelete_Click(object sender, EventArgs e)
        {//deze code zal creëren  delete reservation form
            this.Hide();
            ReserveringVerwijderen del = new ReserveringVerwijderen();
            del.Show();
        }

        private void btncoins_Click(object sender, EventArgs e)
        {//deze code zal creëren select reservation form
            ReserveringWijzigen.changereservation = false ;
            this.Hide();
            ReserveringSelecctie select = new ReserveringSelecctie();
            select.Show();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {//deze code zal creëren select reservation form
            ReserveringWijzigen.changereservation = true;
            this.Hide();
            ReserveringSelecctie select = new ReserveringSelecctie();
            select.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            btnowner.Enabled = gebruikersmodel.type == "eigenaar";
        }
    }
}
