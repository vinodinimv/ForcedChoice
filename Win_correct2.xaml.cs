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
    /// Interaction logic for Win_correct2.xaml
    /// </summary>
    public partial class Win_correct2 : Window
    {
        public Win_correct2()
        {
            InitializeComponent();
            var timer5 = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1.2) };
            timer5.Start();
            timer5.Tick += (sender, args) =>
            {
                timer5.Stop();

                Window3 window2 = new Window3();
                window2.Show();
                this.Close();
            };
        }
    }
}
