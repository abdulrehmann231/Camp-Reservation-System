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
    public partial class KlantVerwijderen : Form
    {
        CustomerModel customer = new CustomerModel();
        Methods met = new Methods();
        DataTable dtcustomers = new DataTable();
        public KlantVerwijderen()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            KlantGegevens cu = new KlantGegevens();
            cu.Show();
        }

        private void DeleteCustomers_Load(object sender, EventArgs e)
        {//deze code krijgt alle klanten door de respectieve methoden aan te roepen
            dtcustomers = met.view_customers();
            customerdata.DataSource = dtcustomers; 
        }

        private void lbldetails_Click(object sender, EventArgs e)
        {

        }


        private void btndelete_Click(object sender, EventArgs e)
        {//deze code verwijdert de klant door de respectieve methode aan te roepen 
            if (customerdata.SelectedRows.Count == 0)
            {
                MessageBox.Show("Geen gegevens gevonden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                customer.id = dtcustomers.Rows[customerdata.CurrentRow.Index]["klant_ID"].ToString();
                int result = met.removecustomer(customer);
                if (result == 1)
                {
                    MessageBox.Show("Customer deleted");
                    this.Hide();
                    KlantGegevens cu = new KlantGegevens();
                    cu.Show();

                }
                else
                {
                    MessageBox.Show("Customer not delete ... try again");
                    this.Hide();
                    KlantGegevens cu = new KlantGegevens();
                    cu.Show();
                }
            }
        }

        private void customerdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
