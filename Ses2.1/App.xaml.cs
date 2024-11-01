using Ses2._1.Model;
using Ses2._1.View.Windows;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Ses2._1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static user17Entities context = new user17Entities();
        public static voditela currentUser;
    }
}
