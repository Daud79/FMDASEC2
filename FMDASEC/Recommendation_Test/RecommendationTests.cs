using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FMDASEC;

namespace Recommendation_Test
{
    [TestClass]
    public class RecommendationTests
    {
        #region inputs/variables
        //arranging our inputs
        double longitude = 55.7782;
        double latitude = 4.1041;
        int distance = 10;
        Recommendation myRecommendation = new Recommendation();

        string name;
        string location;
        double waitTime;           
        #endregion

        #region test methods
        [TestMethod]
        public void checkRecommendation()
        {
            //the action/behaviour
            myRecommendation = myRecommendation.getRecommendation(longitude, latitude, distance);

            name = myRecommendation.getRecommendationName();
            location = myRecommendation.getRecommendationLocation();
            waitTime = myRecommendation.getRecommendationWaitTime();

            //calling all our methods to check recommendation's values
            checkRecommendationName(myRecommendation);
            checkRecommendationLocation(myRecommendation);
            checkRecommendationWaitTime(myRecommendation);
        }
        #endregion

        #region regular methods

        public void checkRecommendationName(Recommendation myRecommendation)
        {
            //assertion
            string actualName = name;
            string expectedName = myRecommendation.getRecommendationName();
            Assert.AreEqual(expectedName, actualName);
        }

        
        public void checkRecommendationLocation(Recommendation myRecommendation)
        {
            //assertion
            string actualLocation = location;
            string expectedLocation = myRecommendation.getRecommendationLocation();
            Assert.AreEqual(expectedLocation, actualLocation);
        }

        
        public void checkRecommendationWaitTime(Recommendation myRecommendation)
        {          
            //assertion
            double actualWaitTime = waitTime;
            double expectedWaitTime = myRecommendation.getRecommendationWaitTime();
            Assert.AreEqual(expectedWaitTime, actualWaitTime);
        }
        #endregion
    }
}
