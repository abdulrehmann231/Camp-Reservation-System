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
    public partial class ReserveringSelecctie : Form
    {
        Methods met = new Methods();
        DataTable dtreservation = new DataTable();
        Reservation_model reservering = new Reservation_model();
        public ReserveringSelecctie()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show(); 
        }

        private void selectReservation_Load(object sender, EventArgs e)
        {//deze code laat alles zien reservations 
            dtreservation = met.viewreservations();
            reservationdata.DataSource = dtreservation; 

        }






        public void Detecteren()
        {
 
        }


        private void btnselect_Click(object sender, EventArgs e)
        {//deze code selecteerd een reservering&detecteerd of reservering is geselcteerd/gvonden
            if (reservationdata.SelectedRows.Count == 0)
            {
                MessageBox.Show("Geen gegevens gevonden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (ReserveringWijzigen.changereservation == true)
                {
                    reservering.id = dtreservation.Rows[reservationdata.CurrentRow.Index]["reservering_ID"].ToString();
                    reservering.startdate = dtreservation.Rows[reservationdata.CurrentRow.Index]["arrival_date"].ToString();
                    reservering.enddate = dtreservation.Rows[reservationdata.CurrentRow.Index]["departure_date"].ToString();

                    this.Hide();
                    ReserveringWijzigen change = new ReserveringWijzigen(reservering);
                    change.Show();
                }
                else
                {

                }
            }
        }

        private void reservationdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
