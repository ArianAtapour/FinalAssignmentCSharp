using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkateAssignment5ArianAtapour
{
    internal class Skater
    {
        public string name;
        public double distance;
        public double points;

        public Skater()
        {
            distance = 0.0;
            points = 0.0;
        }

        public void addName(string nameSk)
        {
          name = nameSk;
        }

        public void setDistance(double dist)
        {
            distance = dist;
        }

        public void setPoints(double pointsD)
        {
            points = pointsD;
        }

        public string getName()
        {
            return name;
        }

        public double getDistance()
        {
           return distance;
        }

        public double getPoints()
        {
            return points;
        }
    }
}
