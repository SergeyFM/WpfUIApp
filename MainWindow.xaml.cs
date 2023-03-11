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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfUIApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lblHi.Content = lblHi.Content == "Привет!" ? "Пока!" : "Привет!";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double lft = Canvas.GetLeft(lblHi);
            lft = Double.IsNaN(lft) ? 0 : lft;
            Canvas.SetLeft(lblHi,  lft+10);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double lft = Canvas.GetLeft(lblHi);
            lft = Double.IsNaN(lft) ? 0 : lft;
            Canvas.SetLeft(lblHi, lft - 10);
        }

        private void btnTime_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString());
        }
    }
}
