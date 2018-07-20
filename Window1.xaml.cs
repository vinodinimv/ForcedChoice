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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        //private void mouse_click(object sender, MouseButtonEventArgs e)
        //{
        //    MessageBox.Show("hi");
        //}

        private void HandleKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.X && (Keyboard.Modifiers & ModifierKeys.Control) == ModifierKeys.Control)
            {
                MessageBox.Show("You press Ctrl+X :)");
            }

         }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            var newexitwindow = new ExitWindow();
            if ((e.Key == Key.X) &&
                 (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)))
                //MessageBox.Show("You pressed Ctrl+X !");

                newexitwindow.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var windownumber = new Windownumber();
            windownumber.Show();
            this.Close();
        }
    }
}
