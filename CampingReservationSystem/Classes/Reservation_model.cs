using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingReservationSystem
{
    public  class Reservation_model
    {//variabelen om de hoeveelheid munten op te slaan 
        public string id;
        public string startdate;
        public string enddate;
        public int  duration;
        public int amount_adults;
        public int amount_kids;
        public bool  amount_pet;
        public int amount_electricity;
        public int amount_visitors;
        public int amount_cars;
        public int amount_showercoins;
        public int amount_washcoins;
        public int amount_small_caravan;
        public int amount_big_caravan;
        public int amount_small_tent;
        public int amount_big_tent;
        public string place;



        //variabelen om het aantal munten op te slaan 
       public static int adult_rate = 5;
       public static int kid_rate = 4;
       public static int pet_rate = 2;
       public static int Electricity_rate = 2;
       public static int Visitors_rate = 2;
       public static double Showercoin_rate = 0.5;
       public static int Washcoin_rate = 4;
       public static int smallCaravan_rate = 2;
       public static int bigCaravan_rate = 4;
       public static int Smalltent_rate = 3;
       public static int Bigtent_rate = 5;
       public static int Car_rate = 3;

       //variabelen om de kosten van munten op te slaan voor de huidige reservering 
       public int cost_adult;
       public int cost_kids;
       public int cost_pet;
       public int cost_electricity;
       public int cost_visitor;
       public int cost_shower;
       public int cost_wash;
       public int cost_cars;
       public int cost_big_caravan;
       public int cost_big_tent;
       public int cost_small_caravan;
       public int cost_small_tent;
       public int totalcost;
    }
}
