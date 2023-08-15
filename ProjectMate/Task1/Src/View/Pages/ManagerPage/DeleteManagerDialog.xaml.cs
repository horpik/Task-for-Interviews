using System.Collections.Generic;
using System.Windows;

namespace Task1.View.Pages.ManagerPage
{
    public partial class DeleteManagerDialog : Window
    {
        public DeleteManagerDialog()
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
                
                { "manager_id", IdBox.Text }
            };
            return result;
        }
    }
}