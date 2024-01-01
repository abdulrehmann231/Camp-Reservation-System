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
    public partial class Factuur : Form
    {
        public static bool flag= true  ;
        Methods met = new Methods();
        public static bool frominvoice = false;
        Reservation_model reservering;
        CustomerModel customer;
        public Factuur(Reservation_model test,CustomerModel testc)
        {
            customer = testc;
            reservering = test;
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {  if (flag == false )
          {
              btnconfrim.Text = "Oke"; 
          }
            if (reservering.amount_pet == true)
            {
                lblquanpet.Text = " 1 ";
            }
            else 
            {
                lblquanpet.Text = " 0 "; 
            } // printing quantity of coins
            lblname.Text = "Klant naam : " + customer.name + ' '+ customer.surname;
            lblinvoice.Text = "Reservering ID : " + reservering.id;
            lblid.Text =  "Klant ID : "  + customer.id;
            lblplace.Text = "Plek : " + reservering.place;
            lblduration.Text = "Duur : " + reservering.duration;
            lblquanadults.Text = reservering.amount_adults.ToString(); ;
            lblquankid.Text = reservering.amount_kids.ToString(); ;
            lblquancars.Text = reservering.amount_cars.ToString();
            lbldayelectricity.Text = reservering.amount_electricity.ToString();
            lblquanvisitor.Text = reservering.amount_visitors.ToString();
            lblquanwash.Text = reservering.amount_washcoins.ToString();
            lblquanshower.Text = reservering.amount_showercoins.ToString();
            lblquanbigcaravan.Text = reservering.amount_big_caravan.ToString();
            lblquansmallcaravan.Text = reservering.amount_small_caravan.ToString();
            lblquanbigtent.Text = reservering.amount_big_tent.ToString();
            lblquansmalltent.Text = reservering.amount_small_tent.ToString();  
        //printing cost of each coin
            reservering = met.calculate_cost(reservering);
            lblcostadult.Text = "€ " + reservering.cost_adult.ToString();
            lblcostkid.Text = "€ " + reservering.cost_kids.ToString();
            lblcostpet.Text = "€ " + reservering.cost_pet.ToString();
            lblcostelectricty.Text = "€ " + reservering.cost_electricity.ToString();
            lblcostcars.Text = "€ " + reservering.cost_cars.ToString();
            lblcostshower.Text = "€ " + reservering.cost_shower.ToString();
            lblcostwash.Text = "€ " + reservering.cost_wash.ToString();
            lblcostvisitor.Text = "€ " + reservering.cost_visitor.ToString();
            lblcostbigcaravan.Text = "€ " + reservering.cost_big_caravan.ToString();
            lblcostsmallcaravan.Text = "€ " + reservering.cost_small_caravan.ToString();
            lblcostbigtent.Text = "€ " + reservering.cost_big_tent.ToString();
            lblcostsmalltent.Text = "€ " + reservering.cost_small_tent.ToString();
            lblreservationcost.Text = "€ " + reservering.totalcost.ToString();  
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (Factuur.flag == false)
            {
                this.Hide();
                Omzet re = new Omzet();
                re.Show();
            }
            else
            {
                frominvoice = true;
                this.Hide();
                ReserveringMaken create = new ReserveringMaken(customer, reservering);
                create.Show();
            }
        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }

        private void btnconfrim_Click(object sender, EventArgs e)
        {  if (flag == false )
        {
            this.Hide();
               Omzet re = new Omzet();
               re.Show();
                   
        }
           else
           {

               //deze methode slaat de munten en reserveringsdetails op door de respectievelijke methoden aan te roepen 
            
            DialogResult result = MessageBox.Show(" Weet u het zeker?" , " attention " , MessageBoxButtons.YesNo  );
            if (result == DialogResult.Yes)
            {
                int resultt = met.create_reservation(reservering, customer);
                if (resultt == 1)
                {
                    MessageBox.Show("Reservering aangemaakt");
                        reservering.id = met.getIDoflatestreservation();
                    resultt = met.add_coin_details(reservering);
                    if (resultt == 1)
                    {
                        MessageBox.Show("Uw gegevens zijn opgeslagen");
                    }
                    else
                    {
                        MessageBox.Show("Error 404");
                    }

                    this.Hide();
                    Home home = new Home();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Reserveren niet gelukt, probeer het opnieuw");
                    this.Hide();
                    Home home = new Home();
                    home.Show();
                }
            }
           }
        }

        private void lblcoinname_Click(object sender, EventArgs e)
        {
            lblcoinname.BackColor = System.Drawing.Color.Transparent;

        }

        private void lblreservationcost_Click(object sender, EventArgs e)
        {

        }
    }
}
