using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Task1.ViewModel
{
    public class PagesViewModel : INotifyPropertyChanged
    {
        protected readonly Model.Model _model;

        private DataTable _table;

        public DataTable Table
        {
            get => _table;
            set
            {
                _table = value;
                OnPropertyChanged();
            }
        }
        protected string ConnectStringForUpdate(Dictionary<string, string> inputDictionary, string notUseKey)
        {
            if (inputDictionary.Count == 1) return null;

            var result = "";
            foreach (var item in inputDictionary.Where(item => item.Key != notUseKey))
            {
                if (result == "")
                {
                    result = item.Key + " = " + "'" + item.Value + "'";
                }
                else
                {
                    result += ", " + item.Key + " = " + "'" + item.Value + "'";
                }
            }

            return result;
        }

        public PagesViewModel()
        {
            var connectionString =
                @"Server=(localdb)\MSSQLLocalDB; Database=db_projectMate; User Id=CHARNELE\\horpi; Trusted_Connection=True;";
            _model = new Model.Model(connectionString);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}