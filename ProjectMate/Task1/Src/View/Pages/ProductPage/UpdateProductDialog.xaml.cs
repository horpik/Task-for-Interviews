using System.Collections.Generic;
using System.Windows;

namespace Task1.View.Pages.ProductPage
{
    public partial class UpdateProductDialog : Window
    {
        public UpdateProductDialog()
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
            if (NameBox.Text != "Введите имя")
            {
                result.Add("name", NameBox.Text);
            }

            if (PriceBox.Text != "Введите цену")
            {
                result.Add("price", PriceBox.Text);
            }

            if (TypeBox.Text != "Введите type_id")
            {
                result.Add("type_id", TypeBox.Text);
            }

            if (PeriodBox.Text != "Введите period_id")
            {
                result.Add("period_id", PeriodBox.Text);
            }


            return result;
        }
    }
}