using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.BL
{
    class Ship
    {
        public string serial;
       //location
        public Angle longitude = new Angle();
        public Angle latitude = new Angle();
      
     
        public Angle GetLongitude(List<Ship> totalShip, string serial)
        {
            foreach(Ship x in totalShip)
            {
                if(x.serial == serial)
                {
                    return x.longitude;
                }
            }
            return null;
        }
        public Angle GetLatitude(List<Ship> TotalShip, string serial)
        {
            foreach (Ship x in TotalShip)
            {
                if (x.serial == serial)
                {
                    return x.latitude;
                }
            }
            return null;
        }
        public string GetSerialNumber(List<Ship> TotalShip,Ship p)
        {
            Console.WriteLine(TotalShip.Count);
            foreach(Ship x in TotalShip)
            {
                if(p.latitude.degree == x.latitude.degree && p.latitude.minute == x.latitude.minute && p.latitude.direction == x.latitude.direction && p.longitude.degree == x.longitude.degree && p.longitude.minute == x.longitude.minute && p.longitude.direction == x.longitude.direction)
                {
                    Console.WriteLine("serial: " + x.serial);
                    return x.serial;
                }
            }
            return null;
        }

    }
}
