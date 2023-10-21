using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoastCalculator
{
    internal static class Calculators
    {
        //public static List<TimeSpan> CookingTimeCalculatorMethod(MainCourse dish, double weight)
        //{
        //    // Create a list to hold the different alarm times that will be generated and sent to the alarm/timer method
        //    List<TimeSpan> cookingTimeAlarms = new List<TimeSpan>();

        //    // Use a switch or if statement to identify meal and calculate necessary alarms/timers
        //    if (dish.Name == "Pork")
        //    {
        //        dish.CookTimePerKilo = dish.CookTimePerKilo * weight;
        //        dish.CookTimePerKilo += dish.ExtraCookTime;
        //        cookingTimeAlarms.Add(dish.CookTimePerKilo);
        //        TimeSpan porkReduceTemp = new TimeSpan(00,20,00);
        //        cookingTimeAlarms.Add(porkReduceTemp);
        //        //cookingTimeAlarms.Add((TimeSpan(00,30,00)));
        //    }
        //    return cookingTimeAlarms;
        //}

        public static TimeSpan MultiplyTimeSpan(this TimeSpan multiplicand, double multiplier)
        {
            return TimeSpan.FromTicks((long)(multiplicand.Ticks * multiplier));
        }

        public static void TotalTimeCalculator()
        {
            // Calculate Total Cooking Time for Meal (MainCourse cooking + standing time) 

            // Cooktime * Weight
            // Add on Extra Time
            // Add on Standing Time
            // Return Total Time (Ticks?)
        }

        public static void MainCourseTimeCalculator()
        {
            // Calculate  
        }

        public static void SideAndExtraTimeCalculator()
        {

        }

    }
}
