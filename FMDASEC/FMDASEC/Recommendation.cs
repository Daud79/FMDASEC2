using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMDASEC
{  
    public class Recommendation
    {
        #region private attributes
        private string recommendationName;
        private string recommendationLocation;
        private double recommendationWaitTime;
        #endregion

        #region getters and setters
        public string getRecommendationName() { return recommendationName; }
        public void setRecommendationName(string recommendationName) { this.recommendationName = recommendationName; }

        public string getRecommendationLocation() { return recommendationLocation; }
        public void setRecommendationLocation(string recommendationLocation) { this.recommendationLocation = recommendationLocation; }

        public double getRecommendationWaitTime() { return recommendationWaitTime; }
        public void setRecommendationWaitTime(double recommendationWaitTime) { this.recommendationWaitTime = recommendationWaitTime; }
        #endregion

        #region constructors
        public Recommendation() 
        {
            //default constructor
        }
        #endregion

        #region methods
        public Recommendation getRecommendation(double longitude, double latitude, int distance)
        {
            //hardcoded values randomly selected as there is no 3rd party service
            Recommendation newRecommendation = new Recommendation();
            newRecommendation.setRecommendationName(generateRecommendationName());
            newRecommendation.setRecommendationLocation(findRecommendationLocation(newRecommendation.getRecommendationName()));

            //wait time is in minutes
            newRecommendation.setRecommendationWaitTime(calculateWaitTime(newRecommendation.getRecommendationLocation()));

            //populated recommendation is returned
            return newRecommendation;
        }


        public string generateRecommendationName()
        {
            string[] recommendationNames = { "Via Italia", "Pizza Hut", "Dominos", "Burger King", "McDonalds", "Bar Americano", "La Cocina de Pedro" };

            Random r = new Random();
            int index = r.Next(recommendationNames.Length);
            Recommendation newRecommendation = new Recommendation();
            string recommendation = recommendationNames[index];
            return recommendation;
        }

        public string findRecommendationLocation(string recommendedName)
        { 
            string recommendedLocation = "";

            switch (recommendedName)
            {
                case "Via Italia":
                    recommendedLocation = "Glasgow, G5 7DE";
                    break;
                case "Pizza Hut":
                    recommendedLocation = "Motherwell, M3 9DD";
                    break;
                case "Dominos":
                    recommendedLocation = "Motherwell, M8 7DA";
                    break;
                case "Burger King":
                    recommendedLocation = "Glasgow, G9 3EC";
                    break;
                case "McDonalds":
                    recommendedLocation = "Coatbridge, C4 DEE";
                    break;
                case "Bar Americano":
                    recommendedLocation = "Soriano 858, 11100 Montevideo, Uruguay";
                    break;
                case "La Cocina de Pedro":
                    recommendedLocation = "Av. Gonzalo Ramírez 1483, 11200 Montevideo, Uruguay";
                    break;
            }

            return recommendedLocation;
        }

        public int calculateWaitTime(string location)
        {
            int waitTime = 0;

            if (location.Contains("Glasgow"))
            {
                waitTime = 30;
            }
            else if(location.Contains("Uruguay"))
            {
                waitTime = 3000;
            }
            else if(location.Contains("Coatbridge"))
            {
                waitTime = 180;
            }
            else
            {
                waitTime = 120;
            }

            return waitTime;
        }
        #endregion
    }
}
