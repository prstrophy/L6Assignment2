using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolarHrm_Assignment
{
    public class gettersandsetters
    {
        string file;
        int maxhr,minhr,maxspeed,minspeed,maxpower,minpower,maxaltitude,minaltitude,maxcasence,mincadence;
       public void setFile(string filename)
        {
            file = filename;
        }
        public string getFile()
        {
            return file;
        }
        //Heart Rate
        public void setMaxHeartRate(int maxheartrate)
        {
            maxhr = maxheartrate;
        }
        public int getMaxHeartRate()
        {
            return maxhr;
        }
        public void setMinHeartRate(int minheartrate)
        {
            minhr = minheartrate;
        }
        public int getMinHeartRate()
        {
            return minhr;
        }

        //Power
        public void setMaxPower(int maxipower)
        {
            maxpower = maxipower;
        }
        public int getMaxPower()
        {
            return maxpower;
        }
        public void setMinPower(int minipower)
        {
            minpower = minipower;
        }
        public int getMinPower()
        {
            return minpower;
        }
        
        //speed
        public void setMaxSpeed(int maxispeed)
        {
            maxspeed = maxispeed;
        }
        public int getMaxSpeed()
        {
            return maxspeed;
        }
        public void setMinSpeed(int minispeed)
        {
            minspeed = minispeed;
        }
        public int getMinSpeed()
        {
            return minspeed;
        }

        //cadence

        public void setMaxCadence(int maxicadence)
        {
            maxcasence = maxicadence;
        }
        public int getMaxCadence()
        {
            return maxcasence;
        }
        public void setMinCadence(int minicadence)
        {
            mincadence = minicadence;
        }
        public int getMinCadence()
        {
            return mincadence;
        }

        //altitude


        public void setMaxAltitude(int maxialtitude)
        {
            maxaltitude = maxialtitude;
        }
        public int getMaxAltitude()
        {
            return maxaltitude;
        }
        public void setMinAltitude(int minialtitude)
        {
            minaltitude = minialtitude;
        }
        public int getMinAltitude()
        {
            return minaltitude;
        }


    }
}
