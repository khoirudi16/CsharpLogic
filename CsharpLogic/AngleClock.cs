using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLogic
{
    public class AngleClock
    {
        public static double FindAngleClockByMinutesHour(int minutes, int hours)
        {
            double result = 0;

            /*
             * 30 = selisih per jam
             * 
             * (9 * 30) + (30 * 30 / 60)
             * 270 + 15
             */
            double hour_in_degree = (hours * 30) + (minutes * 30 / 60); //285
            double minute_in_degree = minutes * 6; // 180

            double difference = Math.Abs(hour_in_degree - minute_in_degree);

            result = difference > 180 ? 360 - difference : difference;

            return result;
        }
    }
}
