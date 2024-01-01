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
    public partial class WijzigReservering : Form
    {
        CustomerModel customer = new CustomerModel();
        public static Boolean edit = false;
        Methods met = new Methods();
        DataTable dtplaces = new DataTable();
        Reservation_model reservation;
        public static Boolean changereservation = false;
        public WijzigReservering(Reservation_model testr)
        {
            reservation = testr;
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void ChangeReservation_Load(object sender, EventArgs e)
        {//deze code roept de methode aan om plaatsen te krijgen en voegt deze toe aan combobox 
            dtplaces = met.viewplaces();
            foreach (DataRow dr in dtplaces.Rows)
            {
                listplaces.Items.Add(dr["place_name"].ToString());
            }
          //  lblidvalue.Text = 
            dtpstart.MinDate = DateTime.Today;
            dtpend.MinDate = dtpstart.Value;  
        }

        private void dtpstart_ValueChanged(object sender, EventArgs e)
        {
            dtpend.MinDate = dtpstart.Value;  
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        { //deze methode controleert of de gegevens geldig en aanwezig zijn 
            if((listplaces.SelectedIndex == -1 )  )
            {
                MessageBox.Show("voer alle gegevens in "); 
            }
           else if (dtpstart.Value == dtpend.Value)
            {
                    MessageBox.Show("Reservation should be atleast one day...change end date");

            }
        else
            {  //deze methode roept de respectieve methode aan om details te bewerken en nieuwe kosten op te halen en op te slaan in de database  
               reservation.startdate = dtpstart.Value.ToString();
                reservation.enddate = dtpend.Value.ToString();  
                reservation.place = listplaces.SelectedItem.ToString();
                string message = met.check_dates(reservation);
                MessageBox.Show(message ); 
               if  (message == "Datums zijn beschikbaar")
               {
           reservation.duration =  met.calculateduration(reservation.startdate ,reservation.enddate   );
                   edit = true;

                   if (chkyes.Checked == true)
                   {
                       reservation.amount_pet = true;
                   }
                   else if (chkno.Checked == false)
                   {
                       reservation.amount_pet = false;
                   }

                   reservation.amount_adults = Convert.ToInt32(nuadults.Value);
                   reservation.amount_kids = Convert.ToInt32(nukids.Value);
                   reservation.amount_cars = Convert.ToInt32(nucars.Value);
                   reservation.amount_electricity = Convert.ToInt32(nuelectricty.Value);
                   reservation.amount_visitors = Convert.ToInt32(nuvisitors.Value);
                   reservation.amount_washcoins = Convert.ToInt32(nuwash.Value);
                   reservation.amount_showercoins = Convert.ToInt32(nushower.Value);
                   reservation.amount_small_caravan = Convert.ToInt32(nusmallcaravan.Value);
                   reservation.amount_big_caravan = Convert.ToInt32(nubigcaravan.Value);
                   reservation.amount_small_tent = Convert.ToInt32(nusmalltent.Value);
                   reservation.amount_big_tent = Convert.ToInt32(nubigtents.Value);
                reservation  =  met.calculate_cost(reservation);
                   MessageBox.Show("Your new cost is : " + reservation.totalcost  );
                   DialogResult result = MessageBox.Show("Wilt u wijzigingen bevestigen?", "  aandacht", MessageBoxButtons.YesNo); 
                   if (result == DialogResult.Yes  )
                   {
                       int editdone = met.changereservation(reservation );
                       if (editdone ==1)
                       {
                           MessageBox.Show(" Wijzigingen  bevestigd! "); 
                       }
                       else
                       {
                           MessageBox.Show(" Wijzigingen niet bevestigd! "); 
                       }
                       this.Hide();
                       Home home = new Home();
                       home.Show(); 
                   }
               }
               
            }

        }

        private void lblcars_Click(object sender, EventArgs e)
        {

        }

        private void lblidvalue_Click(object sender, EventArgs e)
        {

        }
    }
}
