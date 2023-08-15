using System.Collections.Generic;

namespace Task1.ViewModel.ClientPage
{
    public static class ClientEventManager
    {
        public delegate void Client(Dictionary<string, string> inputDictionary);

        public static event Client ShowAllClient;
        public static event Client ShowClientByManager;
        public static event Client ShowClientByStatus;
        public static event Client AddClient;
        public static event Client DeleteClient;
        public static event Client UpdateClient;

        public static void OnShowAllClient(Dictionary<string, string> inputDictionary)
        {
            ShowAllClient?.Invoke(inputDictionary);
        }

        public static void OnShowClientByManager(Dictionary<string, string> inputDictionary)
        {
            ShowClientByManager?.Invoke(inputDictionary);
        }

        public static void OnShowClientByStatus(Dictionary<string, string> inputDictionary)
        {
            ShowClientByStatus?.Invoke(inputDictionary);
        }

        public static void OnAddClient(Dictionary<string, string> inputDictionary)
        {
            AddClient?.Invoke(inputDictionary);
        }

        public static void OnDeleteClient(Dictionary<string, string> inputDictionary)
        {
            DeleteClient?.Invoke(inputDictionary);
        }

        public static void OnUpdateClient(Dictionary<string, string> inputdictionary)
        {
            UpdateClient?.Invoke(inputdictionary);
        }
    }
}