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
        static int correct = 0, incorrect = 0;
        public string display { get { return n1; } }
        public WindowCheckNumber()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            if ((button1.Content as string) == n1)
            {
                correct++;
                Window win_correct = new Win_correct();
                win_correct.Show();
                this.Close();
                Window window1 = new Window1();
                window1.Show();
            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if((button.Content as string) != n1)
            {
                incorrect++;
                Window win_incorrect = new Win_incorrect();
                win_incorrect.Show();
                this.Close();
            }
           
            //Window win_incorrect = new Win_incorrect();
            //win_incorrect.Show();
            //this.Close();
        }
    }
}
