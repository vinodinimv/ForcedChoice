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
    /// Interaction logic for ExitWindow.xaml
    /// </summary>
    public partial class ExitWindow : Window
    {
        public ExitWindow()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
            //Environment.Exit(0); this also works
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
