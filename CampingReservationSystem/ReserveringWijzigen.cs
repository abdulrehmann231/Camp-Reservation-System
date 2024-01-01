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
    public partial class ReserveringWijzigen : Form
    {
        CustomerModel customer = new CustomerModel();
        public static Boolean edit = false;
        Methods met = new Methods();
        DataTable dtplaces = new DataTable();
        Reservation_model reservering;
        public static Boolean changereservation = false;
        public ReserveringWijzigen(Reservation_model testr)
        {
            reservering = testr;
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void ChangeReservation_Load(object sender, EventArgs e)
        {
            met.getcoins(reservering , customer );
            //deze code roept de methode aan om plaatsen te krijgen en voegt deze toe aan combobox 
            dtplaces = met.viewplaces();
            foreach (DataRow dr in dtplaces.Rows)
            {
                listplaces.Items.Add(dr["plek"].ToString());
            }
            lblidvalue.Text = reservering.id;
            dtpend.MinDate = dtpstart.Value;
            listplaces.SelectedItem = reservering.place;
            dtpstart.Value = Convert.ToDateTime(reservering.startdate);
            dtpend.Value = Convert.ToDateTime(reservering.enddate);
            nuadults.Value = reservering.amount_adults;
            nukids.Value = reservering.amount_kids;
            nucars.Value = reservering.amount_cars;
            nuvisitors.Value = reservering.amount_visitors;
            nuelectricty.Value = reservering.amount_electricity;
            nushower.Value = reservering.amount_showercoins;
            nuwash.Value = reservering.amount_washcoins;
            nubigcaravan.Value = reservering.amount_big_caravan;
            nusmallcaravan.Value = reservering.amount_small_caravan;
            nubigtents.Value = reservering.amount_big_tent;
            nusmalltent.Value = reservering.amount_small_tent;
            if (reservering.amount_pet == true)
            {
                chkJa.Checked = true;
            }
            else if (reservering.amount_pet == false)
            {
                chkNee.Checked = true;
            }  
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
                    MessageBox.Show("Reservering moet op zijn minst 1 nacht hebben");

            }
            else
            {  //deze methode roept de respectieve methode aan om details te bewerken en nieuwe kosten op te halen en op te slaan in de database  
               reservering.startdate = dtpstart.Value.ToString();
                reservering.enddate = dtpend.Value.ToString();  
                reservering.place = listplaces.SelectedItem.ToString();
                string message = met.check_dates(reservering);
                MessageBox.Show(message); 
               if  (message == "Datum & plek zijn beschikbaar")
               {
                   reservering.duration =  met.calculateduration(reservering.startdate ,reservering.enddate   );
                   edit = true;

                   if (chkJa.Checked == true)
                   {
                       reservering.amount_pet = true;
                   }
                   else if (chkNee.Checked == false)
                   {
                       reservering.amount_pet = false;
                   }

                   reservering.amount_adults = Convert.ToInt32(nuadults.Value);
                   reservering.amount_kids = Convert.ToInt32(nukids.Value);
                   reservering.amount_cars = Convert.ToInt32(nucars.Value);
                   reservering.amount_electricity = Convert.ToInt32(nuelectricty.Value);
                   reservering.amount_visitors = Convert.ToInt32(nuvisitors.Value);
                   reservering.amount_washcoins = Convert.ToInt32(nuwash.Value);
                   reservering.amount_showercoins = Convert.ToInt32(nushower.Value);
                   reservering.amount_small_caravan = Convert.ToInt32(nusmallcaravan.Value);
                   reservering.amount_big_caravan = Convert.ToInt32(nubigcaravan.Value);
                   reservering.amount_small_tent = Convert.ToInt32(nusmalltent.Value);
                   reservering.amount_big_tent = Convert.ToInt32(nubigtents.Value);
                    reservering =  met.calculate_cost(reservering);
                   MessageBox.Show("De totale nieuwe prijs is : " + reservering.totalcost  );
                   DialogResult result = MessageBox.Show("Wilt u wijzigingen bevestigen?", "  aandacht", MessageBoxButtons.YesNo); 
                   if (result == DialogResult.Yes  )
                   {
                       int editdone = met.changereservation(reservering);
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

        private void chkyes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJa.Checked)
            {
                chkNee.Checked = false;
            }
        }

        private void chkNee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNee.Checked)
            {
                chkJa.Checked = false;
            }
        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }
    }
}
