using System.Collections.Generic;

namespace Task1.ViewModel.ProductPage
{
    public static class ProductEventManager
    {
        
        public delegate void Product(Dictionary<string, string> inputDictionary);

        public static event Product ShowAllProduct;
        public static event Product AddProduct;
        public static event Product DeleteProduct;
        public static event Product UpdateProduct;
        public static void OnShowAllProduct(Dictionary<string, string> inputdictionary)
        {
            ShowAllProduct?.Invoke(inputdictionary);
        }

        public static void OnAddProduct(Dictionary<string, string> inputdictionary)
        {
            AddProduct?.Invoke(inputdictionary);
        }

        public static void OnDeleteProduct(Dictionary<string, string> inputdictionary)
        {
            DeleteProduct?.Invoke(inputdictionary);
        }

        public static void OnUpdateProduct(Dictionary<string, string> inputdictionary)
        {
            UpdateProduct?.Invoke(inputdictionary);
        }
    }
}