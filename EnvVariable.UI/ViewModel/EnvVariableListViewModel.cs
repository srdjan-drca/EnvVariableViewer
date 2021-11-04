using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using EnvVariable.Data;

namespace EnvVariable.UI.ViewModel
{
    public class EnvVariableListViewModel : ObservableViewModel
    {
        private readonly List<EnvironmentVariable> _environmentVariableList;

        public EnvVariableListViewModel(IEnvironmentVariableProvider environmentVariableProvider)
        {
            _environmentVariableList = environmentVariableProvider.GetAll();
            EnvVariableList = new ObservableCollection<EnvironmentVariable>();

            FillVariableList(_environmentVariableList);
        }

        public ObservableCollection<EnvironmentVariable> EnvVariableList { get; set; }

        private string _searchCriteria = string.Empty;
        public string SearchCriteria
        {
            get => _searchCriteria;
            set
            {
                _searchCriteria = value;
                RaisePropertyChanged(nameof(SearchCriteria));

                FillVariableList(string.IsNullOrWhiteSpace(_searchCriteria)
                    ? _environmentVariableList
                    : _environmentVariableList.Where(x => x.Name.Contains(_searchCriteria)).ToList());
            }
        }

        private void FillVariableList(List<EnvironmentVariable> environmentVariableList)
        {
            EnvVariableList.Clear();

            foreach (EnvironmentVariable envVariable in environmentVariableList)
            {
                EnvVariableList.Add(envVariable);
            }
        }
    }
}
