using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Logbook.Lib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBookMaui.Viewmodels
{
    public partial class MainViewmodel(IRepository repository) : ObservableObject
    {
        public string Header => "Fahrtenbuch";
        IRepository _repository = repository;

        ObservableCollection<Logbook.Lib.Entry> _entries = [];

        [RelayCommand]
        void LoadData()
        {

        }
    }
}
