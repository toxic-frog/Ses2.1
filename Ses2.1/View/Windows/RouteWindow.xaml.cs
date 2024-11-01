using Ses2._1.Model;
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
    /// Логика взаимодействия для RouteWindow.xaml
    /// </summary>
    public partial class RouteWindow : Window
    {
        List<marchrut> marchruts = App.context.marchrut.ToList();
        List<avtobus> avtobus = App.context.avtobus.ToList();
        public RouteWindow()
        {
            InitializeComponent();
            EventsLv.ItemsSource = App.context.marchrut.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
