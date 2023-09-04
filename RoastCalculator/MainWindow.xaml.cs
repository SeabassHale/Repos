using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RoastCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    //public class TimerClass
    //{
    //    static Timer cookingTimer = new Timer();
    //    static int alarmCounter = 1;
    //    static bool exitFlag = false;

    //    private static void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
    //    {
    //        cookingTimer.Stop();
    //        if(MessageBox.Show("Continue running?", "Count is: " + alarmCounter, MessageBoxButton.YesNo) == DialogResult.Yes)
    //        {
    //            alarmCounter +=10;
    //            cookingTimer.Enabled = true;
    //        }
    //        else
    //        {
    //            exitFlag = true;
    //        }
    //    }
    //}

    public class MainCourse
    {
        public string Name { get; set; }
        public TimeSpan CookTime {  get; set; } //cooktime per 1,000g
        public TimeSpan ExtraCookTime { get; set; } = new TimeSpan(00,00,00); //additional cookingtime on top of weight-based time. NEEDS TO BE CONVERTED TO A TIMESPAN
        public TimeSpan StandTime { get; set; } = new TimeSpan(00,00,00);
        // Add TimeSpan for mid-cook alarms / actions
        public string CookingInstructions { get; set; } // Add String for cooking instructions (oven temp, additional actions/steps, maybe link to recipies?
    }

    public class Extra : MainCourse
    {
        // add a TimeSpan for Pre main finishing cooking
        // add a TimeSpan for post main finishing cooking
    }

    public static class Multiplier
    {
        public static TimeSpan MultiplyTimeSpan(this TimeSpan multiplicand, double multiplier)
        {
            return TimeSpan.FromTicks((long)(multiplicand.Ticks * multiplier));
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadCombos();
            
            DateTime TimeNow = DateTime.Now;
            TimeBox.Text = TimeNow.ToShortTimeString();

        }

        private void LoadCombos()
        {
            
            List<MainCourse> MainCourses = new List<MainCourse>();
            MainCourses.Add(new MainCourse { Name = "Beef (Rare)", CookTime = new TimeSpan(00,34,00), ExtraCookTime = new TimeSpan(00,00,00), CookingInstructions = "put it in the oven"});
            MainCourses.Add(new MainCourse { Name = "Lamb", CookTime = new TimeSpan(00,44,44), ExtraCookTime = new TimeSpan(00,20,00), CookingInstructions = "put it in the oven" });
            MainCourses.Add(new MainCourse { Name = "Chicken", CookTime = new TimeSpan(00,50,00), ExtraCookTime = new TimeSpan(00, 20, 00), CookingInstructions = "put it in the oven"} );
            MainCourses.Add(new MainCourse { Name = "Pork", CookTime = new TimeSpan(00,60,00), ExtraCookTime = new TimeSpan(00, 30, 00), CookingInstructions = "put it in the oven" });
            MainCourses.Add(new MainCourse { Name = "Turkey", CookTime = new TimeSpan(00,40,00), CookingInstructions = "put it in the oven" });

            foreach (MainCourse course in MainCourses)
            {
                MainSelector.Items.Add(course);
            }

            List<Extra> Extras = new List<Extra>();
            Extras.Add(new Extra { Name = "None", CookTime = new TimeSpan(00, 00, 00), ExtraCookTime = new TimeSpan(00, 00, 00), CookingInstructions = "None" });
            Extras.Add(new Extra { Name = "Roast Potatoes", CookTime = new TimeSpan(00,60,00), ExtraCookTime = new TimeSpan(00, 00, 00), CookingInstructions = "put it in the oven" });
            Extras.Add(new Extra { Name = "Roast Veg", CookTime = new TimeSpan(00, 45, 00), ExtraCookTime = new TimeSpan(00, 00, 00), CookingInstructions = "put it in the oven" });
            Extras.Add(new Extra { Name = "Boiled Potatoes", CookTime = new TimeSpan(00, 25, 00), ExtraCookTime = new TimeSpan(00, 00, 00), CookingInstructions = "put it in the oven" });
            Extras.Add(new Extra { Name = "Boiled Veg", CookTime = new  TimeSpan(00, 20, 00), ExtraCookTime = new TimeSpan(00, 00, 00), CookingInstructions = "put it in the oven" });
            Extras.Add(new Extra { Name = "Mashed Potatoes", CookTime = new TimeSpan(00, 30, 00), ExtraCookTime = new TimeSpan(00, 00, 00), CookingInstructions = "put it in the oven" });
            Extras.Add(new Extra { Name = "Gravy", CookTime = new TimeSpan(00, 15, 00), ExtraCookTime = new TimeSpan(00, 00, 00), CookingInstructions = "put it in the oven" });
            Extras.Add(new Extra { Name = "Stuffing", CookTime = new TimeSpan(00, 25, 00), ExtraCookTime = new TimeSpan(00, 00, 00), CookingInstructions = "put it in the oven" });

            foreach (Extra Extra in Extras)
            {
                ExtraSelectorOne.Items.Add(Extra);
                ExtraSelectorTwo.Items.Add(Extra);
                ExtraSelectorThree.Items.Add(Extra);
            }
        }

        private void ExtraSelectorOne_SelectionChanged(object sender, EventArgs e)
        {
            var ext1 = (Extra)ExtraSelectorOne.SelectedItem;

            ExtraInfoOne.Text = string.Format("CookTime: {0} minutes", Convert.ToString(ext1.CookTime)); 
        }

        private void ExtraSelectorTwo_SelectionChanged(object sender, EventArgs e)
        {
            var ext2 = (Extra)ExtraSelectorTwo.SelectedItem;

            ExtraInfoTwo.Text = string.Format("CookTime: {0} minutes", Convert.ToString(ext2.CookTime));
        }

        private void ExtraSelectorThree_SelectionChanged(object sender, EventArgs e)
        {
            var ext3 = (Extra)ExtraSelectorThree.SelectedItem;

            ExtraInfoThree.Text = string.Format("CookTime: {0} minutes", Convert.ToString(ext3.CookTime));
        }

        private void CalculateTimeButton_Click(object sender, EventArgs e)
        {
            var maincourse = (MainCourse)MainSelector.SelectedItem;
            TimeSpan totalTimeToCook = Multiplier.MultiplyTimeSpan(maincourse.CookTime, Convert.ToDouble(WeightBox.Text));
            DateTime TimeNow = DateTime.Now;
            TimeBox.Text = TimeNow.ToShortTimeString();
            CookingInstructionsBox.Text = maincourse.CookingInstructions;
            //TimerClass timer = new TimerClass();
            //timer.Tick +=;
            DateTime FinishCookTime = TimeNow.Add(totalTimeToCook);
            FinishTimeBox.Text = FinishCookTime.ToString("HH:mm");
        }

        //private void AddMoreButton_Click(object sender, RoutedEventArgs e)
        //{

        //}

        private void MainSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
