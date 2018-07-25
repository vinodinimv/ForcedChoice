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
    /// Interaction logic for NextLevel.xaml
    /// </summary>
    public partial class NextLevel : Window
    {
        public NextLevel()
        {
            InitializeComponent();
            DataContext = this;
         }

        private void Button_Click_Winnumber2(object sender, RoutedEventArgs e)
        {
           // WinNumber2 Winnumber2 = new WinNumber2();
           // Winnumber2.Show();
            Window2 nl1 = new Window2();
           nl1.Show();
            this.Close();
        }
    }
}
