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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson29_Galimova_Petrov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path = @"C:\Users\WSR\source\repos\Lesson29_Galimova_Petrov\less.txt";
        public MainWindow()
        {
            InitializeComponent();
            
        }
              

        private void txtName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int line;
            if (int.TryParse(e.Text, out line))
            {
                e.Handled = true;
            }
        }

        private void txtAge_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int line;
            if (!int.TryParse(e.Text, out line))
            {
                e.Handled = true;
            }
                       
        }
        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (txtLastName.Text != null)
            {
                if (txtFirstName.Text != null)
                {
                    if (txtAge.Text != null)
                    {
                        MessageBox.Show($"Фамилия:{txtLastName.Text} \nИмя:{txtFirstName.Text} \nВозраст:{txtAge.Text}");

                        StreamWriter streamWriter = new StreamWriter(path);
                        streamWriter.WriteLine(txtLastName.Text + " " + txtFirstName.Text + " " + txtAge.Text);
                        streamWriter.Close();
                    }
                    else
                    {
                        MessageBox.Show("Введите возраст");
                    }
                }
                else
                {
                    MessageBox.Show("Введите Имя");
                }
            }
            else
            {
                MessageBox.Show("Введите Фамилию");
            }

            
        }
    }
}
