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
    /// Interaction logic for countback50.xaml
    /// </summary>
    public partial class countback50 : Window
    {
        static int countback1 = 0;
        public countback50()
        {
            InitializeComponent();
            Counter_Timer1.Interval = new TimeSpan(0, 0, 1);
            Counter_Timer1.Tick += dispatcherTimer_Tick;
            Counter_Timer1.Start();

            //close countback window
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(20) };
            timer.Start();

            timer.Tick += (sender, args) =>
            {
                timer.Stop();
                this.Close();
            };
        }
            private readonly DispatcherTimer Counter_Timer1 = new DispatcherTimer();
        // display window till 1000 is counted
        public void dispatcherTimer_Tick(object sender, object e)
        {
            countback1++;

            if (countback1 == 800)
            {
                Counter_Timer1.Stop();
            }

        }

     }
  }
