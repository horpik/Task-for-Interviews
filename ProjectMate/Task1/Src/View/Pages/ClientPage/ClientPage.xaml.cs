using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Task1.ViewModel;
using Task1.ViewModel.ClientPage;

namespace Task1.View.Pages.ClientPage
{
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            DataContext = new ClientViewModel();
            ClientEventManager.OnShowAllClient(null);
        }

        private void ShowAllClientButton_OnClick(object sender, RoutedEventArgs e)
        {
            ClientEventManager.OnShowAllClient(null);
        }

        private void ShowClientByStatusButton_OnClick(object sender, RoutedEventArgs e)
        {
            var statusIdDialogWind = new GetStatusIdDialog();
            if (statusIdDialogWind.ShowDialog() == true)
            {
                ClientEventManager.OnShowClientByStatus(new Dictionary<string, string>
                    { { "id", statusIdDialogWind.IdStatus } });
            }
            else
            {
                MessageBox.Show("Статус для вывода не выбран");
            }
        }

        private void ShowClientByManagerButton_OnClick(object sender, RoutedEventArgs e)
        {
            var managerIdDialogWind = new GetManagerIdDialog();
            if (managerIdDialogWind.ShowDialog() == true)
            {
                ClientEventManager.OnShowClientByManager(new Dictionary<string, string>
                    { { "id", managerIdDialogWind.IdManager } });
            }
            else
            {
                MessageBox.Show("Менеджер не выбран");
            }
        }

        private void AddClientButton_OnClick(object sender, RoutedEventArgs e)
        {
            var addClientDialog = new AddClientDialog();
            if (addClientDialog.ShowDialog() == true)
            {
                ClientEventManager.OnAddClient(addClientDialog.DataClient());
                ClientEventManager.OnShowAllClient(null);
            }
            else
            {
                MessageBox.Show("Добавление отменено");
            }
        }

        private void DeleteClientButton_OnClick(object sender, RoutedEventArgs e)
        {
            var deleteClientDialog= new DeleteClientDialog();
            if (deleteClientDialog.ShowDialog() == true)
            {
                ClientEventManager.OnDeleteClient(deleteClientDialog.DataClient());
                ClientEventManager.OnShowAllClient(null);
            }
            else
            {
                MessageBox.Show("Удаление отменено");
            }
        }

        private void EditClientButton_OnClick(object sender, RoutedEventArgs e)
        {
            var updateClientDialog= new UpdateClientDialog();
            if (updateClientDialog.ShowDialog() == true)
            {
                ClientEventManager.OnUpdateClient(updateClientDialog.DataClient());
                ClientEventManager.OnShowAllClient(null);
            }
            else
            {
                MessageBox.Show("Изменение отменено");
            }
        }
    }
}