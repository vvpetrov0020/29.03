using System;
using System.IO;
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

namespace Lesson29_Galimova_Petrov
{
    /// <summary>
    /// Логика взаимодействия для UsersWindow.xaml
    /// </summary>
    public partial class UsersWindow : Window
    {
        string path = @"C:\Users\WSR\source\repos\Lesson29_Galimova_Petrov\less.txt";
        List<Users> users = new List<Users>();

        public UsersWindow()
        {
            InitializeComponent();
            
           
            dgUser.ItemsSource = users;


        }
    }
}
