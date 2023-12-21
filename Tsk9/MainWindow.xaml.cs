using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tsk9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        


        private void BUT1_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TB1.Text) )
            {
                MessageBox.Show("Ошибка","Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Зашибись",
                        "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
        }
    }
}