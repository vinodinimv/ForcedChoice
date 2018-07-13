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
    /// Interaction logic for countback20.xaml
    /// </summary>
    
    
    public partial class countback20 : Window
    {
        static int i = 0;
        public countback20()
        {
            InitializeComponent();

            Counter_Timer1.Interval = new TimeSpan(0, 0, 1);
            Counter_Timer1.Tick += dispatcherTimer_Tick;
            Counter_Timer1.Start();

            //close countback window
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(6) };
            timer.Start();

            timer.Tick += (sender, args) =>
            {
                timer.Stop();
                this.Close();
                
            };


            //var timer3 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(6) };
            //timer3.Start();
            //timer3.Tick += (sender, args) =>
            //{
            //    timer3.Stop();
            //    //this.Close();
            //    Window windowchecknumber = new WindowCheckNumber();
            //    windowchecknumber.Show();

            //};
        }
        private readonly DispatcherTimer Counter_Timer1 = new DispatcherTimer();
        // display window till 20 is counted
        public void dispatcherTimer_Tick(object sender, object e)
        {
            i++;

            if ( i == 5)
            {
                Counter_Timer1.Stop();
            }

        }




}
}
