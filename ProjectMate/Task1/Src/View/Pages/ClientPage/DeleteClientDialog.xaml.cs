using System.Collections.Generic;
using System.Windows;

namespace Task1.View.Pages.ClientPage
{
    public partial class DeleteClientDialog : Window
    {
        public DeleteClientDialog()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        public Dictionary<string, string> DataClient()
        {
            var result = new Dictionary<string, string>
            {
                { "client_id", IdBox.Text }
            };
            return result;
        }
    }
}