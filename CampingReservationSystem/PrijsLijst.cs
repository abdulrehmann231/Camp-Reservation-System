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
    public partial class PrijsLijst : Form
    {
        public PrijsLijst()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ownerfeatures feature = new Ownerfeatures();
            feature.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ownerfeatures owner = new Ownerfeatures();
            owner.Show();
        }

        private void Rate_Load(object sender, EventArgs e)
        {// this code will display costs
            lblcostadults.Text = "€ " + Reservation_model.adult_rate.ToString();
            lblcostkids.Text = "€ " + Reservation_model.kid_rate.ToString();
            lblcostpet.Text = "€ " + Reservation_model.pet_rate.ToString();
            lblcostvisitor.Text = "€ " + Reservation_model.Visitors_rate.ToString();
            lblcostelectricity.Text = "€ " + Reservation_model.Electricity_rate.ToString();
            lblcostwash.Text = "€ " + Reservation_model.Washcoin_rate.ToString();
            lblcostshower.Text = "€ " + Reservation_model.Showercoin_rate.ToString();
            lblcostcar.Text = "€ " + Reservation_model.Car_rate.ToString();
            lblcostsmallcaravan.Text = "€ " + Reservation_model.smallCaravan_rate.ToString();
            lblcostbigcaravan.Text = "€ " + Reservation_model.bigCaravan_rate.ToString();
            lblcostbigtent.Text = "€ " + Reservation_model.Bigtent_rate.ToString();
            lblcostsmalltent.Text = "€ " + Reservation_model.Smalltent_rate.ToString();   
   
        }
    }
}
