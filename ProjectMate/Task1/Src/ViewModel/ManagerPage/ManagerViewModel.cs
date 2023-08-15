using System.Collections.Generic;

namespace Task1.ViewModel.ManagerPage
{
    public class ManagerViewModel : PagesViewModel
    {
        public ManagerViewModel()
        {
            ManagerEventManager.ShowAllManager += ShowAllManagers;
            ManagerEventManager.AddManager += AddManager;
            ManagerEventManager.DeleteManager += DeleteManager;
            ManagerEventManager.UpdateManager += UpdateManager;
        }

        private void ShowAllManagers(Dictionary<string, string> inputDictionary)
        {
            
            string commandStr = "SELECT * FROM manager";

            Table = _model.GetTable(commandStr);
        }

        private void AddManager(Dictionary<string, string> inputDictionary)
        {
            var commandStr = $"INSERT INTO manager VALUES ('{inputDictionary["name"]}')";
            _model.ExecuteRequest(commandStr);
        }

        private void UpdateManager(Dictionary<string, string> inputDictionary)
        {
            var updatedData = ConnectStringForUpdate(inputDictionary, "manager_id");
            var commandStr = $"UPDATE manager SET {updatedData} WHERE manager_id = {inputDictionary["manager_id"]}";
            _model.ExecuteRequest(commandStr);
        }

        private void DeleteManager(Dictionary<string, string> inputDictionary)
        {
            var commandStr = $"DELETE manager WHERE manager_id = {inputDictionary["manager_id"]}";
            _model.ExecuteRequest(commandStr);
        }
    }
}