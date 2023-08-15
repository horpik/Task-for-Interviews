using System.Windows;
using Task1.ViewModel;

namespace Task1.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void ShowClientButton_OnClick(object sender, RoutedEventArgs e)
        {
            EventManager.OnChangePageClient();
        }

        private void ShowProductButton_OnClick(object sender, RoutedEventArgs e)
        {
            EventManager.OnChangePageProduct();
        }


        private void ShowManagerButton_OnClick(object sender, RoutedEventArgs e)
        {
            EventManager.OnChangePageManager();
        }
    }
}