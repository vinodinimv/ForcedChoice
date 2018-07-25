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

namespace WpfApplication_v1
{
    /// <summary>
    /// Interaction logic for FinalLevel.xaml
    /// </summary>
    public partial class FinalLevel : Window
    {
        public FinalLevel()
        {
            InitializeComponent();
            DataContext = this;

        }
        private void Button_Click_Winnumber3(object sender, RoutedEventArgs e)
        {
            // WinNumber2 Winnumber2 = new WinNumber2();
            // Winnumber2.Show();
            Window3 nf1 = new Window3();
            nf1.Show();
            this.Close();
        }
    }
}
