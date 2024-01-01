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
    public partial class ReserveringMaken : Form
    {
        Reservation_model reservering;
        Methods met = new Methods();
        DataTable dtplaces = new DataTable();
        CustomerModel customer;
        public ReserveringMaken(CustomerModel test,Reservation_model testr)
        {
            reservering = testr;
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
                listplaces.Items.Add(dr["plek"].ToString());
            }
            lblnamevalue.Text = customer.name + " " + customer.surname;
            dtpstart.MinDate = DateTime.Today;
            dtpend.MinDate = dtpstart.Value;  
            if (Factuur.frominvoice == true  )
            { 
                dtpend.MinDate = dtpstart.Value;
                listplaces.SelectedItem = reservering.place;
                dtpstart.Value = Convert.ToDateTime (  reservering.startdate);
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
                if (reservering.amount_pet == true  )
                {
                    chkJa.Checked = true; 
                }
                else if (reservering.amount_pet == false)
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
            if (nuadults.Value <= 0)
            {
                MessageBox.Show("Vul alle verplichte velden!");
                
            }
            else
            {
                if ((listplaces.SelectedIndex == -1) || (chkNee.Checked == false && chkJa.Checked == false))
                {
                    MessageBox.Show("Vul alle verplichte velden!");
                }
                else
                {
                    if (chkJa.Checked == true)
                    {
                        reservering.amount_pet = true;
                    }
                    else if (chkNee.Checked == false)
                    {
                        reservering.amount_pet = false;
                    }
                    if (dtpstart.Value == dtpend.Value)
                    {
                        MessageBox.Show("Reservering moet op zijn minst 1 nacht hebben");

                    }
                    else
                    {
                        reservering.place = listplaces.SelectedItem.ToString();
                        reservering.startdate = dtpstart.Value.ToString();
                        reservering.enddate = dtpend.Value.ToString();
                        string message = met.check_dates(reservering);
                        MessageBox.Show(message);
                        if (message == "Datum & plek zijn beschikbaar")
                        {
                            Factuur.flag = true;
                            reservering.place = listplaces.SelectedItem.ToString();
                            reservering.duration = met.calculateduration(reservering.startdate, reservering.enddate);
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
                            this.Hide();
                            Factuur reservering_factuur = new Factuur(reservering, customer);
                            reservering_factuur.Show();
                        }

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
