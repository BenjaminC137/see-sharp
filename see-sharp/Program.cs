using System;
using System.Linq;

namespace see_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            GPS a = new GPS(2,9,DateTime.Now);
            
            Console.WriteLine("Latitude = {0} \nLongitude = {1}", a.Latitude, a.Longitude);
            
        }
        
        //public GPS DisplayInfo(string coord){
        //return true;
        //}
    }
    
   public class GPS
    {
        public int      Latitude    { get; set; }
        public int      Longitude   { get; set; }
        public DateTime Time        { get; set; }
        
        public GPS(int latitude, int longitude, DateTime time)
        {
            Latitude = latitude;
            Longitude = longitude;
            Time = time;
        }
        
        
    }
}


//Dredges use a GPS Device for navigation which sends out strings that are useful for our positioning programs, one of which is a NMEA GGA string.
//A NMEAA GGA string contains various information such as time, latitude, longitude, altitude
//The challenge is to write a code using C# that can parse a string input and be able to output the data (time, latitude, longitude, etc.)