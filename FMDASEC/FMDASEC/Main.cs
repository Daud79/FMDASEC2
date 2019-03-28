using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMDASEC
{
    public class Main
    {     
        //here we are populating the dummy values that will be sent to the getRecommendation() service
        //the longitude and latitude together give us our location
        double longitude = 55.7782;
        double latitude = 4.1041;

        //the distance variable below is the maximum distance the user is willing to travel (miles)
        int distance = 10;

        //initialising our recommendation object
        Recommendation myRecommendation = new Recommendation();

        //this method will call our "getRecommendation()" service and return three values that are captured in our "Recommendation" object
        public void retrieveRecommendation()
        {
            myRecommendation = myRecommendation.getRecommendation(longitude, latitude, distance);
        }

    }
}
