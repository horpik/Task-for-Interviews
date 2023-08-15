using System.Collections.Generic;

namespace Task1.ViewModel.ProductPage
{
    public class ProductViewModel : PagesViewModel
    {
        public ProductViewModel()
        {
            ProductEventManager.ShowAllProduct += ShowAllProducts;
            ProductEventManager.AddProduct += AddProduct;
            ProductEventManager.DeleteProduct += DeleteProduct;
            ProductEventManager.UpdateProduct += UpdateProduct;
        }

        private void ShowAllProducts(Dictionary<string, string> inputDictionary)
        {
            string commandStr = "SELECT product_id, name, price, type_name, period_name " +
                                "FROM product pr " +
                                "INNER JOIN subscription_period sp ON pr.period_id = sp.period_id " +
                                "INNER JOIN subscription_type st ON pr.type_id = st.type_id";
            Table = _model.GetTable(commandStr);
        }

        private void AddProduct(Dictionary<string, string> inputDictionary)
        {
            var commandStr = $"INSERT INTO product VALUES " +
                             $"('{inputDictionary["name"]}', '{inputDictionary["price"]}', " +
                             $"'{inputDictionary["type_id"]}', '{inputDictionary["period_id"]}')";
            _model.ExecuteRequest(commandStr);
        }

        private void UpdateProduct(Dictionary<string, string> inputDictionary)
        {
            var updatedData = ConnectStringForUpdate(inputDictionary, "product_id");
            var commandStr = $"UPDATE product SET {updatedData} WHERE product_id = '{inputDictionary["product_id"]}'";
            _model.ExecuteRequest(commandStr);
        }

        private void DeleteProduct(Dictionary<string, string> inputDictionary)
        {
            var commandStr = $"DELETE FROM product WHERE product_id = '{inputDictionary["product_id"]}';";
            _model.ExecuteRequest(commandStr);
        }
    }
}