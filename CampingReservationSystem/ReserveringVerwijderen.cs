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
    public partial class ReserveringVerwijderen : Form
    {
        Methods met = new Methods();
        DataTable dtreservation = new DataTable();
        public ReserveringVerwijderen()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void DeleteReservation_Load(object sender, EventArgs e)
        {//deze code krijgt alle reserveringen 
            dtreservation = met.viewreservations();
            reservationdata.DataSource = dtreservation; 
        }


        private void btndelte_Click(object sender, EventArgs e)
        {//deze code verwijdert de reserveringen door de respectieve methode aan te roepen 
            if (reservationdata.SelectedRows.Count == 0)

            {
                MessageBox.Show("Geen gegevens gevonden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult answer = MessageBox.Show("Weet u het zeker?", "attention", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    string id = dtreservation.Rows[reservationdata.CurrentRow.Index]["reservering_ID"].ToString();
                    int result = met.deletereservation(id);
                    if (result == 1)
                    {
                        MessageBox.Show("reservering verwijderd");
                        dtreservation = met.viewreservations();
                        reservationdata.DataSource = dtreservation;
                    }
                    else
                    {
                        MessageBox.Show(" reservering niet verwijderd ");
                        dtreservation = met.viewreservations();
                        reservationdata.DataSource = dtreservation;
                    }
                }

            }


        }
    }
}
