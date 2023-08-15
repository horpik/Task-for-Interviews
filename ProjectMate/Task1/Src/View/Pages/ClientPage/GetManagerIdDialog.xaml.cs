using System.Windows;

namespace Task1.View.Pages.ClientPage
{
    public partial class GetManagerIdDialog : Window
    {
        public GetManagerIdDialog()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        public string IdManager => IdManagerBox.Text;
    }
}