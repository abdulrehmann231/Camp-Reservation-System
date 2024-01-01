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
    public partial class KlantLijst : Form
    {
        Methods met = new Methods();

        public KlantLijst()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            KlantGegevens cu = new KlantGegevens();
            cu.Show();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Hide();
            KlantGegevens cu = new KlantGegevens();
            cu.Show();
        }

        private void customerlist_Load(object sender, EventArgs e)
        {//deze code krijgt alle klanten door de respectieve methoden aan te roepen
            DataTable dtcustomers = new DataTable();
            dtcustomers = met.view_customers();
            customerdata.DataSource = dtcustomers; 
        }
    }
}
