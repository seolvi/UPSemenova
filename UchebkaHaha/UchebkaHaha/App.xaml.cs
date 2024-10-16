using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UchebkaHaha.Base;

namespace UchebkaHaha
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static UPSemenovaEntities1 db = new UPSemenovaEntities1();
        public static MainWindow mainWindow;
        public static User currentUser;
    }
}
