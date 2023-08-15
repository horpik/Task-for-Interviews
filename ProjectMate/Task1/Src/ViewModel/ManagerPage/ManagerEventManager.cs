using System.Collections.Generic;

namespace Task1.ViewModel.ManagerPage
{
    public static class ManagerEventManager
    {
        public delegate void Manager(Dictionary<string, string> inputDictionary);

        public static event Manager ShowAllManager;
        public static event Manager AddManager;
        public static event Manager DeleteManager;
        public static event Manager UpdateManager;

        public static void OnShowAllManager(Dictionary<string, string> inputDictionary)
        {
            ShowAllManager?.Invoke(inputDictionary);
        }

        public static void OnAddManager(Dictionary<string, string> inputDictionary)
        {
            AddManager?.Invoke(inputDictionary);
        }

        public static void OnUpdateManager(Dictionary<string, string> inputDictionary)
        {
            UpdateManager?.Invoke(inputDictionary);
        }

        public static void OnDeleteManager(Dictionary<string, string> inputDictionary)
        {
            DeleteManager?.Invoke(inputDictionary);
        }
    }
}