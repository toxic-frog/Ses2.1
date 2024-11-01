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

namespace Ses2._1.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для SelectionWindow.xaml
    /// </summary>
    public partial class SelectionWindow : Window
    {
        public SelectionWindow()
        {
            InitializeComponent();
        }

        private void RoutesBtn_Click(object sender, RoutedEventArgs e)
        {
            RouteWindow routeWindow = new RouteWindow();
            routeWindow.Show();
        }

        private void TripsBtn_Click(object sender, RoutedEventArgs e)
        {
            TripsWindow tripsWindow = new TripsWindow();
            tripsWindow.Show();
        }

        private void DriverBtn_Click(object sender, RoutedEventArgs e)
        {
            DriverWindow driverWindow = new DriverWindow();
            driverWindow.Show();
        }
    }
}
