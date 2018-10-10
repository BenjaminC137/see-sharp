using System;
using System.Linq;

namespace see_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
        
            GPS point = new GPS("$GPGGA,123519,4807.038,N,01131.000,E,1,08,0.9,545.4,M,46.9,M,,*47");
            //GPS point = DisplayInfo("alsdkfjalk");
            
            //GPS point = new GPS(2,9,DateTime.Now);
            Console.WriteLine("Latitude = {0} \nLongitude = {1} \nTime = {2}", point.Latitude, point.Longitude, point.Time);            
        }
  
    }
    
   public class GPS
    {
        public decimal  Latitude    { get; set; }
        public decimal  Longitude   { get; set; }
        public string   Time        { get; set; }
        
        //public GPS(int latitude, int longitude, DateTime time)
        //{
        //    Latitude = latitude;
        //    Longitude = longitude;
        //    Time = time;
        //}
        
        public GPS(string coord)
        {
            string[] NMEA = coord.Split(',');
            decimal pLatitude = Convert.ToDecimal(NMEA[2]); 
            decimal pLongitude = Convert.ToDecimal(NMEA[4]);          
            string time = NMEA[1];
            string hh = time.Substring(0,2);
            string mm = time.Substring(2,2);
            string ss = time.Substring(4,2);
            string formattedTime = String.Format("{0}:{1}:{2}", hh, mm, ss);
            //Console.WriteLine(formattedTime);
            //DateTime pDateAndTime = DateTime.Parse(formattedTime);
            //DateTime pTime = pDateAndTime;
            Latitude = pLatitude;
            Longitude = pLongitude;
            Time = formattedTime;
            //GPS p = new GPS(pLatitude, pLongitude, pTime);
            
            //return p;
        //public GPS DisplayInfo(string coord){ 
        }
        
        
    }
}


//Dredges use a GPS Device for navigation which sends out strings that are useful for our positioning programs, one of which is a NMEA GGA string.
//A NMEAA GGA string contains various information such as time, latitude, longitude, altitude
//The challenge is to write a code using C# that can parse a string input and be able to output the data (time, latitude, longitude, etc.)