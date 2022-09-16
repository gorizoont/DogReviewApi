using DogReviewApi.Models;

namespace DogReviewApi.Interfaces
{
    public interface IDogRepository
    {
        ICollection<Dog> GetDogs();
        Dog GetDog(int id);
        Dog GetDog(string name);
        decimal GetDogRating(int dogId);
        bool DogExists (int dogId);
    }
}
