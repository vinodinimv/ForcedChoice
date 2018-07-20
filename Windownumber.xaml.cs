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
    /// Interaction logic for Windownumber.xaml
    /// </summary>
    public partial class Windownumber : Window
    {

        //public string s1 = "59721";
        public string[] s2 = { "59721", "38769" };
        
        
        //public int[] a = new int[] { 5, 8, 2, 9, 4 };
        static int i = 0;
        public Windownumber()
        {

            InitializeComponent();
            //DataContext = this;
            Counter_Timer.Interval = new TimeSpan(0, 0, 1);
            Counter_Timer.Tick += dispatcherTimer_Tick;
            
            //counter1.Text = a[i].ToString();
            Counter_Timer.Start();


            // timer to close the counting window "windownumber"
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(6) };
            timer.Start();

            timer.Tick += (sender, args) =>
            {
                timer.Stop();
                this.Close();
                //Window countback20 = new countback20();
                //countback20.Show();
            };

            //timer to open countback window
            var timer1 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5.9) };
            timer1.Start();
            timer1.Tick += (sender, args) =>
            {
                timer1.Stop();
                Window countback20 = new countback20();
                countback20.Show();
                
             };

            var timer3 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(11.9) };
            timer3.Start();
            timer3.Tick += (sender, args) =>
            {
                timer3.Stop();
                //this.Close();
                Window windowchecknumber = new WindowCheckNumber();
                windowchecknumber.Show();

            };



        }


        private readonly DispatcherTimer Counter_Timer = new DispatcherTimer();
        public void dispatcherTimer_Tick(object sender, object e)
        {

            counter1.Text = s1[i++].ToString();
            
            if (i >= 5)
            {
                Counter_Timer.Stop();
            }
           
        }

       



}
   


}
