using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using System.Data.OleDb;
namespace CampingReservationSystem
{
    class Database
    {
        public   OleDbConnection connection = new OleDbConnection();

        public Database()
        {

            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\camping_database.accdb;Persist Security Info=False;";

        }


        public int runcommand(string query, OleDbCommand command)//deze methode zal gegevens in de database verwijderen, bijwerken of invoegen 
        {   int output = 0; 
            try
            {
                connection.Open();
               
                command.Connection = connection;
                command.CommandText = query ;
                output =  command.ExecuteNonQuery();

            }
            catch (Exception   ex)
            {
                ErrorMessage = ex.Message;
            }
            finally
            {
                connection.Close();
            }
            return output; 
        }
        
        public string ErrorMessage { get; set; }

        public DataTable read(string query, DataTable dt) // deze methode leest gegevens in de database 
        {
            try
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                connection.Open();
                adapter.Fill(dt);
               
               
            }
            catch (OleDbException ex)
            {
                ErrorMessage = ex.Message;  
            }
            finally
            {
                connection.Close(); 
            }
            return dt;
        }

    }
}
