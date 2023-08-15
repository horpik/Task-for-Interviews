using System.Collections.Generic;

namespace Task1.ViewModel.ClientPage
{
    public class ClientViewModel : PagesViewModel
    {
        public ClientViewModel()
        {
            ClientEventManager.ShowAllClient += ShowALlClients;
            ClientEventManager.ShowClientByManager += ShowClientByManager;
            ClientEventManager.ShowClientByStatus += ShowClientByStatus;
            ClientEventManager.AddClient += AddClient;
            ClientEventManager.DeleteClient += DeleteClient;
            ClientEventManager.UpdateClient += UpdateClient;
        }

        private void ShowALlClients(Dictionary<string, string> inputDictionary)
        {
            string commandStr =
                "SELECT client_id, client.name, status_name, client.manager_id, m.name AS 'Manager name' " +
                "FROM client " +
                "INNER JOIN client_status cs ON client.status_id = cs.status_id " +
                "INNER JOIN manager m on m.manager_id = client.manager_id";
            Table = _model.GetTable(commandStr);
        }

        private void ShowClientByManager(Dictionary<string, string> inputDictionary)
        {
            string commandStr =
                "SELECT client_id, client.name, status_name, client.manager_id, m.name AS 'Manager name' " +
                "FROM client " +
                "INNER JOIN client_status cs ON client.status_id = cs.status_id " +
                "INNER JOIN manager m on m.manager_id = client.manager_id " +
                "WHERE client.manager_id = " + inputDictionary["id"];

            Table = _model.GetTable(commandStr);
        }

        private void ShowClientByStatus(Dictionary<string, string> inputDictionary)
        {
            string commandStr =
                "SELECT client_id, client.name, status_name, client.manager_id, m.name AS 'Manager name' " +
                "FROM client " +
                "INNER JOIN client_status cs ON client.status_id = cs.status_id " +
                "INNER JOIN manager m on m.manager_id = client.manager_id " +
                "WHERE client.status_id = " + inputDictionary["id"];

            Table = _model.GetTable(commandStr);
        }

        private void AddClient(Dictionary<string, string> inputDictionary)
        {
            var commandStr = $"INSERT INTO client " +
                             $"VALUES ('{inputDictionary["name"]}', '{inputDictionary["status_id"]}', '{inputDictionary["manager_id"]}')";
            _model.ExecuteRequest(commandStr);
        }

        private void UpdateClient(Dictionary<string, string> inputDictionary)
        {
            var updatedData = ConnectStringForUpdate(inputDictionary, "client_id");
            var commandStr =
                $"UPDATE client SET {updatedData} WHERE client_id = {inputDictionary["client_id"]}";
            _model.ExecuteRequest(commandStr);
        }

        private void DeleteClient(Dictionary<string, string> inputDictionary)
        {
            var commandStr =
                $"DELETE FROM client WHERE client_id = {inputDictionary["client_id"]}";
            _model.ExecuteRequest(commandStr);
        }
    }
}