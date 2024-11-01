using Ses2._1.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ses2._1.AppData
{
    internal class AuthorizationHelper
    {

        public static bool CheckData(string login, string password)
        {
            // получаем одну запись по условию из таблицы БД
            App.currentUser = App.context.voditela.FirstOrDefault(u => u.FIO == login && u.number == password);
            if (App.currentUser != null)
            {         // генерация капчи
                      // если True, то открываем страницу
                SelectionWindow selectionWindow = new SelectionWindow();
                selectionWindow.Show();
                
                return true;
            }
            return false;
        }

        //public static bool BusData(string login, string password)
        //{
            
        //}
    }
}
