using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport
{
    class Program
    {
       public enum flightstatus
        {
            checkIn,
            gateClosed,
            arrived,
            departedAt,
            unknown,
            canceled
        }
        public struct flight
        {
            public DateTime docDate;
            public int number;
            public string city;
            public string airline;
            public int terminal;
            public flightstatus status;
        }

        static void Main(string[] args)
        {

            flight[] fl = new flight[5];
            fl[0].airline = "МАУ";
            

            


            for (;;)
            {

            }
        }
    }
}
