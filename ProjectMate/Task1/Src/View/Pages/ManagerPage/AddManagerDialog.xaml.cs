using System.Collections.Generic;
using System.Windows;

namespace Task1.View.Pages.ManagerPage
{
    public partial class AddManagerDialog : Window
    {
        public AddManagerDialog()
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
                { "name", NameBox.Text }
            };
            return result;
        }
    }
}