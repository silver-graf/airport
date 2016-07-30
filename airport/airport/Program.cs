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
        public DateTime TimeStart;
        public DateTime TimeEnd;
        public int Number;
        public string flight;
        public string CityFrom;
        public string CityTo;
        public string Airline;
        public int Terminal;
        public FlightStatus status;
        public override string ToString()
        {
            return $"number:{Number} | CityFrom: {CityFrom} | CityTo: {CityTo} | TimeStart: {TimeStart} | TimeEnd: {TimeEnd} | Terminal: {Terminal} | status: {status} | flight: {flight} | Airline: {Airline}";
        }
    }

    class Program
    {

        static Flight[] arrivals;

        private static void FlightInit(ref Flight[] f)
        {
            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            f = new Flight[10];
            f[0].Airline = "Atlasglobal Ukraine";
            f[0].CityFrom = "bahdad";
            f[0].CityTo = "kharkiv";
            f[0].TimeStart = DateTime.Now;
            f[0].TimeEnd = f[0].TimeStart.AddHours(7);
            f[0].flight = "UF 4201";
            f[0].status = FlightStatus.CheckIn;
            f[0].Number = 0;
            f[0].Terminal = 2;

            f[1].Airline = "Atlasglobal Ukraine";
            f[1].CityFrom = "kharkiv";
            f[1].CityTo = "Amsterdam";
            f[1].TimeStart = date.AddHours(7);
            f[1].TimeEnd = f[1].TimeStart.AddHours(5);
            f[1].flight = "U 20213";
            f[1].status = FlightStatus.CheckIn;
            f[1].Number = 1;
            f[1].Terminal = 1;

            f[2].Airline = "Atlasglobal Ukraine";
            f[2].CityFrom = "kharkiv";
            f[2].CityTo = "Antalia";
            f[2].TimeStart = DateTime.Now; ;
            f[2].TimeEnd = f[2].TimeStart.AddHours(7);
            f[2].flight = "U 2053";
            f[2].status = FlightStatus.DepartedAt;
            f[2].Number = 2;
            f[2].Terminal = 1;

            f[3].Airline = "Atlasglobal Ukraine";
            f[3].CityFrom = "kharkiv";
            f[3].CityTo = "Lviv";
            f[3].TimeStart = date.AddHours(5);
            f[3].TimeEnd = f[3].TimeStart.AddHours(7);
            f[3].flight = "U 2613";
            f[3].status = FlightStatus.CheckIn;
            f[3].Number = 3;
            f[3].Terminal = 2;

            f[4].Airline = "UmAir";
            f[4].CityFrom = "Lviv";
            f[4].CityTo = "Minsk";
            f[4].TimeStart = date.AddHours(-2);
            f[4].TimeEnd = f[4].TimeStart.AddHours(-7);
            f[4].flight = "U 7213";
            f[4].status = FlightStatus.Arrived;
            f[4].Number = 4;
            f[4].Terminal = 3;

            f[5].Airline = "UmAir";
            f[5].CityFrom = "Kyiv";
            f[5].CityTo = "Stambul";
            f[5].TimeStart = date.AddHours(-1);
            f[5].TimeEnd = f[5].TimeStart.AddHours(-8);
            f[5].flight = "U 2813";
            f[5].status = FlightStatus.Arrived;
            f[5].Number = 5;
            f[5].Terminal = 1;

            f[6].Airline = "UIA";
            f[6].CityFrom = "kharkiv";
            f[6].CityTo = "Kyiv";
            f[6].TimeStart = date.AddHours(1);
            f[6].TimeEnd = f[6].TimeStart.AddHours(7);
            f[6].flight = "U 2003";
            f[6].status = FlightStatus.CheckIn;
            f[6].Number = 6;
            f[6].Terminal = 2;

            f[7].Airline = "UIA";
            f[7].CityFrom = "kharkiv";
            f[7].CityTo = "Beirut";
            f[7].TimeStart = date.AddHours(-6);
            f[7].TimeEnd = f[7].TimeStart.AddHours(7);
            f[7].flight = "UG 23";
            f[7].status = FlightStatus.InFlight;
            f[7].Number = 7;
            f[7].Terminal = 4;

            f[8].Airline = "Bravo Airways";
            f[8].CityFrom = "Kyiv";
            f[8].CityTo = "Milan";
            f[8].TimeStart = date.AddHours(2);
            f[8].TimeEnd = f[8].TimeStart.AddHours(7);
            f[8].flight = "E 20";
            f[8].status = FlightStatus.CheckIn;
            f[8].Number = 8;
            f[8].Terminal = 3;

            f[9].Airline = "Bravo Airways";
            f[9].CityFrom = "Izmir";
            f[9].CityTo = "kharkiv";
            f[9].TimeStart = DateTime.MinValue;
            f[9].TimeEnd = f[9].TimeStart;
            f[9].flight = "T 4553";
            f[9].status = FlightStatus.Canceled;
            f[9].Number = 9;
            f[9].Terminal = 5;

        }

        public static void PrintFlyght(Flight[] flyght)
        {
            foreach (Flight f in flyght)
            {
                Console.WriteLine(f.ToString());
                Console.WriteLine("--------------------------");
            }
        }
        static void InputFlyght()
        {
            Flight[] f = new Flight[arrivals.Length + 1];
            Flight newfly;
            Console.WriteLine("enter airlines");
            newfly.Airline = Console.ReadLine();
            Console.WriteLine("enter City From air bus heading off");
            newfly.CityFrom = Console.ReadLine();
            Console.WriteLine("enter the city, where the air is directed");
            newfly.CityTo = Console.ReadLine();
            Console.WriteLine("enter flight");
            newfly.flight = Console.ReadLine();
            Console.WriteLine(@"enter the status:
1) CheckIn ,
2) GateClossed,
3) Arrived,
4) DepartedAt,
5) Unknown,
6) Canceled,
7) InFlight
                ");
            newfly.status = (FlightStatus)int.Parse(Console.ReadLine());
            Console.WriteLine("enter the Terminal");
            newfly.Terminal = int.Parse(Console.ReadLine());
            Console.WriteLine("enter data and time start (format  dd/mm/yyyy hh:mm:ss)");
            newfly.TimeStart = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("enter Time End of flyght");
            newfly.TimeEnd = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("enter number");
            bool flag = false;
            int number =-1;
            
            for (;;)
            {
                if (flag == false)
                {
                    number = int.Parse(Console.ReadLine());
                }
                
                foreach (Flight fl in arrivals)
                {

                    if (fl.Number == number )
                    {
                        flag = true;
                        Console.WriteLine("enter uniq number");
                        break;
                    }

                }
                if (flag)
                {
                    break;
                }
                

            }
            //newfly.Number = int.Parse(Console.ReadLine());
            f[f.Length - 1] = newfly;
            arrivals = f;
            PrintFlyght(arrivals);
        }
        public static void DeleteFlyght(int number)
        {

            if (number < arrivals.Length)
            {

                Console.WriteLine($"are you sure want delete y/n");
                ConsoleKeyInfo cki = Console.ReadKey();
                if (cki.ToString() == "y")
                {
                    int y = 0;
                    Flight[] temp = new Flight[arrivals.Length - 1];
                    for (int i = 0; i < arrivals.Length; i++)
                    {
                        if (arrivals[i].Number != number)
                        {
                            temp[y] = arrivals[i];
                            y++;
                        }

                    }
                }
            }
            PrintFlyght(arrivals);

        }

        private static void EditFlyght(int edit)
        {
            bool flag = true;
            for (int i = 0; i < arrivals.Length; i++)
            {
                if (arrivals[i].Number == edit)
                {
                    flag = false;

                    Console.WriteLine($"enter airlines old {arrivals[i].Airline}");
                    arrivals[i].Airline = Console.ReadLine();
                    Console.WriteLine($"enter City From air bus heading off old {arrivals[i].CityFrom}");
                    arrivals[i].CityFrom = Console.ReadLine();
                    Console.WriteLine($"enter the city, where the air is directed old {arrivals[i].CityTo}");
                    arrivals[i].CityTo = Console.ReadLine();
                    Console.WriteLine($"enter flight old { arrivals[i].flight}");
                    arrivals[i].flight = Console.ReadLine();
                    Console.WriteLine(@"enter the status:
1) CheckIn ,
2) GateClossed,
3) Arrived,
4) DepartedAt,
5) Unknown,
6) Canceled,
7) InFlight
                ");
                    arrivals[i].status = (FlightStatus)int.Parse(Console.ReadLine());
                    Console.WriteLine($"enter the Terminal old {arrivals[i].Terminal}");
                    arrivals[i].Terminal = int.Parse(Console.ReadLine());
                    Console.WriteLine($"enter data and time start (format  dd/mm/yyyy hh:mm:ss) old {arrivals[i].TimeStart}");
                    arrivals[i].TimeStart = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine($"enter Time End of flyght old {arrivals[i].TimeEnd}");
                    arrivals[i].TimeEnd = DateTime.Parse(Console.ReadLine());
                }
            }
            if (flag)
            {
                Console.WriteLine("wrong number");
            }
            PrintFlyght(arrivals);
        }

        private static void SearchFlyght()
        {
            Console.WriteLine(@"Please choose one of the following menu items:
                1. Search by number;
                2. Search by time of arrival/departure;                
                3. Search by city start;
                4. Search by city end;   
                5. Search all flights in this hour;");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case (1):
                    Console.WriteLine("enter number");
                    int num = int.Parse(Console.ReadLine());
                    for (int i = 0; i < arrivals.Length; i++)
                    {
                        if (arrivals[i].Number == num)
                        {
                            Console.WriteLine(arrivals[i].ToString());
                        }
                    }
                            break;
                case (2):
                    Console.WriteLine("enter start time to find ");
                    DateTime start = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("enter end time to find ");
                    DateTime end = DateTime.Parse(Console.ReadLine());
                    for (int i = 0; i < arrivals.Length; i++)
                    {
                        if (arrivals[i].TimeStart == start || arrivals[i].TimeEnd == end )
                        {
                            Console.WriteLine(arrivals[i].ToString());
                        }
                    }
                    break;
                case (3):
                    Console.WriteLine("enter city start");
                    string cityStart =(Console.ReadLine());
                    for (int i = 0; i < arrivals.Length; i++)
                    {
                        if (arrivals[i].CityFrom == cityStart)
                        {
                            Console.WriteLine(arrivals[i].ToString());
                        }
                    }
                    break;
                case (4):
                    Console.WriteLine("enter city start");
                    string cityEnd = (Console.ReadLine());
                    for (int i = 0; i < arrivals.Length; i++)
                    {
                        if (arrivals[i].CityTo == cityEnd)
                        {
                            Console.WriteLine(arrivals[i].ToString());
                        }
                    }
                    break;
                case (5):

                    DateTime date = DateTime.Now;           
                    
                    for (int i = 0; i < arrivals.Length; i++)
                    {
                        if ( (date -  arrivals[i].TimeEnd).Hours < 1 || (date - arrivals[i].TimeStart).Hours < 1  )
                        {
                            Console.WriteLine(arrivals[i].ToString());
                        }
                    }
                    break;

            }


        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.SetWindowPosition(Console.WindowLeft, 0);
            Console.SetWindowSize(Console.LargestWindowWidth, Console.WindowHeight);
            Console.WriteLine("AIRPORT");
            Console.ResetColor();
            FlightInit(ref arrivals);            
            int choice;




            for (;;)
            {
                Console.WriteLine(@"Select, what you want to do:
1) print information
2) input flyght
3) edit flyght
4) delete flyght
5) search flyght
5) exit ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case (1):
                        PrintFlyght(arrivals);
                        break;
                    case (2):
                        InputFlyght();
                        break;
                    case (3):

                        Console.WriteLine("enter the number, what flyght are you want editing");
                        int edit = int.Parse(Console.ReadLine());
                        EditFlyght(edit);
                        break;
                    case (4):
                        Console.WriteLine("enter the number, what flyght are you want delete");
                        int del = int.Parse(Console.ReadLine());
                        DeleteFlyght(del);
                        break;
                    case (5):
                        SearchFlyght();
                        break;

                    case (6):
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }

                Console.ReadLine();

            }

        }


    }
}
