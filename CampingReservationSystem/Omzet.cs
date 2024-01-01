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
    public partial class Omzet : Form
    {
        DataTable dtreservation = new DataTable();
        Methods met = new Methods();
        Reservation_model reservering = new Reservation_model();
        CustomerModel customer = new CustomerModel();
        public Omzet()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ownerfeatures owner = new Ownerfeatures();
            owner.Show(); 
        }

        private void Revenue_Load(object sender, EventArgs e)
        {//deze code haalt alle reserveringen op en berekent de totale inkomsten door de respectievelijke methoden aan te roepen 
            dtreservation = met.viewreservations();
            reservationdata.DataSource = dtreservation;
            lblearnedd.Text = "€ " + met.calculateTotalrevenue().ToString (); 
        }



        private void btninvoice_Click(object sender, EventArgs e)
        {//deze code toont de factuur van geselecteerde reserveringen 
            if (reservationdata.SelectedRows.Count == 0)
            {
                MessageBox.Show("Geen gegevens gevonden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                reservering.id = dtreservation.Rows[reservationdata.CurrentRow.Index]["reservering_ID"].ToString();
                met.getcoins(reservering, customer);
                Factuur.flag = false;
                this.Hide();
                Factuur customerinvoice = new Factuur(reservering, customer);
                customerinvoice.Show();
            }

        }
    }
}
