using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabWork_MAUI_App.sln.Model;
using LabWork_MAUI_App.sln.Services;

namespace LabWork_MAUI_App.sln.ViewModel
{
    internal class BarberViewModel
    {
        private Barber _selectedbarber;

        private BarberService _barberService = new();

        public ObservableCollection<Barber> Barbers { get; } = new();

        public BarberViewModel()
        {
            _ = GetBarbers();
        }

        public Barber SelectedBarber
        {
            get => _selectedbarber;
            set => _selectedbarber = value;
        }

        async Task GetBarbers()
        {
            IEnumerable<Barber> barbers = await _barberService.GetBarbersAsync();

            if (Barbers.Count != 0)
                Barbers.Clear();
            foreach (Barber barber in barbers)
                Barbers.Add(barber);
        }
    }
}
