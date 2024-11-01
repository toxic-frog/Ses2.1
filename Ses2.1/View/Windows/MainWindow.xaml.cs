using Ses2._1.AppData;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<voditela> voditels = App.context.voditela.ToList();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AuthorizationHelper.CheckData(LoginTb.Text, PasswordTb.Password) == true)
            {
                // успешная авторизация 
                MessageBox.Show("Пользователь успешно авторизован!");
                Close();
            }
            else
            {
                // неуспешная авторизация
                MessageBox.Show("Пользователь не найден!");
            }
        }
    }
}
