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
    public partial class Ownerfeatures : Form
    {
        
        public Ownerfeatures()
        {
            
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {// deze code brengt je naar homepage
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {// deze code brengt je naar newuser form
            this.Hide();
            WerkerVoegen add = new WerkerVoegen();
            add.Show();
        }

        private void btnlistuser_Click(object sender, EventArgs e)
        {// deze code brengt je naar userlist form
            this.Hide();
            userlist list = new userlist();
            list.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {// deze code brengt je naar deleteuser form
            this.Hide();
            GebruikerVerwijderen delete = new GebruikerVerwijderen();
            delete.Show(); 
        }

        private void btnedit_Click(object sender, EventArgs e)
        {// deze code brengt je naar edituserform
            this.Hide();
            GebruikerWijzigSelectie edit = new GebruikerWijzigSelectie();
            edit.Show();
        }

        private void btnrate_Click(object sender, EventArgs e)
        { // deze code brengt je naar  rate form
            this.Hide();
            PrijsLijst list = new PrijsLijst();
            list.Show();
        }

        private void btnearnings_Click(object sender, EventArgs e)
        { //  deze code brengt je naar revenue form
            this.Hide();
            Omzet re = new Omzet();
            re.Show();
        }

    }
}
