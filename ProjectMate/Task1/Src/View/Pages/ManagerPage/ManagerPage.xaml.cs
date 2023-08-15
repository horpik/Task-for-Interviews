using System.Windows;
using System.Windows.Controls;
using Task1.ViewModel;
using Task1.ViewModel.ManagerPage;

namespace Task1.View.Pages.ManagerPage
{
    public partial class ManagerPage : Page
    {
        public ManagerPage()
        {
            InitializeComponent();
            DataContext = new ManagerViewModel();
            ManagerEventManager.OnShowAllManager(null);
        }

        private void ShowAllManagerButton_OnClick(object sender, RoutedEventArgs e)
        {
            ManagerEventManager.OnShowAllManager(null);
        }

        private void AddManagerButton_OnClick(object sender, RoutedEventArgs e)
        {
            var addManagerDialog = new AddManagerDialog();
            if (addManagerDialog.ShowDialog() == true)
            {
                ManagerEventManager.OnAddManager(addManagerDialog.DataClient());
                ManagerEventManager.OnShowAllManager(null);
            }
            else
            {
                MessageBox.Show("Добавление отменено");
            }
            
        }

        private void EditManagerButton_OnClick(object sender, RoutedEventArgs e)
        {
            var updateManagerDialog = new UpdateManagerDialog();
            if (updateManagerDialog.ShowDialog() == true)
            {
                ManagerEventManager.OnUpdateManager(updateManagerDialog.DataClient());
                ManagerEventManager.OnShowAllManager(null);
            }
            else
            {
                MessageBox.Show("Обновление отменено");
            }
        }

        private void DeleteManagerButton_OnClick(object sender, RoutedEventArgs e)
        {
            var deleteManagerDialog = new DeleteManagerDialog();
            if (deleteManagerDialog.ShowDialog() == true)
            {
                ManagerEventManager.OnDeleteManager(deleteManagerDialog .DataClient());
                ManagerEventManager.OnShowAllManager(null);
            }
            else
            {
                MessageBox.Show("Удаление отменено");
            }
        }
    }
}