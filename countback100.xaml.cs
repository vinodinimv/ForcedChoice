﻿using System;
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
    /// Interaction logic for countback100.xaml
    /// </summary>
    public partial class countback100 : Window
    {
        static int countback2 = 0;
        public countback100()
        {
            InitializeComponent();
            Counter_Timer1.Interval = new TimeSpan(0, 0, 1);
            Counter_Timer1.Tick += dispatcherTimer_Tick;
            Counter_Timer1.Start();

            //close countback window
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(32) };
            timer.Start();

            timer.Tick += (sender, args) =>
            {
                timer.Stop();
                this.Close();

            };
        }
        private readonly DispatcherTimer Counter_Timer1 = new DispatcherTimer();
        // display window till 100 is counted
        public void dispatcherTimer_Tick(object sender, object e)
        {
            countback2++;

            if (countback2 == 1000)
            {
                Counter_Timer1.Stop();
            }

        }
    }
}
