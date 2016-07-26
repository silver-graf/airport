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
        static void Main(string[] args)
        {


        }
    }
}
