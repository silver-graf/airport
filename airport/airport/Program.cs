using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport
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
        public DateTime docDate;
        public int Number;
        public string flight;
        public string CityFrom;
        public string CityTo;
        public string Airline;
        public int Terminal;
        public FlightStatus status;
        public override string ToString()
        {
            return $"number:{Number} CityFrom: {CityFrom} CityTo {CityTo} docDate: {docDate} Terminal: {Terminal} status: {status} flight: {flight} Airline: {Airline}";
        }
    }

    class Program
    {

        static Flight[] arrivals;

        private static void FlightInit(ref Flight[] f)
        {
            f = new Flight[10] ;
            f[0].Airline = "Atlasglobal Ukraine";
            f[0].CityFrom = "bahdad";
            f[0].CityTo = "kharkiv";
            f[0].docDate = DateTime.Now; //Convert.ToDateTime( "29.07.2016");
            f[0].flight = "UF 4201";
            f[0].status = FlightStatus.CheckIn;
            f[0].Number = 0;
            f[0].Terminal = 2;

            f[1].Airline = "Atlasglobal Ukraine";
            f[1].CityFrom = "kharkiv";
            f[1].CityTo = "Amsterdam";
            f[1].docDate = Convert.ToDateTime("29.07.2016");
            f[1].flight = "U 20213";
            f[1].status = FlightStatus.Arrived;
            f[1].Number = 1;
            f[1].Terminal = 1;

            f[2].Airline = "Atlasglobal Ukraine";
            f[2].CityFrom = "kharkiv";
            f[2].CityTo = "Antalia";
            f[2].docDate = Convert.ToDateTime("29.07.2016");
            f[2].flight = "U 2053";
            f[2].status = FlightStatus.Arrived;
            f[2].Number = 2;
            f[2].Terminal = 1;

            f[3].Airline = "Atlasglobal Ukraine";
            f[3].CityFrom = "kharkiv";
            f[3].CityTo = "Lviv";
            f[3].docDate = Convert.ToDateTime("29.07.2016");
            f[3].flight = "U 2613";
            f[3].status = FlightStatus.Arrived;
            f[3].Number = 3;
            f[3].Terminal = 2;

            f[4].Airline = "UmAir";
            f[4].CityFrom = "Lviv";
            f[4].CityTo = "Minsk";
            f[4].docDate = Convert.ToDateTime("29.07.2016");
            f[4].flight = "U 7213";
            f[4].status = FlightStatus.Arrived;
            f[4].Number = 4;
            f[4].Terminal = 3;

            f[5].Airline = "UmAir";
            f[5].CityFrom = "Kyiv";
            f[5].CityTo = "Stambul";
            f[5].docDate = Convert.ToDateTime("29.07.2016");
            f[5].flight = "U 2813";
            f[5].status = FlightStatus.Arrived;
            f[5].Number = 5;
            f[5].Terminal = 1;

            f[6].Airline = "UIA";
            f[6].CityFrom = "kharkiv";
            f[6].CityTo = "Kyiv";
            f[6].docDate = Convert.ToDateTime("29.07.2016");
            f[6].flight = "U 2003";
            f[6].status = FlightStatus.Arrived;
            f[6].Number = 6;
            f[6].Terminal = 2;
        
            f[7].Airline = "UIA";
            f[7].CityFrom = "kharkiv";
            f[7].CityTo = "Beirut";
            f[7].docDate = Convert.ToDateTime("29.07.2016");
            f[7].flight = "UG 23";
            f[7].status = FlightStatus.Arrived;
            f[7].Number = 7;
            f[7].Terminal = 4;

            f[8].Airline = "Bravo Airways";
            f[8].CityFrom = "Kyiv";
            f[8].CityTo = "Milan";
            f[8].docDate = Convert.ToDateTime("29.07.2016");
            f[8].flight = "E 20";
            f[8].status = FlightStatus.Arrived;
            f[8].Number = 8;
            f[8].Terminal = 3;
        
            f[9].Airline = "Bravo Airways";
            f[9].CityFrom = "Izmir";
            f[9].CityTo = "kharkiv";
            f[9].docDate = Convert.ToDateTime("29.07.2016");
            f[9].flight = "T 4553";
            f[9].status = FlightStatus.Arrived;
            f[9].Number = 9;
            f[9].Terminal = 5;

        }

        static void Main(string[] args)
        {
            FlightInit(ref arrivals);





            //for (;;)
            //{

            //}

        }
    }
}
