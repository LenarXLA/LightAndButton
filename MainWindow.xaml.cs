using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace LightAndButton
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        //Не стал выносить отдельно в класс - ради простоты примера
        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (lamp.Fill == Brushes.Gray)
            {
                lamp.Fill = Brushes.Yellow;
            }
            else
            {
                lamp.Fill = Brushes.Gray;
            }
        }
    }
}