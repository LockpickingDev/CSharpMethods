using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMethods
{
    class MathClass
    {

        #region Compute angle of hands on clock
        //Computes the angle between the hand hands of a clock given a time of day. Works for all combinations of hour and minute.
		//DO NOT FORGET The hour hand is a certain angle between 2 hours and only dead on the hour at 0 minutes
        public double findClockAngle(int hour, int minute)
		{
			double returnAngle;

			double hourAngle = 360 / 12; //30
			double minuteAngle = 360 / 60; //6

			//0 to exact hour angle
			double hourBigAngle = hourAngle * hour;

			//Angle between hour and next hour
			double hourSmallAngle = 0.5 * minute;

			double hourTotalAngle = hourBigAngle + hourSmallAngle;

			//0 to minute angle
			double minTotalAngle = minuteAngle * minute;

			if (hourTotalAngle > minTotalAngle)
			{
				returnAngle = hourTotalAngle - minTotalAngle;
			}
			else
			{
				returnAngle = minTotalAngle - hourTotalAngle;
			}

			if (returnAngle > 180)
			{
				returnAngle = 360 - returnAngle;
			}

			return returnAngle;
		}
		#endregion


		#region asdfasdfasdfasdfasdfasdf

		#endregion

		#region asdfasdfasdfasdfasdfasdf

		#endregion

		#region asdfasdfasdfasdfasdfasdf

		#endregion

		#region asdfasdfasdfasdfasdfasdf

		#endregion

		#region asdfasdfasdfasdfasdfasdf

		#endregion



	}//class MathClass
}//namespace CSharpMethods
