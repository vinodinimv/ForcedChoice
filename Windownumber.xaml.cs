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

        public int[] a = new int[] { 5, 8, 2, 9, 4 };
        static int i = 0;
        public Windownumber()
        {

            InitializeComponent();
            DataContext = this;
            Counter_Timer.Interval = new TimeSpan(0, 0, 1);
            Counter_Timer.Tick += dispatcherTimer_Tick;

            //counter1.Text = a[i].ToString();
            Counter_Timer.Start();
            
        }

           
        private readonly DispatcherTimer Counter_Timer = new DispatcherTimer();
        public void dispatcherTimer_Tick(object sender, object e)
        {
            counter1.Text = a[i++].ToString();
            if (i > 4)
            {
                Counter_Timer.Stop();
            }
           
        }

       

    }
   


}
