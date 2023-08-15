using System.Windows;
using System.Windows.Controls;
using Task1.ViewModel;
using Task1.ViewModel.ProductPage;

namespace Task1.View.Pages.ProductPage
{
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
            DataContext = new ProductViewModel();
            ProductEventManager.OnShowAllProduct(null);
        }

        private void ShowAllProductButton_OnClick(object sender, RoutedEventArgs e)
        {
            ProductEventManager.OnShowAllProduct(null);
        }

        private void AddProductButton_OnClick(object sender, RoutedEventArgs e)
        {
            var addProductDialog = new AddProductDialog();
            if (addProductDialog.ShowDialog() == true)
            {
                ProductEventManager.OnAddProduct(addProductDialog.DataClient());
                ProductEventManager.OnShowAllProduct(null);
            }
            else
            {
                MessageBox.Show("Добавление отменено");
            }
        }

        private void EditProductButton_OnClick(object sender, RoutedEventArgs e)
        {
            var updateProductDialog = new UpdateProductDialog();
            if (updateProductDialog.ShowDialog() == true)
            {
                ProductEventManager.OnUpdateProduct(updateProductDialog.DataClient());
                ProductEventManager.OnShowAllProduct(null);
            }
            else
            {
                MessageBox.Show("Обновление отменено");
            }
        }

        private void DeleteProductButton_OnClick(object sender, RoutedEventArgs e)
        {
            var deleteProductDialog = new DeleteProductDialog();
            if (deleteProductDialog.ShowDialog() == true)
            {
                ProductEventManager.OnDeleteProduct(deleteProductDialog.DataClient());
                ProductEventManager.OnShowAllProduct(null);
            }
            else
            {
                MessageBox.Show("Удаление отменено");
            }
        }
    }
}