using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateAssignment5ArianAtapour
{
    internal class Championship
    {
        private List<Distance> distances = new List<Distance>();
         public Championship()
        {

        }

        public void addDistance(Distance distance)
        {
            distances.Add(distance);
        }

        public List<Distance> getDistList()
        {
            return distances;
        }

        public string getWinner()
        {
            foreach(Distance distance in distances)
            {
                return distance.winner();
            }
            return null;
        }

        /*

        public string winner10000C()
        {
            foreach (Distance distance in distances)
            {
                return distance.winner10000();
            }
            return null;
        }

        public string winner5000C()
        {
            foreach (Distance distance in distances)
            {
                return distance.winner5000();
            }
            return null;
        }

        public string winner1500C()
        {
            foreach (Distance distance in distances)
            {
                return distance.winner1500();
            }
            return null;
        }

        public string winner500C()
        {
            foreach (Distance distance in distances)
            {
                return distance.winner500();
            }
            return null;
        }
        */
    }

}
