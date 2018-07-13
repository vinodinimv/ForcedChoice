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
    /// Interaction logic for WindowCheckNumber.xaml
    /// </summary>
    public partial class WindowCheckNumber : Window
     {
        private const string n1 = "59721";
        public string display { get { return n1; } }
        public WindowCheckNumber()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
