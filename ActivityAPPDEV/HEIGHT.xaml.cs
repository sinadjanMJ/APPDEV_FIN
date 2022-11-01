using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ActivityAPPDEV
{
    /// <summary>
    /// Interaction logic for HEIGHT.xaml
    /// </summary>
    public partial class HEIGHT : Window
    {
        public HEIGHT()
        {
            InitializeComponent();
        }
        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            ITheme theme = paletteHelper.GetTheme();
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }

            paletteHelper.SetTheme(theme);
        }

        private void exitApp(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }

        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void Base_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9^.]+").IsMatch(e.Text);
        }

        private void Area_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9^.]+").IsMatch(e.Text);
        }

        private void Goback_Click(object sender, RoutedEventArgs e)
        {
            MainWindow f2 = new MainWindow();
            f2.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double b, a, r, result;
            b = Double.Parse(@base.Text);
            a = Double.Parse(@area.Text);

            r = b /2;
            result = a / r;
            @height.Text = (result).ToString();
        }
    }
}
