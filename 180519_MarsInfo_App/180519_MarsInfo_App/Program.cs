using System;
using System.Configuration;

namespace _180519_MarsInfo_App
{
    public class Mars
    {
        public const int SpeedOfLight = 300000;
        public readonly int distancetomars = 0;

        public Mars()
        {
            distancetomars = Convert.ToInt32(ConfigurationManager.AppSettings["DistanceToMars"]);
        }

        public int GetInfoTravelTime()
        {
            return distancetomars / SpeedOfLight;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Mars mars = new Mars();

            Console.WriteLine($"Information travel time us approximately {mars.GetInfoTravelTime()} seconds from Mars to Earth");
        }
    }
}
