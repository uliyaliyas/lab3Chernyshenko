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

namespace lab3Chernyshenko
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LongLong f1 = new LongLong()
            {
                First = long.Parse(FirstOne.Text),
                Second = ulong.Parse(SecondOne.Text)
            };
            LongLong f2 = new LongLong()
            {
                First = long.Parse(FirstTwo.Text),
                Second = ulong.Parse(SecondTwo.Text)
            };
            LongLong res = f1 + f2;
            Result.Text = res.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LongLong f1 = new LongLong()
            {
                First = long.Parse(FirstOne.Text),
                Second = ulong.Parse(SecondOne.Text)
            };
            LongLong f2 = new LongLong()
            {
                First = long.Parse(FirstTwo.Text),
                Second = ulong.Parse(SecondTwo.Text)
            };
            LongLong res = f1 - f2;
            Result.Text = res.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            LongLong f1 = new LongLong()
            {
                First = long.Parse(FirstOne.Text),
                Second = ulong.Parse(SecondOne.Text)
            };
            LongLong f2 = new LongLong()
            {
                First = long.Parse(FirstTwo.Text),
                Second = ulong.Parse(SecondTwo.Text)
            };
            LongLong res = f1 * f2;
            Result.Text = res.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            LongLong f1 = new LongLong()
            {
                First = long.Parse(FirstOne.Text),
                Second = ulong.Parse(SecondOne.Text)
            };
            LongLong f2 = new LongLong()
            {
                First = long.Parse(FirstTwo.Text),
                Second = ulong.Parse(SecondTwo.Text)
            };
            Result.Text = (f1 == f2).ToString();
        }
    }
}