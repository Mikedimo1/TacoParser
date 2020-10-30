using System;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                logger.LogError("item legnth is less than 3", new System.Exception());
                // Log that and return null
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0
            var lat = cells[0];
            // grab the longitude from your array at index 1
            var lon = cells[1];
            // grab the name from your array at index 2
            var name = cells[2];

            // Your going to need to parse your string as a `double`
            var doubleLat = double.Parse(lat);
            var doubleLon = double.Parse(lon);
            //which is similar to parsing a string as an `int`

            // You'll need to create a TacoBell class - DONE
            // that conforms to ITrackable - DONE

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            TacoBell tacobell = new TacoBell();
            
            tacobell.Name = name;
            
            var point = new Point();
            
            point.Latitude = doubleLat;
            point.Longitude = doubleLon;
            
            tacobell.Location = point;
            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable
            tacobell.Name = name;
            
            return tacobell;
        }
    }
}