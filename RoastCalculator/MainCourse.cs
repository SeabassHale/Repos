using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoastCalculator
{
    public class MainCourse
    {
        public string Name { get; set; }
        public TimeSpan CookTime { get; set; } //cooktime per 1,000g
        public TimeSpan ExtraCookTime { get; set; } = new TimeSpan(00, 00, 00); //additional cookingtime on top of weight-based time. NEEDS TO BE CONVERTED TO A TIMESPAN
        public TimeSpan StandTime { get; set; } = new TimeSpan(00, 00, 00);
        // Add TimeSpan for mid-cook alarms / actions
        public string? CookingInstructions { get; set; } // Add String for cooking instructions (oven temp, additional actions/steps, maybe link to recipies?
    }
}
