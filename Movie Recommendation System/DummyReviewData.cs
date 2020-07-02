using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Recommendation_System
{
    // copied straight from http://www.codeinthezone.com/find-and-rank-similar-entities-c-sharp-with-pearson-correlation/
    // Will show up as plagerism
    public class DummyReviewData
    {
        string lisaRose = "Lisa Rose";
        string geneSeymour = "Gene Seymour";
        string michaelPhillips = "Michael Phillips";
        string claudiaPuig = "Claudia Puig";
        string mickLaSalle = "Mick LaSalle";
        string jackMatthews = "Jack Matthews";
        string toby = "Toby";

        public Dictionary<string, double> lisaRosePreferences = new Dictionary<string, double>
        {
            {"Lady in the Water", 2.5},
            {"Snakes on a Plane", 3.5},
            {"Just My Luck", 3.0},
            {"Superman Returns", 3.5},
            {"You, Me and Dupree", 2.5},
            {"The Night Listener", 3.0}
        };
        public Dictionary<string, double> geneSeymourPreferences = new Dictionary<string, double>
        {
            {"Lady in the Water", 3},
            {"Snakes on a Plane", 3.5},
            {"Just My Luck", 1.5},
            {"Superman Returns", 5},
            {"You, Me and Dupree", 3.5},
            {"The Night Listener", 3.0}
        };

        public Dictionary<string, double> michaelPhillipsPreferences = new Dictionary<string, double>
        {
            {"Lady in the Water", 2.5},
            {"Snakes on a Plane", 3},
            {"Superman Returns", 3.5},
            {"The Night Listener", 4.0}
        };

        public Dictionary<string, double> claudiaPuigPreferences = new Dictionary<string, double>
        {
            {"Snakes on a Plane", 3.5},
            {"Just My Luck", 3.0},
            {"The Night Listener", 4.5},
            {"Superman Returns", 4},
            {"You, Me and Dupree", 2.5}
        };

        public Dictionary<string, double> mickLaSallePreferences = new Dictionary<string, double>
        {
            {"Lady in the Water", 3},
            {"Snakes on a Plane", 4},
            {"Just My Luck", 2},
            {"Superman Returns", 3},
            {"You, Me and Dupree", 2.0}
        };

        public Dictionary<string, double> jackMatthewsPreferences = new Dictionary<string, double>
        {
            {"Lady in the Water", 3},
            {"Snakes on a Plane", 4},
            {"The Night Listener", 3},
            {"Superman Returns", 5},
            {"You, Me and Dupree", 3.5}
        };

        public Dictionary<string, double> tobyPreferences = new Dictionary<string, double>
        {
            {"Snakes on a Plane", 4.5},
            {"You, Me and Dupree", 1},
            {"Superman Returns", 4}
        };

        public Dictionary<string, Dictionary<string, double>> preferences()
        {
            Dictionary<string, Dictionary<string, double>> pref = new Dictionary<string, Dictionary<string, double>>
            {
            {lisaRose, lisaRosePreferences},
            {geneSeymour, geneSeymourPreferences},
            {michaelPhillips, michaelPhillipsPreferences},
            {claudiaPuig, claudiaPuigPreferences},
            {mickLaSalle, mickLaSallePreferences},
            {jackMatthews, jackMatthewsPreferences},
            {toby, tobyPreferences}
            };

            return pref;
        }
    }
}