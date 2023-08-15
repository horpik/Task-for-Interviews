using System.Collections.Generic;
using System.Windows;

namespace Task1
{
    public static class EventManager
    {
        public delegate void PageSwitching();

        public static event PageSwitching ChangePageClient;
        public static event PageSwitching ChangePageManager;
        public static event PageSwitching ChangePageProduct;

        public static void OnChangePageClient()
        {
            ChangePageClient?.Invoke();
        }

        public static void OnChangePageManager()
        {
            ChangePageManager?.Invoke();
        }

        public static void OnChangePageProduct()
        {
            ChangePageProduct?.Invoke();
        }
    }
}