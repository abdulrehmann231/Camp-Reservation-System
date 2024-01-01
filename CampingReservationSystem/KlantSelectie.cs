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
    public partial class KlantSelectie : Form
    {
        public static bool fromklant = false;
        Methods met = new Methods();
        DataTable dtcustomers = new DataTable();
        CustomerModel customer = new CustomerModel();
        Reservation_model reservation = new Reservation_model();
        public KlantSelectie()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        { //deze code slaat details van geselecteerd op klant

            if (customerdata.SelectedRows.Count == 0)
            {
                MessageBox.Show("Geen gegevens gevonden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                customer.id = dtcustomers.Rows[customerdata.CurrentRow.Index]["klant_ID"].ToString();
                customer.name = dtcustomers.Rows[customerdata.CurrentRow.Index]["customer_name"].ToString();
                customer.surname = dtcustomers.Rows[customerdata.CurrentRow.Index]["customer_surname"].ToString();
                this.Hide();
                Factuur.frominvoice = false;
                ReserveringMaken create = new ReserveringMaken(customer, reservation);
                create.Show();
            }

        }

        private void Select_customer_Load(object sender, EventArgs e)
        {//deze code laat alles zien klants
            dtcustomers = met.view_customers();
            customerdata.DataSource = dtcustomers; 
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show(); 
        }

        private void customerdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fromklant = true;
            this.Hide();
            KlantGegevens nieuw = new KlantGegevens();
            nieuw.Show();
        }

        private void lblselect_Click(object sender, EventArgs e)
        {

        }
    }
}
