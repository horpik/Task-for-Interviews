using System.Collections.Generic;
using System.Windows;

namespace Task1.View.Pages.ProductPage
{
    public partial class DeleteProductDialog : Window
    {
        public DeleteProductDialog()
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
                { "product_id", IdBox.Text }
            };

            return result;
        }
    }
}