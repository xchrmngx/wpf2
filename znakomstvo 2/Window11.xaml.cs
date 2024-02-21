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

namespace znakomstvo_2
{
    /// <summary>
    /// Логика взаимодействия для Window11.xaml
    /// </summary>
    public partial class Window11 : Window
    {
        public Window11()
        {
            InitializeComponent();

        }
        private void ChangeBackgroundColor_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Color.FromRgb(128, 0, 255));
            statusText.Text = "Изменен цвет фона";
        }

        private void AboutDeveloper_Click(object sender, RoutedEventArgs e)
        {
          MessageBox.Show("Имя разработчика: Ситников", "О разработчике");
            statusText.Text = "Информация о разработчике";
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            statusText.Text = "Закрыто окно";
        }
    }
}
    

