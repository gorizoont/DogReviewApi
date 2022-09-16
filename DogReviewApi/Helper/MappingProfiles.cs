using AutoMapper;
using DogReviewApi.DTO;
using DogReviewApi.Models;

namespace DogReviewApi.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Dog, DogDTO>();
        }
    }
}
