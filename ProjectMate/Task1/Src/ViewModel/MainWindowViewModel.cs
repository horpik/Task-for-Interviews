using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using Task1.View.Pages.ManagerPage;
using Task1.View.Pages.ProductPage;

namespace Task1.ViewModel
{
    public sealed class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly Page _client;
        private readonly Page _manager;
        private readonly Page _product;

        private Page _currentPage;

        public Page CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value; 
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            _client = new View.Pages.ClientPage.ClientPage();
            _manager = new View.Pages.ManagerPage.ManagerPage();
            _product = new View.Pages.ProductPage.ProductPage();

            EventManager.ChangePageClient += bMenuClient_Click;
            EventManager.ChangePageManager += bMenuManager_Click;
            EventManager.ChangePageProduct += bMenuProduct_Click;

            CurrentPage = _manager;
        }

        private void bMenuClient_Click()
        {
            ChangePage(_client);
        }

        private void bMenuManager_Click()
        {
            ChangePage(_manager);
        }

        private void bMenuProduct_Click()
        {
            ChangePage(_product);
        }

        private void ChangePage(Page page)
        {
            CurrentPage = page;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}