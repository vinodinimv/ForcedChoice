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
        public Windownumber()
        {
           
            InitializeComponent();
            DataContext = this;
            var countback20 = new countback20();
            countback20.Show();

            DispatcherTimer timer = new DispatcherTimer(TimeSpan.FromSeconds(1),DispatcherPriority.Normal, 
                delegate {

                    
                    int newvalue, i = 0;
                    newvalue = a[i];
                    i++;
                    SetValue(DisplayNumberProperty, newvalue);
                       
                    } , Dispatcher);
         }
               
        public int DisplayNumber
        {
            get { return (int)GetValue(DisplayNumberProperty); }
            set { SetValue(DisplayNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DisplayNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisplayNumberProperty =
            DependencyProperty.Register("DisplayNumber", typeof(int), typeof(Windownumber), new PropertyMetadata(0));


        
       
    }


}
