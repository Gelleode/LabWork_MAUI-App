using LabWork_MAUI_App.sln.Model;

namespace LabWork_MAUI_App.sln.Services
{
    internal class BarberService
    {
        List<Barber> _barbers;

        public BarberService()
        {
            
            _barbers = new List<Barber>
            {
                new Barber{ Id = Convert.ToInt32(Guid.NewGuid()), Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"}
            };
        }

        public async Task<IEnumerable<Barber>> GetBarbersAsync(bool forceRefresh = false)
        { 
            return await Task.FromResult(_barbers);
        }
    }
}
