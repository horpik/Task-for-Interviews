using System.Collections.Generic;
using System.Windows;

namespace Task1.View.Pages.ClientPage
{
    public partial class AddClientDialog : Window
    {
        public AddClientDialog()
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
                { "name", NameBox.Text },
                { "status_id", StatusIdBox.Text },
                { "manager_id", ManagerIdBox.Text }
            };
            return result;
        }
    }
}