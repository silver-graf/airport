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
        public string CityFrom;
        public string CityTo;
        public string Airline;
        public int Terminal;
        public FlightStatus status;
        public override string ToString()
        {
            return $"number:{Number} ";
        }
    }

    class Program
    {

        Flight[] arrivals;
        private static void FlightInit(ref Flight[] f)
        {
            f = new Flight[] { };

        }

        static void Main(string[] args)
        {






            for (;;)
            {

            }
        }
    }
}
