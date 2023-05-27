using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.BL;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ship> TotalShip = new List<Ship>();
            Ship inputShip = new Ship();
            Angle longitude = new Angle();
            Angle latitude = new Angle();

            int option = Menu();
            while (option != 5)
            {
                if(option == 1)
                {
                    inputShip = AddShip();
                    TotalShip.Add(inputShip);
                    option = Menu();
                }
                else if(option == 2)
                {
                    Console.WriteLine("Enter serial number of ship");
                    string serial = Console.ReadLine();
                    longitude = inputShip.GetLongitude(TotalShip, serial);
                    Console.WriteLine("In longitude");
                    Console.WriteLine(longitude.degree + "\u00b0" + longitude.minute + "'" + longitude.direction);
                    latitude = inputShip.GetLatitude(TotalShip, serial);
                    Console.WriteLine("In Latitude");
                    Console.WriteLine(latitude.degree + "\u00b0" + latitude.minute + "'" + latitude.direction);
                    Console.ReadKey();
                    option = Menu();
                }
                else if(option == 3)
                {
                    Ship ship1 = new Ship();
                    ship1 = EnterDataToFindShip();
                    string num = ship1.GetSerialNumber(TotalShip, ship1);
                    Console.WriteLine(num);
                    Console.ReadKey();
                    option = Menu();
                }
                else if(option == 4)
                {
                  
                    Ship ship2 = EnterDataToUpdate();
                    UpdateShipList(ship2, TotalShip);
                   
              
                    Console.ReadKey();
                    option = Menu();

                }
            }
          

          
           
           
           
           

         
            Console.ReadKey();
        }
        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("Please choose an action:");
            Console.WriteLine("1. Add Ship");
            Console.WriteLine("2. View Ship Position");
            Console.WriteLine("3. View Ship Serial Number");
            Console.WriteLine("4. Change Ship Position");
            Console.WriteLine("5. Exit");
            int input = int.Parse(Console.ReadLine());
            return input;
        }
        static Ship AddShip()
        {
            Ship inputShip = new Ship();
            Console.WriteLine("Enter ship serial number: ");
            inputShip.serial = Console.ReadLine();
            Console.WriteLine("Enter ship longitude: ");
            Console.WriteLine("Enter degree: ");
            inputShip.longitude.degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes: ");
            inputShip.longitude.minute = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  longitude direction: ");
            inputShip.longitude.direction = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter ship latitude: ");
            Console.WriteLine("Enter degree: ");
            inputShip.latitude.degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes: ");
            inputShip.latitude.minute = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude's direction: ");
            inputShip.latitude.direction = char.Parse(Console.ReadLine());

            return inputShip;
        }
        static Ship EnterDataToFindShip()
        {
            Ship inputShip = new Ship();
            Console.WriteLine("Enter ship longitude: ");
            Console.WriteLine("Enter degree: ");
            inputShip.longitude.degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes: ");
            inputShip.longitude.minute = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  longitude direction: ");
            inputShip.longitude.direction = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter ship latitude: ");
            Console.WriteLine("Enter degree: ");
            inputShip.latitude.degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes: ");
            inputShip.latitude.minute = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude's direction: ");
            inputShip.latitude.direction = char.Parse(Console.ReadLine());
            return inputShip;
        }
        static Ship EnterDataToUpdate()
        {
            Ship inputShip = new Ship();
            Console.WriteLine("Enter ship serial number to update the locations: ");
            inputShip.serial = Console.ReadLine();
            Console.WriteLine("Enter updated longitude: ");
            Console.WriteLine("Enter degree: ");
            inputShip.longitude.degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes: ");
            inputShip.longitude.minute = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  longitude direction: ");
            inputShip.longitude.direction = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter updated latitude: ");
            Console.WriteLine("Enter degree: ");
            inputShip.latitude.degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minutes: ");
            inputShip.latitude.minute = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude's direction: ");
            inputShip.latitude.direction = char.Parse(Console.ReadLine());
            return inputShip;
        }
        static void UpdateShipList(Ship s, List<Ship> TotalShip)
        {
            foreach (Ship x in TotalShip)
            {
                if (s.serial == x.serial)
                {
                    x.longitude.degree = s.longitude.degree;
                    x.latitude.minute = s.longitude.minute;
                    x.latitude.direction = s.latitude.direction;
                    x.longitude.direction = s.longitude.direction;
                    x.latitude.degree = s.latitude.degree;
                    x.latitude.minute = s.latitude.minute;
                    Console.WriteLine("Ship location updated");
                }
            }
        }
    }
}
