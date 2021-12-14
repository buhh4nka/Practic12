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
using System.Windows.Threading;

namespace Practic12
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
        DispatcherTimer _timer;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _timer = new DispatcherTimer();
            _timer.Tick += Timer_Tick;
            _timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            _timer.IsEnabled = true;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            time.Text = date.ToString("HH:mm");
            this.date.Text = date.ToString("dd.MM.yyyy");
        }
        private void Start1Program_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(aSideOfSquare.Text, out int aSide) && Int32.TryParse(bSideOfSquare.Text, out int bSide))
            {
                perimeter.Text = (aSide * 2 + bSide * 2).ToString();
                square.Text = (aSide * bSide).ToString();
            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                aSideOfSquare.Clear();
                bSideOfSquare.Clear();
                perimeter.Clear();
                square.Clear();
            }
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №12 Назаров Д. ИСП-31. Вариант 2.\nРеализовать расчет задачи:\nДаны стороны прямоугольника a и b. Найти его площадь периметр.\nДано трехзначное число. Вывести число, полученное при прочтении исходного числа справа налево.", "Информация о программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Clear2ProgramFields(object sender, RoutedEventArgs e)
        {
            number.Clear();
            outNumber.Clear();
        }

        private void Clear1ProgramFields(object sender, RoutedEventArgs e)
        {
            aSideOfSquare.Clear();
            bSideOfSquare.Clear();
            perimeter.Clear();
            square.Clear();
        }

        private void Start2Program_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(number.Text, out int initialNumber)) 
            {
                int endNumber = 0;
                while(initialNumber != 0)
                {
                    endNumber = endNumber * 10 + (initialNumber % 10);
                    initialNumber /= 10;
                }
                outNumber.Text = endNumber.ToString();
            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                number.Clear();
                outNumber.Clear();
            }
        }

        private void aSideOfSquare_TextChanged(object sender, TextChangedEventArgs e)
        {
            perimeter.Clear();
            square.Clear();
        }

        private void bSideOfSquare_TextChanged(object sender, TextChangedEventArgs e)
        {
            perimeter.Clear();
            square.Clear();
        }

        private void number_TextChanged(object sender, TextChangedEventArgs e)
        {
            outNumber.Clear();
        }
    }
}
