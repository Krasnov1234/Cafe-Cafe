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
using Кафе.Admin;

namespace Кафе
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Entrance_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text == "1" && password.Password == "1")
            {
                
                Hide();
                Administrator admin = new Administrator();
                admin.Show();
                admin.stol.Visibility = System.Windows.Visibility.Visible;
                admin.sotr.Visibility = System.Windows.Visibility.Visible;

                Close();
            }
        }
    }
}
