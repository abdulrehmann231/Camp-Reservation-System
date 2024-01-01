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
    public partial class KlantWijzigSelectie : Form
    {
        CustomerModel customer = new CustomerModel();
        Methods met = new Methods();
        DataTable dtcustomers = new DataTable();
        public KlantWijzigSelectie()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            KlantGegevens cu = new KlantGegevens();
            cu.Show();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {//deze code slaat de details van de geselecteerde klant op in objecten 
            if (customerdata.SelectedRows.Count == 0)
            {
                MessageBox.Show("Geen gegevens gevonden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                customer.id = dtcustomers.Rows[customerdata.CurrentRow.Index]["klant_ID"].ToString();
                customer.name = dtcustomers.Rows[customerdata.CurrentRow.Index]["customer_name"].ToString();
                customer.surname = dtcustomers.Rows[customerdata.CurrentRow.Index]["customer_surname"].ToString();
                customer.address = dtcustomers.Rows[customerdata.CurrentRow.Index]["customer_address"].ToString();
                customer.phonenumber = dtcustomers.Rows[customerdata.CurrentRow.Index]["customer_contact"].ToString();
                customer.zipcode = dtcustomers.Rows[customerdata.CurrentRow.Index]["customer_zipcode"].ToString();
                customer.email = dtcustomers.Rows[customerdata.CurrentRow.Index]["customer_email"].ToString();
                this.Hide();
                KlantWijzigen edit = new KlantWijzigen(customer);
                edit.Show();
            }
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {// deze code krijgt alle klants
            dtcustomers = met.view_customers();
            customerdata.DataSource = dtcustomers;
        }

        private void customerdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
