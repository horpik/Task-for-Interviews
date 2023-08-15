using System.Windows;

namespace Task1.View.Pages.ClientPage
{
    public partial class GetStatusIdDialog : Window
    {
        public GetStatusIdDialog()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        public string IdStatus => IdStatusBox.Text;
    }
}