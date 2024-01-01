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
    public partial class NieuweReservering : Form
    {
        Reservation_model reservation;
        Methods met = new Methods();
        DataTable dtplaces = new DataTable();
        CustomerModel customer;
        public NieuweReservering(CustomerModel test,Reservation_model testr)
        {
            reservation = testr;
            customer = test;
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void Create_Reservation_Load(object sender, EventArgs e)
        {//deze code roept de methode aan om plaatsen te krijgen en voegt deze toe aan combobox
            dtplaces = met.viewplaces();
            foreach (DataRow dr in dtplaces.Rows)
            {
                listplaces.Items.Add(dr["place_name"].ToString());
            }
            lblnamevalue.Text = customer.name + " " + customer.surname;
            dtpstart.MinDate = DateTime.Today;
            dtpend.MinDate = dtpstart.Value;  
            if (Factuur.frominvoice == true  )
            { 
                dtpend.MinDate = dtpstart.Value;
                listplaces.SelectedItem = reservation.place;
                dtpstart.Value = Convert.ToDateTime (  reservation.startdate);
                dtpend.Value = Convert.ToDateTime(reservation.enddate);
                nuadults.Value = reservation.amount_adults;
                nukids.Value = reservation.amount_kids;
                nucars.Value = reservation.amount_cars;
                nuvisitors.Value = reservation.amount_visitors;
                nuelectricty.Value = reservation.amount_electricity;
                nushower.Value = reservation.amount_showercoins;
                nuwash.Value = reservation.amount_washcoins;
                nubigcaravan.Value = reservation.amount_big_caravan;
                nusmallcaravan.Value = reservation.amount_small_caravan;
                nubigtents.Value = reservation.amount_big_tent;
                nusmalltent.Value = reservation.amount_small_tent;
                if (reservation.amount_pet == true  )
                {
                    chkJa.Checked = true; 
                }
                else if (reservation.amount_pet == false)
                {
                    chkNee.Checked = true;
                }
            }

           
        }

        private void chkemployee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJa.Checked)
            {
                chkNee.Checked = false;
            }
        }

        private void btninvoice_Click(object sender, EventArgs e)
        { // deze methode slaat gegevens op in objecten en maakt vervolgens het factuurformulier 
            if((listplaces.SelectedIndex == -1 ) ||(chkNee.Checked == false && chkJa.Checked == false   ) )
            {
                MessageBox.Show("voer alle gegevens in "); 
            }
            else if (chkJa.Checked == true && chkNee.Checked == true)
            {
                MessageBox.Show("selecteer een selectievakje voor huisdier ");
            }
            else
            {
                if (chkJa.Checked == true)
                {
                    reservation.amount_pet = true;
                }
                else if (chkNee.Checked == false)
                {
                    reservation.amount_pet = false;
                }
                if (dtpstart.Value == dtpend.Value)
                {
                    MessageBox.Show("Reservation should be atleast one day...change end date");

                }
                else
                {
                    reservation.place = listplaces.SelectedItem.ToString();
                    reservation.startdate = dtpstart.Value.ToString();
                    reservation.enddate = dtpend.Value.ToString();
                    string message = met.check_dates(reservation );
                    MessageBox.Show(message ); 
                    if (message == "Datums zijn beschikbaar")
                    {
                        Factuur.flag = true; 
                        reservation.place = listplaces.SelectedItem.ToString();
                        reservation.duration = met.calculateduration(reservation.startdate, reservation.enddate);
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
                        this.Hide();
                        Factuur reservation_invoice = new Factuur(reservation, customer);
                        reservation_invoice.Show();
                    }
                    
                }
            }
        }

        private void dtpstart_ValueChanged(object sender, EventArgs e)
        {
            dtpend.MinDate = dtpstart.Value;  
        }

        private void lblnamevalue_Click(object sender, EventArgs e)
        {

        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void chkno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNee.Checked)
            {
                chkJa.Checked = false;
            }
        }
    }
}
