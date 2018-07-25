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
    /// Interaction logic for WindowCheckNumber1.xaml
    /// </summary>
    public partial class WindowCheckNumber1 : Window
    {
        public static string[] topchoice = { "59721", "86539", "79213", "35878", "85794", "49163", "43592", "61524", "98325", "46587", "89635", "71982", "29458", "14273", "63294", "65149", "51748", "93281" };
        public static string[] bottomchoice = { "39721", "86531", "49213", "35879", "65794", "49168", "43591", "31524", "98327", "36587", "89637", "31982", "69458", "84273", "73294", "65147", "51743", "63281" };
        static int correct50 = 0, incorrect50 = 0;
        public string bottomdisplay { get { return bottomchoice[countervar1.counter1]; } }
        public string topdisplay { get { return topchoice[countervar1.counter1]; } }
        public WindowCheckNumber1()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void top_button_Click(object sender, RoutedEventArgs e)
        {


            if ((button.Content as string) == WinNumber2.displaynumber[countervar1.counter1])
            {
                correct50++;
                Window win_correct = new Win_correct1();
                win_correct.Show();
                this.Close();

            }
            else
            {
                incorrect50++;
                Window win_incorrect = new Win_incorrect1();
                win_incorrect.Show();
                this.Close();
            }
            countervar1.counter1++;

        }


        private void bottom_button1_Click(object sender, RoutedEventArgs e)
        {
            if ((button1.Content as string) == WinNumber2.displaynumber[countervar1.counter1])
            {
                correct50++;
                Window win_correct = new Win_correct1();
                win_correct.Show();
                this.Close();
            }
            else

            {
                incorrect50++;
                Window win_incorrect = new Win_incorrect1();
                win_incorrect.ShowDialog();
                this.Close();
            }
            // j++;
            countervar1.counter1++;


        }
        
        public static class countervar1
        {
            public static int counter1 = 0;
        }
    }
}
