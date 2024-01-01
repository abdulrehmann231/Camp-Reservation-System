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
    public partial class Beschikbaarheid : Form
    {
        Reservation_model reservering = new Reservation_model();
        Methods met = new Methods();
        DataTable dtplaces = new DataTable();
        public Beschikbaarheid()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            reservering.startdate = dtpstart.Value.ToString ();
            reservering.enddate = dtpend.Value.ToString ();  
            DataTable dtfreeplace = new DataTable();
            dtfreeplace = met.Check_Free_Place(reservering );
            placesdata.DataSource = dtfreeplace; 
        }

        private void btnback_Click(object sender, EventArgs e)
        {//deze code brengt de gebruiker naar de homepage 
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void Availibleplaces_Load(object sender, EventArgs e)
        {//deze code roept de methode aan om plaatsen te krijgen 
            dtplaces = met.viewplaces();
            dtpstart.MinDate = DateTime.Today;
            dtpend.MinDate = dtpstart.Value; 
       /*     dtplaces.Columns.Add(new DataColumn("booking start date ", typeof(string)));
            dtplaces.Columns.Add(new DataColumn("booking end date ", typeof(string)));
            for (int x = 0; x < 100; x++ )
            {
                string[] date = new  string [2]; 
                date = met.fillfreedate(x );
                
                DataRow workrow = dtplaces.Rows[x];
            workrow[2] =  date[1] ;
            workrow[3] = date[0];
       } */    
            placesdata.DataSource = dtplaces; 
        
        }

        private void placesdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpstart_ValueChanged(object sender, EventArgs e)
        {
            dtpend.MinDate = dtpstart.Value;  
        }
    }
}
