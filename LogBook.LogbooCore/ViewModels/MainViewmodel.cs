using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Logbook.Lib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.LogbookCore.ViewModels
{
    public partial class MainViewmodel(IRepository repository) : ObservableObject
    {
        public string Header => "Fahrtenbuch";
        IRepository _repository = repository;

        [ObservableProperty]
        ObservableCollection<Logbook.Lib.Entry> _entries = [];

        [ObservableProperty]
        Logbook.Lib.Entry _selectedEntry = null;

        #region Properties
        [ObservableProperty]
        DateTime _start = DateTime.Now;

        [ObservableProperty]
        DateTime _end = DateTime.Now;

        [ObservableProperty]
        [NotifyCanExecuteChangedForAttribute(nameof(AddCommand))]
        string _description = string.Empty;

        [ObservableProperty]
        string _numberplate = string.Empty;

        [ObservableProperty]
        int _startKM = 0;

        [ObservableProperty]
        int _endKM = 0;

        [ObservableProperty]
        string _from = string.Empty;

        [ObservableProperty]
        string _to = string.Empty;

        #endregion





        [RelayCommand]
        void LoadData()
        {
            var entries = _repository.GetAll();

            foreach (var entry in entries)
            {
                Entries.Add(entry);
            }
        }

        private bool CanAdd => this.Description.Length > 0;

        [RelayCommand(CanExecute = nameof(CanAdd))]
        void Add()
        {
            /*
            Logbook.Lib.Entry entrySaalfelden = new(DateTime.Now.AddDays(3), DateTime.Now.AddDays(3).AddMinutes(20),
                                  25500, 25514, "ZE-XYZ123", "Zell am See", "Saalfelden")
            {
                Description = "Fahrt nach Saalfelden"
            };*/

            Logbook.Lib.Entry entry = new(this.Start, this.End, this.StartKM, this.EndKM, this.Numberplate, this.From, this.To);
            var result = _repository.Add(entry);
            if (this.Description.Length > 0) 
            {
                entry.Description = this.Description;
            }
            if (result)
            {
                this.Entries.Add(entry);
                this.Description = string.Empty;
                this.From = "";
                this.To = "";
                this.StartKM = this.EndKM;
                this.EndKM = 0;
            }
        }
    }
}
