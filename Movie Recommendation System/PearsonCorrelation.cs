using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Recommendation_System
{
    public class PearsonCorrelation
    {
        // copied straight from http://www.codeinthezone.com/find-and-rank-similar-entities-c-sharp-with-pearson-correlation/
        // Will show up as plagerism


        public DummyReviewData testData = new DummyReviewData();

        public double FromOnlineGetPearsonCorrelation(Dictionary<string, Dictionary<string, double>> preferences, string entity1, string entity2)
        {
            // exception checking
            if (preferences == null)
            {
                throw new ArgumentNullException("preferences");
            }

            if (entity1 == null)
            {
                throw new ArgumentNullException("entity1");
            }

            if (entity2 == null)
            {
                throw new ArgumentNullException("entity2");
            }

            if (!preferences.ContainsKey(entity1) || !preferences.ContainsKey(entity2))
            {
                return 0;
            }

            var similarities = GetCommonItems(preferences, entity1, entity2).ToArray();
            if (!similarities.Any())
            {
                return 0;
            }


            var similaritiesCount = similarities.Count();

            // Add up all the preferences
            var sum1 = similarities.Select(sim => preferences[entity1][sim.ToString()]).Sum();
            var sum2 = similarities.Select(sim => preferences[entity2][sim.ToString()]).Sum();


            // Sum up the squares
            var sumOfSquares1 = similarities.Select(sim => Math.Pow(preferences[entity1][sim.ToString()], 2)).Sum();
            var sumOfSquares2 = similarities.Select(sim => Math.Pow(preferences[entity2][sim.ToString()], 2)).Sum();


            // Sum up the products
            var sumOfProducts = similarities.Select(sim => preferences[entity1][sim.ToString()] * preferences[entity2][sim.ToString()]).Sum();

            // Calculate Pearson Correlation Coefficient
            var numerator = sumOfProducts - (sum1 * sum2) / similaritiesCount;
            var denominator =
                Math.Sqrt((sumOfSquares1 - Math.Pow(sum1, 2) / similaritiesCount) *
                          (sumOfSquares2 - Math.Pow(sum2, 2) / similaritiesCount));

            if (denominator == 0)
            {
                return 0;
            }

            return numerator / denominator;
        }

        private string GetCommonItems(IReadOnlyDictionary<string, Dictionary<string, double>> preferences, string entity1, string entity2)
        {
            return (preferences[entity1].Where(pref => preferences[entity2].ContainsKey(pref.Key)).Select(pair => pair.Key)).ToString();
        }

        public SortedDictionary<double, string> TopMatches(Dictionary<string, Dictionary<string, double>> preferences, string entity,
        int limit, Func<Dictionary<string, Dictionary<string, double>>, string, string, double> metricFunc)
        {
            var result = new SortedDictionary<double, string>(new DescendingCompare<double>());
            foreach (var currentEntity in preferences.Select(currentEntityItems => currentEntityItems.Key).Where(currentEntity => !currentEntity.Equals(entity)).Where(currentEntity => result.Count < limit))
            {
                result.Add(metricFunc(preferences, entity, currentEntity), currentEntity);
            }
            return result;
        }



        // How to use 
        // Paste in the section you want to use it in
        // public PearsonCorrelation pcCalculator = new PearsonCorrelation();
        //
        // For the coeffieffient score
        // public double = pcCalculator.FromOnlineGetPearsonCorrelation(pcCalculator.testData.pref);
        //
        //
        // For matches
        // public Dictionary sorted = pcCalculator.TopMatches(preferences, entity, limit, pcCalculator.FromOnlineGetPearsonCorrelation(PearsonCorrelation.testData.pref));




    }

    // extra class which overrides the compare function from dictionary comparion
    public class DescendingCompare<T> : Comparer<T> where T : IComparable<T>
        {
            public override int Compare(T x, T y)
            {
                return y == null ? 1 : y.CompareTo(x);
            }
        }
}