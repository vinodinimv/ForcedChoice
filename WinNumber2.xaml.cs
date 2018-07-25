using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApplication_v1
{
    /// <summary>
    /// Interaction logic for WinNumber2.xaml
    /// </summary>
    public partial class WinNumber2 : Window
    {
        //public static int k;
        public static string[] displaynumber = { "59721", "86539", "79213", "35879", "65794", "49168", "43592", "61524", "98327", "36587", "89635", "31982", "69458", "14273", "73294", "65149", "51743", "63281", "00000" };
       // public static string[] displaynumber = { "59721", "86539", "79213", "00000" };
        public static char[] digits;
        //public string displayfunc { get { return displaynumber[YourStorage.j]; } }
        public static int x;

        public WinNumber2()
        {
            InitializeComponent();
            DataContext = this;
            digits = displaynumber[CounterVar1.count1].ToCharArray();


            Counter_Timer.Interval = new TimeSpan(0, 0, 1);
            Counter_Timer.Tick += dispatcherTimer_Tick;

            if (CounterVar1.count1 < displaynumber.Length - 1)
            {

                //Counter_Timer.Interval = new TimeSpan(0, 0, 1);
                //Counter_Timer.Tick += dispatcherTimer_Tick;
                Counter_Timer.Start();
                CounterVar1.count1++;
                // timer to close the counting window "windownumber"
                var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(6) };
                timer.Start();

                timer.Tick += (sender, args) =>
                {
                    timer.Stop();
                    this.Close();

                };

                //timer to open countback window
                var timer1 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5.9) };
                timer1.Start();
                timer1.Tick += (sender, args) =>
                {
                    timer1.Stop();
                    Window countback50 = new countback50();
                    countback50.Show();

                };
                var timer3 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(23) };
                timer3.Start();
                timer3.Tick += (sender, args) =>
                {
                    timer3.Stop();
                    Window windowchecknumber1 = new WindowCheckNumber1();
                    windowchecknumber1.Show();

                };
            }


            else
            {


                var timer7 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
                timer7.Start();

                timer7.Tick += (sender, args) =>
                {
                    timer7.Stop();
                    FinalLevel FL = new FinalLevel();
                    FL.Show();

                };
                
            }


        }


        private readonly DispatcherTimer Counter_Timer = new DispatcherTimer();
        public void dispatcherTimer_Tick(object sender, object e)
        {

            counter2.Text = digits[x++].ToString();

            if (x >= 5)
            {
                Counter_Timer.Stop();
                x = 0;
            }

        }



        public static class CounterVar1
        {
            public static int count1 = 0;

        }
    }
}
