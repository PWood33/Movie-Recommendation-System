using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Recommendation_System
{
    public class PearsonCorrelation
    {
        private ArrayList collection = new ArrayList();
        //what the algorithm does
        // finds the reviews that reviewed both products. 
        //it then computes the sums of the ratings and the squared sums of the ratings for the two products
        //and computes the sum of the reviews of the products.
        //Finally it uses these results to compute the PC score.

        public void CalculatePearsonScore()
        {
            GetCommonReviews();
            SumOfPref();
            SumOfSquared();
            SumOfProduct();
            SortInDescending();
            PearsonScore();

        }

        //Collect list of products which have reviews in common
        public void GetCommonReviews()
        {
            foreach (var item in collection)
	        {
                
	        }
        }

       //Get the sum of all the preferences
       public void SumOfPref()
       {

       }

       //get sum of squared preferences
       public void SumOfSquared()
        {

        }

       public void SumOfProduct()
       {

       }

       public void PearsonScore()
        {

        }

        public void SortInDescending()
        {

        }

        
    }
}