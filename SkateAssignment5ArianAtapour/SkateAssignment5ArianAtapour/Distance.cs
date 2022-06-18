using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateAssignment5ArianAtapour
{
    internal class Distance
    {
        private List<Skater> skaters = new List<Skater>();
        //public int points;

        public Distance()
        {
            
        }

        public void addSkater(Skater skater)
        {
            skaters.Add(skater);

        }

        public List<Skater> getSkaters()
        {
            return skaters;
        }

        public string winner()
        {
            string skName = null;
            double skDP=Int32.MaxValue;
            
            foreach(Skater skater in skaters)
            {
                if (skaters.Count > 0)
                {
                    if (skater.getPoints() < skDP && skater.getDistance() == 10000)
                    {
                        skDP = skater.getPoints();
                        skName = skater.getName();
                    }
                    else if (skater.getPoints() < skDP && skater.getDistance() == 5000)
                    {
                        skDP = skater.getPoints();
                        skName = skater.getName();
                    }
                    else if (skater.getPoints() < skDP && skater.getDistance() == 1500)
                    {
                        skDP = skater.getPoints();
                        skName = skater.getName();
                    }
                    else if (skater.getPoints() < skDP && skater.getDistance() == 500)
                    {
                        skDP = skater.getPoints();
                        skName = skater.getName();
                    }
                }
                
            }

            return skName + "," + Convert.ToString(skDP) + " points";
        }

        /*
        public string winner10000()
        {
            double winner10000 = 100000000000000;
            string skName = null;

            foreach(Skater skater in skaters)
            {
                if(skater.getPoints() < winner10000 && skater.getDistance() == 10000)
                {
                    winner10000 = skater.getPoints();
                    skName = skater.getName();
                }
            }

            return skName + "," +Convert.ToString(winner10000) + " points";
        }

        public string winner5000()
        {
            double winner5000 = 100000000000000;
            string skName = null;

            foreach (Skater skater in skaters)
            {
                if (skater.getPoints() < winner5000 && skater.getDistance() == 5000)
                {
                    winner5000 = skater.getPoints();
                    skName = skater.getName();
                }
            }

            return skName + "," + Convert.ToString(winner5000) + " points";
        }

        public string winner1500()
        {
            double winner1500 = 100000000000000;
            string skName = null;

            foreach (Skater skater in skaters)
            {
                if (skater.getPoints() < winner1500 && skater.getDistance() == 1500)
                {
                    winner1500 = skater.getPoints();
                    skName = skater.getName();
                }
            }

            return skName + "," + Convert.ToString(winner1500) + " points";
        }

        public string winner500()
        {
            double winner500 = 100000000000000;
            string skName = null;

            foreach (Skater skater in skaters)
            {
                if (skater.getPoints() < winner500 && skater.getDistance() == 500)
                {
                    winner500 = skater.getPoints();
                    skName = skater.getName();
                }
            }

            return skName + "," + Convert.ToString(winner500) + " points";
        }
        */


    }
}
