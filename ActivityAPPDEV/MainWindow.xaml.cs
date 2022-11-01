using MaterialDesignThemes.Wpf;
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

namespace ActivityAPPDEV
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

        private void FCUBE_Click(object sender, RoutedEventArgs e)
        {

            
        }

        private void Area_Click(object sender, RoutedEventArgs e)
        {
            cube f2 = new cube();
            f2.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void Diameter_Click(object sender, RoutedEventArgs e)
        {
            DIAMETER f2 = new DIAMETER();
            f2.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void Sw_Click(object sender, RoutedEventArgs e)
        {
            HEIGHT f2 = new HEIGHT();
            f2.Show();
            this.Visibility = Visibility.Hidden;
        }

        private void Sh_Click(object sender, RoutedEventArgs e)
        {
            BASE f2 = new BASE();
            f2.Show();
            this.Visibility = Visibility.Hidden;
        }
    }
}
