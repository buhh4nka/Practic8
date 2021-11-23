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

namespace Practic8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        CargoShip _ship1 = new CargoShip();
        CargoShip _ship2 = new CargoShip();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-31. Назаров Д. Вариант 2. \nСоздать интерфейсы - корабль, грузовой транспорт. Создать класс грузовой корабль. Класс должен включать конструктор, функцию для формирования строки информации о работнике. Сравнение производить по грузоподъемности", "О программе");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ship1Info_Click(object sender, RoutedEventArgs e)
        {
            bool isNotError = Int32.TryParse(ship1loadCapacity.Text, out int capacity);
            if (isNotError)
            {
                _ship1.Name = ship1Name.Text;
                _ship1.LoadCapacity = capacity;
                MessageBox.Show(_ship1.ShowInfo(), "Информация о корабле");
            }
            else MessageBox.Show("Введены некоректные значения, введите другие", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void ship2Info_Click(object sender, RoutedEventArgs e)
        {
            bool isNotError = Int32.TryParse(ship2loadCapacity.Text, out int capacity);
            if (isNotError)
            {
                _ship2.Name = ship2Name.Text;
                _ship2.LoadCapacity = capacity;
                MessageBox.Show(_ship2.ShowInfo(), "Информация о корабле");
            }
            else MessageBox.Show("Введены некоректные значения, введите другие", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void compareShips_Click(object sender, RoutedEventArgs e)
        {
            
            bool isNotErrorInFirst = Int32.TryParse(ship1loadCapacity.Text, out int ship1Capacity);
            bool isNotErrorInSecond = Int32.TryParse(ship2loadCapacity.Text, out int ship2Capacity);
            if (isNotErrorInFirst && isNotErrorInSecond)
            {
                _ship1.Name = ship1Name.Text;
                _ship2.Name = ship2Name.Text;
                _ship1.LoadCapacity = ship1Capacity;
                _ship2.LoadCapacity = ship2Capacity;
                if (_ship1.CompareTo(_ship2) == 1) outCompare.Text = $"Грузоподъёмность первого корабля \"{_ship1.Name}\" больше второго \"{_ship2.Name}\" на {_ship1.LoadCapacity - _ship2.LoadCapacity} кг.";
                else if (_ship1.CompareTo(_ship2) == -1) outCompare.Text = $"Грузоподъёмность второго корабля \"{_ship2.Name}\" больше первого \"{_ship1.Name}\" на {_ship2.LoadCapacity - _ship1.LoadCapacity} кг.";
                else outCompare.Text = $"Грузоподъёмность первого корабля \"{_ship1.Name}\" совпадает с грузоподъёмностью второго \"{_ship1.Name}\" и равняется {_ship1.LoadCapacity} кг."; ;
            }
            else MessageBox.Show("Введены некоректные значения, введите другие", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
