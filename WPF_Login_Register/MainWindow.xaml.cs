using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace WPF_Login_Register
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }




  
        private void NewWindow_Click(object sender, RoutedEventArgs e)
        {
            Window1 Resgister = new Window1();
            Resgister.Show();
        }


        private void textBox_PreviewMouseDown(object sender, RoutedEventArgs e)
        {
            SifreLabel.Content = "";
        }

    }

}

