using System;
using System.Data;
using System.Data.OleDb;
namespace CampingReservationSystem
{
    class Methods
    {
        Database objectdatabase = new Database();
        OleDbCommand command;
        public string checkemployee(gebruikersmodel gebruiker) //deze methode zal controleren of er een medewerker is met dit wachtwoord en deze naam 
        {
            DataTable dt = new DataTable();
            int totalrows = 0;
            string message = "";

            string query = "select * from werknemer_tabel where werknemer_naam='" + gebruiker.gebruikersnaam + "' and werknemer_wachtwoord='" + gebruiker.wachtwoord + "'";

            dt = objectdatabase.read(query, dt);


            totalrows = dt.Rows.Count;
            if (totalrows > 0)
            {
                message = " Succesvol ingelogd ";
                gebruikersmodel.userid = dt.Rows[0]["werknemer_ID"].ToString();

            }
            else
            {
                message = "foute gebruikersnaam of wachtwoord";
            }
            return message;

        }
        public string checkowner(gebruikersmodel user) //deze methode zal controleren of er een eigenaar is met dit wachtwoord en deze naam 
        {
            DataTable dt = new DataTable();
            int totalrows = 0;
            string message = "";

            string query = "select * from eigenaar_tabel where eigenaar_naam='" + user.gebruikersnaam + "' and eigenaar_wachtwoord='" + user.wachtwoord + "'";

            dt = objectdatabase.read(query, dt);


            totalrows = dt.Rows.Count;
            if (totalrows > 0)
            {
                message = " Succesvol ingelogd ";
                gebruikersmodel.userid = dt.Rows[0]["eigenaar_ID"].ToString();

            }
            else
            {
                message = "foute gebruikersnaam of wachtwoord";
            }
            return message;

        }
        public int recordlogin(gebruikersmodel u) //deze methode slaat de gegevens op van de gebruiker die zich heeft aangemeld 
        {
            int result = 0;
            string query = "INSERT INTO login_table (gebruikersnaam,wachtwoord,gebruikerstype) VALUES (@u.username,@u.password,gebruikersmodel.type)";
            command = new OleDbCommand();
            command.Parameters.AddWithValue("@u.username", u.gebruikersnaam);
            command.Parameters.AddWithValue("@u.password", u.wachtwoord);
            command.Parameters.AddWithValue("@gebruikersmodel.type", gebruikersmodel.type);
            result = objectdatabase.runcommand(query, command);
            return result;
        }
        public DataTable view_customers() // deze methode haalt alle klanten uit de database
        {

            DataTable dtcustomers = new DataTable();
            string query = "select * from klant_tabel";
            dtcustomers = objectdatabase.read(query, dtcustomers);
            return dtcustomers;
        }
        public int savecustomers(CustomerModel customer) // deze methode slaat de gegevens van de klant op in de database 
        {
            string query = "INSERT INTO klant_tabel (customer_name,customer_surname,customer_address,customer_contact,customer_email,customer_zipcode) VALUES" + " (@customer.name,@customer.surname,@customer.address,@customer.phonenumber,@customer.email,@customer.zipcode)";
            command = new OleDbCommand();
            command.Parameters.AddWithValue("@customer.name", customer.name);
            command.Parameters.AddWithValue("@customer.surname", customer.surname);
            command.Parameters.AddWithValue("@customer.address", customer.address);
            command.Parameters.AddWithValue("@customer.phonenumber", customer.phonenumber);
            command.Parameters.AddWithValue("@customer.email", customer.email);
            command.Parameters.AddWithValue("@customer.zipcode", customer.zipcode);
            int result = objectdatabase.runcommand(query, command);
            return result;
        }
        public int changecustomerdetails(CustomerModel customer)//deze methode zal de details van de klant wijzigen volgens invoer in de database 
        {
            int result = 0;
            string query = "UPDATE klant_tabel  SET customer_name='" + customer.name + "' , customer_surname='" + customer.surname + "' , customer_address='" + customer.address + "' , customer_contact='" + customer.phonenumber + "' , customer_email='" + customer.email + "' , customer_zipcode='" + customer.zipcode + "' WHERE klant_ID=" + customer.id;
            command = new OleDbCommand();
            result = objectdatabase.runcommand(query, command);
            return result;
        }
        public int removecustomer(CustomerModel customer)//deze methode verwijdert of verwijdert een rij in de klantentabel op basis van klant-ID 
        {
            int result = 0;
            string query = "DELETE FROM klant_tabel WHERE klant_ID=" + customer.id;
            command = new OleDbCommand();
            result = objectdatabase.runcommand(query, command);
            return result;
        }
        public int addowner(gebruikersmodel gebruiker)//deze methode slaat de details van de eigenaar op volgens invoer in de database
        {
            int result = 0;
            string query = "INSERT INTO eigenaar_tabel (eigenaar_naam,eigenaar_wachtwoord) VALUES" + " (@gebruiker.username,@gebruiker.password)";
            command = new OleDbCommand();
            command.Parameters.AddWithValue("@gebruiker.username", gebruiker.gebruikersnaam);
            command.Parameters.AddWithValue("@gebruiker.password", gebruiker.wachtwoord);
            result = objectdatabase.runcommand(query, command);
            return result;
        }
        public int addemployee(gebruikersmodel user)//deze methode slaat de details van de werknemer op volgens invoer in de database
        {
            int result = 0;
            string query = "INSERT INTO werknemer_tabel (werknemer_naam,werknemer_wachtwoord) VALUES" + " (@user.username,@user.password)";
            command = new OleDbCommand();
            command.Parameters.AddWithValue("@user.username", user.gebruikersnaam);
            command.Parameters.AddWithValue("@user.password", user.wachtwoord);
            result = objectdatabase.runcommand(query, command);
            return result;
        }
        public DataTable viewemployess()//deze methode krijgt alle werknemers 
        {
            DataTable dtemployees = new DataTable();
            string query = "SELECT * FROM  werknemer_tabel";
            dtemployees = objectdatabase.read(query, dtemployees);
            return dtemployees;
        }
        public DataTable viewowners()//deze methode krijgt alle eignaars 
        {
            DataTable dtowners = new DataTable();
            string query = "SELECT * FROM  eigenaar_tabel";
            dtowners = objectdatabase.read(query, dtowners);
            return dtowners;
        }
        public DataTable viewreservations()//deze methode krijgt alle reservations
        {
            DataTable dtreservation = new DataTable();
            string query = "SELECT * FROM  reservering_tabel";
            dtreservation = objectdatabase.read(query, dtreservation);
            return dtreservation;
        }
        public DataTable viewplaces()//deze methode krijgt alle places
        {
            DataTable dtplaces = new DataTable();
            string query = "SELECT * FROM  plek_tabel";
            dtplaces = objectdatabase.read(query, dtplaces);
            return dtplaces;
        }
        public int deleteowner(string id) //deze methode verwijdert of verwijdert een rij in de eignaartabel op basis van eignaar-ID 
        {
            string query = "DELETE FROM eigenaar_tabel WHERE eigenaar_ID=" + id;
            command = new OleDbCommand();
            int result = objectdatabase.runcommand(query, command);
            return result;
        }
        public int deleteemployee(string id) //deze methode verwijdert of verwijdert een rij in de werknemerstabel op basis van de werknemers-ID 
        {
            string query = "DELETE FROM werknemer_tabel WHERE werknemer_ID=" + id;
            command = new OleDbCommand();
            int result = objectdatabase.runcommand(query, command);
            return result;
        }
        public int deletereservation(string id)//deze methode verwijdert of verwijdert een rij in de reservationtabel op basis van de reservation-ID 
        {
            int delete = 0;
            string query = "DELETE FROM reservering_tabel WHERE reservering_ID=" + id;
            command = new OleDbCommand();
            int result1 = objectdatabase.runcommand(query, command);
            query = "DELETE fROM extracoins WHERE reservering_ID=" + id;
            command = new OleDbCommand();
            int result2 = objectdatabase.runcommand(query, command);
            if (result1 == 1 && result2 == 1)
            {
                delete = 1;
            }
            return delete;
        }
        public int changemployeedetails(gebruikersmodel user)//deze methode zal de gegevens van de werknemer wijzigen 
        {
            string query = "UPDATE werknemer_tabel SET werknemer_naam='" + user.gebruikersnaam + "' , werknemer_wachtwoord='" + user.wachtwoord + "'  WHERE werknemer_ID=" + user.id;
            command = new OleDbCommand();
            int result = objectdatabase.runcommand(query, command);
            return result;
        }
        public int changownerdetails(gebruikersmodel user)//deze methode zal de gegevens van de eignaar wijzigen 
        {
            string query = "UPDATE eigenaar_tabel SET eigenaar_naam='" + user.gebruikersnaam + "' , eigenaar_wachtwoord='" + user.wachtwoord + "'  WHERE eigenaar_ID=" + user.id;
            command = new OleDbCommand();
            int result = objectdatabase.runcommand(query, command);
            return result;
        }
        public string[] fillfreedate(int index)
        {
            string[] returndate = new string [2];
            string[] departuredate2 = new string[2];
            string[] date1 = new string [2];
            string[] date2 = new string [2]  ;
         //   string date3;
            

                DataTable dt = new DataTable();
                int num = index+1;
            string place = "Plek " + num;
            string query = "select   arrival_date,departure_date from reservering_tabel where reservation_place='" + place + "'";
            objectdatabase.read(query ,dt ); 
          if (dt.Rows.Count == 0 )
          {
              date1[0] = "Deze plek is vrij!";
              date1[1] = "Deze plek is vrij!";
              return date1;
          }
          else if(dt.Rows.Count ==1 )
          {
              date1[0] = dt.Rows[0]["departure_date"].ToString();
              string[] datearray1 = date1[0].Split('-');
              string[] yeararray1 = datearray1[2].Split(' ');
              date1[0] = datearray1[0] +"-"+ datearray1[1]+"-" + yeararray1 [1];
              date1[1] = dt.Rows[0]["arrival_date"].ToString();
              string[] datearray2 = date1[1].Split('-');
              string[] yeararray2 = datearray2[2].Split(' ');
              date1[1] = datearray2[0] + "-"+  datearray2[1]+"-" + yeararray2[1];
              return date1;
          }
          else if (dt.Rows.Count > 1 )
          { 
              date1 [1] = dt.Rows[0]["arrival_date"].ToString();
             date1[0] = dt.Rows[0]["departure_date"].ToString();
             string[]  dates1 = date1[0].Split('-');
             string[] dateyear1 = dates1[2].Split(' ');
             DateTime dateone = new DateTime(Convert.ToInt32  (  dateyear1[0]) , Convert.ToInt32 (dates1[1] ) , Convert.ToInt32 (dates1[0])    );
             date2[0] =dt.Rows[1]["departure_date"].ToString();
              date2[1] = dt.Rows[1]["arrival_date"].ToString();
          //   date3 = dt.Rows[1]["arrival_date"].ToString();
              string[] dates2 = date2[0].Split('-');
              string[] dateyear2 = dates2[2].Split(' ');
             DateTime datetwo = new DateTime(Convert.ToInt32(dateyear2[0]), Convert.ToInt32(dates2[1]), Convert.ToInt32(dates2[0]));
              if (dateone > datetwo)
              {

                  returndate[0] = date1[0];
                  returndate[1] = date1[1];
              }
               else if (dateone < datetwo)
               {
              returndate[0] = date2[0];
                   returndate [1] = date2[1];
               }

              for (int x = 0; x < dt.Rows.Count; x++ )
              {
                  string[] departure1 = returndate[0].Split ('-');
                  string[] departure1year = departure1[2].Split(' ');
                  DateTime firstdate = new DateTime(Convert.ToInt32 (departure1year [0]) , Convert.ToInt32 (departure1 [1]) , Convert.ToInt32 (departure1 [0])    );
                  departuredate2[0]  = dt.Rows[x]["departure_date"].ToString();
                  departuredate2[1] = dt.Rows[x]["arrival_date"].ToString();
                  string[] departure2 = departuredate2[0].Split('-');
                  string[] departure2year = departure2[2].Split(' ');
                  
                  DateTime nextdate = new DateTime(Convert.ToInt32(departure2year[0]), Convert.ToInt32(departure2[1]), Convert.ToInt32(departure2[0]));
              if (nextdate > firstdate )
              {
                  string[] datearray1 = departuredate2[0].Split('-');
                  string[] yeararray1 = datearray1[2].Split(' ');
                  departuredate2[0] = datearray1[0] + "-" + datearray1[1] + "-" + yeararray1[1];

                  string[] datearray2 = departuredate2[1].Split('-');
                  string[] yeararray2 = datearray2[2].Split(' ');
                  departuredate2[1] = datearray2[0] + "-" + datearray2[1] + "-" + yeararray2[1];
                  returndate[0] = departuredate2[0];
                  returndate[1] = departuredate2[1];
              }
                 
              }
              string[] datearray3 = returndate[0].Split('-');
              string[] yeararray3 = datearray3[2].Split(' ');
              returndate[0] = datearray3[0] + "-" + datearray3[1] + "-" + yeararray3[1];

              string[] datearray4 = returndate[1].Split('-');
              string[] yeararray4 = datearray4[2].Split(' ');
              returndate[1] = datearray4[0] + "-" + datearray4[1] + "-" + yeararray4[1];
              return returndate;  
          }
          string[] datearray5 = returndate[0].Split('-');
          string[] yeararray5 = datearray5[2].Split(' ');
          returndate[0] = datearray5[0] + "-" + datearray5[1] + "-" + yeararray5[1];

          string[] datearray6 = returndate[1].Split('-');
          string[] yeararray6 = datearray6[2].Split(' ');
          returndate[1] = datearray6[0] + "-" + datearray6[1] + "-" + yeararray6[1];
          return returndate;  
       
          
    }
        public int calculateduration(string start, string end)//deze methode berekent het verschil tussen twee gegeven datums in dagen 
        {
            int duration = 0;
            string[] startarray = start.Split('-');
            string[] startyear = startarray[2].Split(' ');
            string[] endarray = end.Split('-');
            string[] endyear = endarray[2].Split(' ');
            DateTime startdate = new DateTime(int.Parse(startyear[0]), int.Parse(startarray[1]), int.Parse(startarray[0]));
            DateTime enddate = new DateTime(int.Parse(endyear[0]), int.Parse(endarray[1]), int.Parse(endarray[0]));
            duration = Convert.ToInt32((enddate - startdate).TotalDays);
            return duration;

        }
        public Reservation_model calculate_cost(Reservation_model reservering)//deze methode berekent de kosten van elke munt op basis van hun hoeveelheid en snelheid 
        {
            if (reservering.amount_pet == true)
            {
                reservering.cost_pet = reservering.duration * Reservation_model.pet_rate;
            }
            else
            {
                reservering.cost_pet = 0;
            }
            reservering.cost_adult = reservering.amount_adults * reservering.duration * Reservation_model.adult_rate;
            reservering.cost_kids = reservering.amount_kids * reservering.duration * Reservation_model.kid_rate;
            reservering.cost_cars = reservering.amount_cars * reservering.duration * Reservation_model.Car_rate;
            reservering.cost_visitor = reservering.amount_visitors * reservering.duration * Reservation_model.Visitors_rate;
            reservering.cost_electricity = reservering.amount_electricity * reservering.duration * Reservation_model.Electricity_rate;
            reservering.cost_wash = reservering.amount_washcoins * reservering.duration * Reservation_model.Washcoin_rate;
            reservering.cost_shower = Convert.ToInt32(reservering.amount_showercoins * reservering.duration * Reservation_model.Showercoin_rate);
            reservering.cost_big_caravan = reservering.amount_big_caravan * reservering.duration * Reservation_model.bigCaravan_rate;
            reservering.cost_small_caravan = reservering.amount_small_caravan * reservering.duration * Reservation_model.smallCaravan_rate;
            reservering.cost_small_tent = reservering.amount_small_tent * reservering.duration * Reservation_model.Smalltent_rate;
            reservering.cost_big_tent = reservering.amount_big_tent * reservering.duration * Reservation_model.Bigtent_rate;
            reservering.totalcost = reservering.cost_adult + reservering.cost_kids + reservering.cost_pet + reservering.cost_cars + reservering.cost_electricity + reservering.cost_visitor + reservering.cost_wash + reservering.cost_shower + reservering.cost_big_caravan + reservering.cost_big_tent + reservering.cost_small_caravan + reservering.cost_small_tent;
            return reservering;
        }
        public string getIDoflatestreservation()//deze methode krijgt de ID van de laatst gemaakte reservering 
        {
            string id = "";
            DataTable dtids = new DataTable();
            string query = "select  reservering_ID from reservering_tabel";
            objectdatabase.read(query, dtids);
            for (int x = 0; x < Convert.ToInt32(dtids.Rows.Count); x++)
            {
                id = dtids.Rows[x]["reservering_ID"].ToString();
            }
            return id;

        }
        public int add_coin_details(Reservation_model reservering)//deze methode zal de details van de munten van de geselecteerde reservering opslaan in de extramuntentabel 
        {
            string query = "INSERT INTO extracoins (reservering_ID,Adults,Kids,cars,visitor,showercoins,washcoins,big_caravans,small_caravans,big_tents,small_tents,electricity,pet) VALUES (@reservering.id,@reservering.amount_adults,@reservering.amount_kids,@reservering.amount_cars,@reservering.amount_visitors,@reservering.amount_showercoins,@reservering.amount_washcoins,@reservering.amount_big_caravan,@reservering.amount_small_caravan,@reservering.amount_big_tent,@reservering.amount_small_tent,@reservering.amount_electricity,@reservering.amount_pet)";
            command = new OleDbCommand();
            command.Parameters.AddWithValue("@reservering.id", reservering.id);
            command.Parameters.AddWithValue("@reservering.amount_adults", reservering.amount_adults);
            command.Parameters.AddWithValue("@reservering.amount_kids", reservering.amount_kids);
            command.Parameters.AddWithValue("@reservering.amount_cars", reservering.amount_cars);
            command.Parameters.AddWithValue("@reservering.amount_visitors", reservering.amount_visitors);
            command.Parameters.AddWithValue("@reservering.amount_showercoins", reservering.amount_showercoins);
            command.Parameters.AddWithValue("@reservering.amount_washcoins", reservering.amount_washcoins);
            command.Parameters.AddWithValue("@reservering.amount_big_caravan", reservering.amount_big_caravan);
            command.Parameters.AddWithValue("@reservering.amount_small_caravan", reservering.amount_small_caravan);
            command.Parameters.AddWithValue("@reservering.amount_big_tent", reservering.amount_big_tent);
            command.Parameters.AddWithValue("@reservering.amount_small_tent", reservering.amount_small_tent);
            command.Parameters.AddWithValue("@reservering.amount_electricity", reservering.amount_electricity);
            command.Parameters.AddWithValue("@reservering.amount_pet", reservering.amount_pet);
            int result = objectdatabase.runcommand(query, command);
            return result;
        }
        public void getcoins(Reservation_model reservering, CustomerModel customer)//deze methode krijgt de details van munten van de geselecteerde reservering in de extracoins-tabel 
        {
            DataTable dtcoins = new DataTable();
            string query = "select * from extracoins where reservering_ID=" + reservering.id;
            objectdatabase.read(query, dtcoins);
            DataTable dtreservation = new DataTable();
            query = "select * from reservering_tabel where reservering_ID=" + reservering.id;
            objectdatabase.read(query, dtreservation);
            DataTable dtcustomers = new DataTable();
            string customerid = dtreservation.Rows[0]["klant_ID"].ToString();
            query = "select * from klant_tabel where klant_ID=" + customerid;
            objectdatabase.read(query, dtcustomers);
            if (ReserveringWijzigen.edit == true)
            {
                customer.id = customerid;
                customer.name = dtcustomers.Rows[0]["customer_name"].ToString();
                customer.surname = dtcustomers.Rows[0]["customer_surname"].ToString();
                reservering.amount_adults = Convert.ToInt32(dtcoins.Rows[0]["Adults"]);
                reservering.amount_kids = Convert.ToInt32(dtcoins.Rows[0]["Kids"]);
                reservering.amount_visitors = Convert.ToInt32(dtcoins.Rows[0]["visitor"]);
                reservering.amount_electricity = Convert.ToInt32(dtcoins.Rows[0]["electricity"]);
                reservering.amount_pet = Convert.ToBoolean(dtcoins.Rows[0]["pet"]);
                reservering.amount_showercoins = Convert.ToInt32(dtcoins.Rows[0]["showercoins"]);
                reservering.amount_washcoins = Convert.ToInt32(dtcoins.Rows[0]["washcoins"]);
                reservering.amount_cars = Convert.ToInt32(dtcoins.Rows[0]["cars"]);
                reservering.amount_big_caravan = Convert.ToInt32(dtcoins.Rows[0]["big_caravans"]);
                reservering.amount_small_caravan = Convert.ToInt32(dtcoins.Rows[0]["small_caravans"]);
                reservering.amount_big_tent = Convert.ToInt32(dtcoins.Rows[0]["big_tents"]);
                reservering.amount_small_tent = Convert.ToInt32(dtcoins.Rows[0]["small_tents"]);
                reservering = calculate_cost(reservering);
                ReserveringWijzigen.edit = false;
            }
            else
            {
                customer.id = customerid;
                customer.name = dtcustomers.Rows[0]["customer_name"].ToString();
                customer.surname = dtcustomers.Rows[0]["customer_surname"].ToString();
                reservering.duration = Convert.ToInt32(dtreservation.Rows[0]["duration"]);
                reservering.place = dtreservation.Rows[0]["reservation_place"].ToString();
                reservering.amount_adults = Convert.ToInt32(dtcoins.Rows[0]["Adults"]);
                reservering.amount_kids = Convert.ToInt32(dtcoins.Rows[0]["Kids"]);
                reservering.amount_visitors = Convert.ToInt32(dtcoins.Rows[0]["visitor"]);
                reservering.amount_electricity = Convert.ToInt32(dtcoins.Rows[0]["electricity"]);
                reservering.amount_pet = Convert.ToBoolean(dtcoins.Rows[0]["pet"]);
                reservering.amount_showercoins = Convert.ToInt32(dtcoins.Rows[0]["showercoins"]);
                reservering.amount_washcoins = Convert.ToInt32(dtcoins.Rows[0]["washcoins"]);
                reservering.amount_cars = Convert.ToInt32(dtcoins.Rows[0]["cars"]);
                reservering.amount_big_caravan = Convert.ToInt32(dtcoins.Rows[0]["big_caravans"]);
                reservering.amount_small_caravan = Convert.ToInt32(dtcoins.Rows[0]["small_caravans"]);
                reservering.amount_big_tent = Convert.ToInt32(dtcoins.Rows[0]["big_tents"]);
                reservering.amount_small_tent = Convert.ToInt32(dtcoins.Rows[0]["small_tents"]);
                reservering = calculate_cost(reservering);
            }
        }
      
        public int changereservation(Reservation_model reservering)//deze methode bewerkt de details van de reservering van de geselecteerde reservering in de extracoins-tabel 
        {
            String query = "UPDATE reservering_tabel SET arrival_date=@reservering.startdate,departure_date=@reservering.enddate,cost=@reservering.totalcost,reservation_place=@reservering.place,duration=@reservering.duration WHERE reservering_ID=" + reservering.id;
            command = new OleDbCommand();
            command.Parameters.AddWithValue("@reservering.startdate", reservering.startdate);
            command.Parameters.AddWithValue("@reservering.enddate", reservering.enddate);
            command.Parameters.AddWithValue("@reservering.totalcost", reservering.totalcost);
            command.Parameters.AddWithValue("@reservering.place", reservering.place);
            command.Parameters.AddWithValue("@reservering.duration", reservering.duration);
            int result = objectdatabase.runcommand(query, command);
            query = "UPDATE extracoins SET visitor=@reservering.amount_visitors , showercoins=@reservering.amount_showercoins , washcoins=@reservering.amount_washcoins, electricity=@reservering.amount_electricity , Adults=@reservering.amount_adults, Kids=@reservering.amount_kids , cars=@reservering.amount_cars  , pet=@reservering.amount_pet , big_caravans=@reservering.amount_big_caravan , small_caravans=@reservering.amount_small_caravan , big_tents=@reservering.amount_big_tent , small_tents=@reservering.amount_small_tent WHERE reservering_ID=" + reservering.id;
            command = new OleDbCommand();
            command.Parameters.AddWithValue("@reservering.amount_visitors", reservering.amount_visitors);
            command.Parameters.AddWithValue("@reservering.amount_showercoins", reservering.amount_showercoins);
            command.Parameters.AddWithValue("@reservering.amount_washcoins", reservering.amount_washcoins);
            command.Parameters.AddWithValue("@reservering.amount_electricity", reservering.amount_electricity);
            command.Parameters.AddWithValue("@reservering.amount_adults", reservering.amount_adults);
            command.Parameters.AddWithValue("@reservering.amount_kids", reservering.amount_kids);
            command.Parameters.AddWithValue( "@reservering.amount_cars", reservering.amount_cars  );
            command.Parameters.AddWithValue("@reservering.amount_pet", reservering.amount_pet);
            command.Parameters.AddWithValue("@reservering.amount_big_caravan", reservering.amount_big_caravan  );
            command.Parameters.AddWithValue("@reservering.amount_small_caravan", reservering.amount_small_caravan);
            command.Parameters.AddWithValue("@reservering.amount_big_tent", reservering.amount_big_tent);
            command.Parameters.AddWithValue("@reservering.amount_small_tent", reservering.amount_small_tent);
            result = objectdatabase.runcommand(query, command);
            return result;
        }
        public int calculateTotalrevenue()//deze methode krijgt de totale opbrengst van alle reserveringen 
        {
            int totalcost = 0;
            int cost;
            string query = "select cost from reservering_tabel";
            DataTable dtcosts = new DataTable();
            objectdatabase.read(query, dtcosts);
            int totalrows = dtcosts.Rows.Count;
            for (int x = 0; x < totalrows; x++)
            {
                cost = Convert.ToInt32(dtcosts.Rows[x]["cost"]);
                totalcost = totalcost + cost;
            }
            return totalcost;
        }


        public int create_reservation(Reservation_model reservering, CustomerModel customer)//deze methode slaat de details van de reservering op in de database 
        {
            string query = "INSERT INTO reservering_tabel (klant_ID,arrival_date,departure_date,cost,customer_name,surname,reservation_place,duration) VALUES (@customer.id,@reservering.startdate,@reservering.enddate,@reservering.totalcost,@customer.name,@customer.surname,@reservering.place,@reservering.duration)";
            command = new OleDbCommand();
            command.Parameters.AddWithValue("@customer.id", customer.id);
            command.Parameters.AddWithValue("@reservering.startdate", reservering.startdate);
            command.Parameters.AddWithValue("@reservering.enddate", reservering.enddate);
            command.Parameters.AddWithValue("@reservering.totalcost", reservering.totalcost);
            command.Parameters.AddWithValue("@customer.name", customer.name);
            command.Parameters.AddWithValue("@customer.surname", customer.surname);
            command.Parameters.AddWithValue("@reservering.place", reservering.place);
            command.Parameters.AddWithValue("@reservering.duration", reservering.duration);
            int result = objectdatabase.runcommand(query, command);
            return result;
        }
        public string check_dates(Reservation_model reservering)//deze methode controleert op dubbele reserveringen op de opgegeven data van de geselecteerde plaats 
        {
            bool duplicate = false;
            int x = 0;
            string message = "Datum & plek zijn beschikbaar";
            string[] userarrival = reservering.startdate.Split('-');
            string[] arrivalyearuser = userarrival[2].Split(' ');
            DateTime startdate = new DateTime(int.Parse(arrivalyearuser[0]), int.Parse(userarrival[1]), int.Parse(userarrival[0]));
            string[] userdeparture = reservering.enddate.Split('-');
            string[] departureyearuser = userdeparture[2].Split(' ');
            DateTime enddate = new DateTime(int.Parse(departureyearuser[0]), int.Parse(userdeparture[1]), int.Parse(userdeparture[0]));
            string query = "select * from reservering_tabel where  reservation_place='" + reservering.place + "'";
            DataTable dtdates = new DataTable();
            objectdatabase.read(query, dtdates);
            int totalrows = dtdates.Rows.Count;
            while (x < totalrows && duplicate == false)
            {
                string id = dtdates.Rows[x]["reservering_ID"].ToString ();  
                string startdatedatabase = dtdates.Rows[x]["arrival_date"].ToString();
                string enddatedatabase = dtdates.Rows[x]["departure_date"].ToString();
                string[] databasestart = startdatedatabase.Split('-');
                string[] databasestartyear = databasestart[2].Split(' ');
                DateTime dbstart = new DateTime(int.Parse(databasestartyear[0]), int.Parse(databasestart[1]), int.Parse(databasestart[0]));
                string[] databaseend = enddatedatabase.Split('-');
                string[] databaseendyear = databaseend[2].Split(' ');
                DateTime dbend = new DateTime(int.Parse(databaseendyear[0]), int.Parse(databaseend[1]), int.Parse(databaseend[0]));
                if ((startdate < dbstart) && (enddate < dbstart))
                {
                    message = "Datum & plek zijn beschikbaar";
                }
                else if ((startdate > dbend) && (enddate > dbend))
                {
                    message = "Datum & plek zijn beschikbaar";
                }
                else
                { if (id == reservering.id  )
                 {
                     message = "Datum & plek zijn beschikbaar";
                 }
                else
                 {
                     duplicate = true;
                     message = "Deze plaats is niet beschikbaar tussen " + dbstart + " en " + dbend;
                 } 
                    
                }
                x++;
            }
            return message;
        }
        public DataTable Check_Free_Place(Reservation_model reservering)
        {
             bool found = false ;
            DataTable dtfreeplace = new DataTable();
            dtfreeplace.Columns.Add(new DataColumn("Beschikbare plekken ", typeof(string))); 
            string[] userarrival = reservering.startdate.Split('-');
            string[] arrivalyearuser = userarrival[2].Split(' ');
            DateTime startdate = new DateTime(int.Parse(arrivalyearuser[0]), int.Parse(userarrival[1]), int.Parse(userarrival[0]));
            string[] userdeparture = reservering.enddate.Split('-');
            string[] departureyearuser = userdeparture[2].Split(' ');
            DateTime enddate = new DateTime(int.Parse(departureyearuser[0]), int.Parse(userdeparture[1]), int.Parse(userdeparture[0]));


            for (int x = 1; x <= 100; x++ )
            {
                found = false;
                reservering.place = "Plek " + x; 
                string query = "select * from reservering_tabel where  reservation_place='" + reservering.place + "'";
                DataTable dtplaces = new DataTable();
                objectdatabase.read(query, dtplaces);
                int totalrows = dtplaces.Rows.Count;
                int y =0;
                if (totalrows != 0)
                {


                    while (y < totalrows && found == false)
                    {

                        string startdatedatabase = dtplaces.Rows[y]["arrival_date"].ToString();
                        string enddatedatabase = dtplaces.Rows[y]["departure_date"].ToString();
                        string[] databasestart = startdatedatabase.Split('-');
                        string[] databasestartyear = databasestart[2].Split(' ');
                        DateTime dbstart = new DateTime(int.Parse(databasestartyear[0]), int.Parse(databasestart[1]), int.Parse(databasestart[0]));
                        string[] databaseend = enddatedatabase.Split('-');
                        string[] databaseendyear = databaseend[2].Split(' ');
                        DateTime dbend = new DateTime(int.Parse(databaseendyear[0]), int.Parse(databaseend[1]), int.Parse(databaseend[0]));
                        if (((startdate < dbstart) && (enddate < dbstart)) || ((startdate > dbend) && (enddate > dbend)))
                        {

                            
                            found = false;
                        }
                        else
                        {
                            found = true;
                        }
                        y++;
                    }
                    if (found == false)
                    {
                        DataRow dr = dtfreeplace.NewRow();
                        dr["Beschikbare plekken "] = reservering.place;
                        dtfreeplace.Rows.Add(dr);
                        
                    }

                }
                else
                {
                    DataRow dr = dtfreeplace.NewRow();
                    dr["Beschikbare plekken "] = reservering.place;
                    dtfreeplace.Rows.Add(dr);
                }

            }

            

            return dtfreeplace;
        }
    }

    
}
