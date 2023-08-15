using System.Collections.Generic;
using System.Windows;

namespace Task1.View.Pages.ClientPage
{
    public partial class UpdateClientDialog : Window
    {
        public UpdateClientDialog()
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
            
            if (NameBox.Text != "Введите имя")
            {
                result.Add("name", NameBox.Text);
            }

            if (StatusIdBox.Text != "Введите status_id")
            {
                result.Add("status_id", StatusIdBox.Text);
            }

            if (ManagerIdBox.Text != "Введите manager_id")
            {
                result.Add("manager_id", ManagerIdBox.Text);
            }

            return result;
        }
    }
}