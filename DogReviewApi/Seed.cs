using DogReviewApi.Data;
namespace DogReviewApi.Models
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.DogOwners.Any())
            {
                var DogOwners = new List<DogOwner>()
                {
                    new DogOwner()
                    {
                        Dog = new Dog()
                        {
                            Name = "Pit bull",
                            BirthDate = new DateTime(1965,3,10),
                            DogCategories = new List<DogCategory>()
                            {
                                new DogCategory { Category = new Category() { Name = "Midle"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title="Pit bull",Text = "Pit bull is the best Dog.", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title="Pit bull", Text = "Pit bull is the best!", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title="Pit bull",Text = "Pit bull, Pitbull.", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Jack",
                            LastName = "London",
                            Gym = "Brocks Gym",
                            Country = new Country()
                            {
                                Name = "Kanto"
                            }
                        }
                    },
                    new DogOwner()
                    {
                        Dog = new Dog()
                        {
                            Name = "Spitz",
                            BirthDate = new DateTime(1953,11,5),
                            DogCategories = new List<DogCategory>()
                            {
                                new DogCategory { Category = new Category() { Name = "Small"}}
                            },
                            Reviews = new List<Review>()
                            {
                                new Review { Title= "Spitz", Text = "Spitz is the best Dog, because it is small.", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Teddy", LastName = "Smith" } },
                                new Review { Title= "Spitz",Text = "Spitz is the best.", Rating = 5,
                                Reviewer = new Reviewer(){ FirstName = "Taylor", LastName = "Jones" } },
                                new Review { Title= "Spitz", Text = "Spitz, Spitz, Spitz.", Rating = 1,
                                Reviewer = new Reviewer(){ FirstName = "Jessica", LastName = "McGregor" } },
                            }
                        },
                        Owner = new Owner()
                        {
                            FirstName = "Harry",
                            LastName = "Potter",
                            Gym = "Mistys Gym",
                            Country = new Country()
                            {
                                Name = "Saffron City"
                            }
                        }
                    }
                };
                dataContext.DogOwners.AddRange(DogOwners);
                dataContext.SaveChanges();
            }
        }
    }
}