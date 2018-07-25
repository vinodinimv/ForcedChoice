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
    /// Interaction logic for Win_incorrect3.xaml
    /// </summary>
    public partial class Win_incorrect3 : Window
    {
        public Win_incorrect3()
        {
            InitializeComponent();
            var timer6 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1.2) };
            timer6.Start();
            timer6.Tick += (sender, args) =>
            {
                timer6.Stop();
                Window3 window2 = new Window3();
                window2.Show();
                this.Close();
            };
        }
    }
}
