using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport
{
    class Program
    {
        
        public enum FlightStatus
        {
            CheckIn,
            GateClossed,
            Arrived,
            DepartedAt,
            Unknown,
            Canceled,           
            InFlight
        }
        public struct Flight
        {
            public DateTime DocDate;
            public int Number;
            public string City;
            public string Airline;
            public int Terminal;
            public FlightStatus Status;

        }
        

        public static void AirlinesInit(ref Flight [] air )
        {
            air = new Flight[] { }; 




        }
        public static void AirlinesAdd()
        {

        }
        public static void AirlinesDelete()
        {

        }

        private static Flight[] airlines;

        static void Main(string[] args)
        {
            
            AirlinesInit(ref airlines);

            for(;;)
            {

            }
            
            


        }
    }
}
