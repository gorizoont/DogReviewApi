using DogReviewApi.Data;
using DogReviewApi.Interfaces;
using DogReviewApi.Models;

namespace DogReviewApi.Repository
{
    public class DogRepository : IDogRepository
    {
        private readonly DataContext _context;

        public DogRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Dog> GetDogs()
        {
            return _context.Dog.OrderBy(d => d.Id).ToList();
        }

        public Dog GetDog(int id)
        {
            return _context.Dog.Where(d => d.Id == id).FirstOrDefault();
        }

        public Dog GetDog(string name)
        {
            return _context.Dog.Where(d => d.Name == name).FirstOrDefault();
        }

        public decimal GetDogRating(int dogId)
        {
            var review = _context.Reviews.Where(d => d.Dog.Id == dogId);
            if (review.Count() <= 0)
            {
                return 0;
            }
            return ((decimal)review.Sum(r => r.Rating) / review.Count());
        }

        public bool DogExists(int dogId)
        {
            return _context.Dog.Any(p => p.Id == dogId);
        }


    }
}
