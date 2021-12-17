using Microsoft.Win32;
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

namespace Кафе.Admin
{
    /// <summary>
    /// Логика взаимодействия для Administrator.xaml
    /// </summary>
    public partial class Administrator : Window
    {        

        public Administrator()
        {
            InitializeComponent();
        }
               private MediaPlayer myla = new MediaPlayer();


        private void Back(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void Jami_Jami(object sender, RoutedEventArgs e)
        {
            myla.Open(new Uri(@"D:\3 Курс\ИТПСИС\Кафе\Кафе\Кафе\Resources\myla_01.mp3"));
            myla.Play();
        }

        ///////////////////////////////////////////////////////////////////////////////
        //Сорудники
        
        private void Open_click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog ofdPicture = new OpenFileDialog();
            ofdPicture.Filter =
            "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            ofdPicture.FilterIndex = 1;

            if (ofdPicture.ShowDialog() == true)
                Foto.Source = new BitmapImage(new Uri(ofdPicture.FileName));
            

        }

        private void FileDropPanel_Drop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //Image[] image = (Image[])e.Data.GetData(DataFormats.FileDrop);
               // Path.GetFileName;
            }
        }





        private void Open_click_cotract(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofdPicture = new OpenFileDialog();
            ofdPicture.Filter =
            "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            ofdPicture.FilterIndex = 1;

            if (ofdPicture.ShowDialog() == true)
                Foto_cotract.Source = new BitmapImage(new Uri(ofdPicture.FileName));
        }

        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        
        /////////////////////////////////////////////////////////////////////////////////
        //Солики
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }
        /////////////////////////////////////////////////////////////////////////////////////
        //Заказы

        private void paid(object sender, RoutedEventArgs e)
        {

        }

        private void pay(object sender, RoutedEventArgs e)
        {

        }

        private void not_paid(object sender, RoutedEventArgs e)
        {

        }

      










        /////////////////////////////////////////////////////////////////////////////////////////////////
        ///Смены
    }
}
