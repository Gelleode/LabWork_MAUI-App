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
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
                new Barber{ Id = 1, Name = "Даниил", Rating = 5, RatingCounter = 149, PhotoPath = "daniil.png"},
            };
        }

        public async Task<IEnumerable<Barber>> GetBarbersAsync(bool forceRefresh = false)
        { 
            return await Task.FromResult(_barbers);
        }
    }
}
