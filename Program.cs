using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_1
{

    class ship
    {
        protected string name, destination, fuel_type;
        protected double displacement, engine_power;
    }
    class aircraft_carrier : ship
    {
        string aircraft;
        int aircraft_quantity;
        aircraft_carrier[] AC = new aircraft_carrier[10];

        public void input(int i)
        {
            Console.WriteLine("Enter 1 - name, 2 - destination, 3- fuel_type, 4 - displacement, 5 - engine_power, 6 - aircraft, 7 - aircraft_quantity");
            AC[i].name = Console.ReadLine();
            AC[i].destination = Console.ReadLine();
            AC[i].fuel_type = Console.ReadLine();
            AC[i].displacement = Convert.ToDouble(Console.ReadLine());
            AC[i].engine_power = Convert.ToDouble(Console.ReadLine());
            AC[i].aircraft = Console.ReadLine();
            AC[i].aircraft_quantity = Convert.ToInt32(Console.ReadLine());
        }
        public void info(int i)
        {
            Console.WriteLine("Enter property you want to get (name or destination or fuel_type or displacement or engine_power or aircraft or aircraft_quantity");
            string property = Console.ReadLine();
            switch (property)
            {
                case "name":
                    Console.WriteLine("{0}", AC[i].name); break;
                case "destination":
                    Console.WriteLine("{0}", AC[i].destination); break;
                case "fuel_type":
                    Console.WriteLine("{0}", AC[i].fuel_type); break;
                case "displacement":
                    Console.WriteLine("{0}", AC[i].displacement); break;
                case "engine_power":
                    Console.WriteLine("{0}", AC[i].engine_power); break;
                case "aircraft":
                    Console.WriteLine("{0}", AC[i].aircraft); break;
                case "aircraft_quantity":
                    Console.WriteLine("{0}", AC[i].aircraft_quantity); break;
                default: Console.WriteLine("Default case"); break;
            }
        }
    }
    class rocket_launcher : ship
    {
        string rockets;
        int rockets_quantity;
        rocket_launcher[] RL = new rocket_launcher[10];
        
        public void input(int i)
        {
            Console.WriteLine("Enter 1 - name, 2 - destination, 3- fuel_type, 4 - displacement, 5 - engine_power, 6 - rockets, 7 - rockets_quantity");
            RL[i].name = Console.ReadLine();
            RL[i].destination = Console.ReadLine();
            RL[i].fuel_type = Console.ReadLine();
            RL[i].displacement = Convert.ToDouble(Console.ReadLine());
            RL[i].engine_power = Convert.ToDouble(Console.ReadLine());
            RL[i].rockets = Console.ReadLine();
            RL[i].rockets_quantity = Convert.ToInt32(Console.ReadLine());
        }
        public void info(int i)
        {
            Console.WriteLine("Enter property you want to get (name or destination or fuel_type or displacement or engine_power or aircraft or aircraft_quantity");
            string property = Console.ReadLine();
            switch (property)
            {
                case "name":
                    Console.WriteLine("{0}", RL[i].name); break;
                case "destination":
                    Console.WriteLine("{0}", RL[i].destination); break;
                case "fuel_type":
                    Console.WriteLine("{0}", RL[i].fuel_type); break;
                case "displacement":
                    Console.WriteLine("{0}", RL[i].displacement); break;
                case "engine_power":
                    Console.WriteLine("{0}", RL[i].engine_power); break;
                case "rockets":
                    Console.WriteLine("{0}", RL[i].rockets); break;
                case "rockets_quantity":
                    Console.WriteLine("{0}", RL[i].rockets_quantity); break;
                default: Console.WriteLine("Default case"); break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'S' to start");
            string ch = Console.ReadLine();
            while (ch != "")
            {
                int escape = 0;
                Console.WriteLine("Choose input_rocket_launcher or input_aircraft_carrier or get_rocket_launcher or get_aircraft_carrier or break");
                ch = Console.ReadLine();
                int nRL = 0; int nAC = 0;
                switch (ch)
                {
                    case "input_rocket_launcher":
                        rocket_launcher RL1 = new rocket_launcher();
                        RL1.input(nRL);
                        nRL++; break;
                    case "input_aircraft_carrier":
                        aircraft_carrier AC1 = new aircraft_carrier();
                        AC1.input(nAC);
                        nAC++; break;
                    case "get_rocket_launcher":
                        Console.WriteLine("Enter number 0-9");
                        int indexRL = Convert.ToInt32(Console.ReadLine());
                        rocket_launcher RL2 = new rocket_launcher();
                        RL2.info(indexRL); break;
                    case "get_aircraft_carrier":
                        Console.WriteLine("Enter number 0-9");
                        int indexAC = Convert.ToInt32(Console.ReadLine());
                        aircraft_carrier AC2 = new aircraft_carrier();
                        AC2.info(indexAC); break;
                    case "break":
                        escape++; break;
                    default: Console.WriteLine("Default case"); break;
                }
                if (escape > 0) break;
            }
        }
    }
}
