using System.Collections.Generic;
using System.Windows;

namespace Task1.View.Pages.ProductPage
{
    public partial class AddProductDialog : Window
    {
        public AddProductDialog()
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
                { "price", PriceBox.Text },
                { "type_id", TypeBox.Text },
                { "period_id", PeriodBox.Text },
            };

            return result;
        }
    }
}