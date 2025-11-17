using Api.W.Movies.Backend.DAL.Entities;
using Api.W.Movies.Backend.DAL.Entities.Dtos;
using AutoMapper;

namespace Api.W.Movies.Backend.MoviesMappers;

public class Mappers : Profile
{
    public Mappers()
    {
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Category, CategoryCreateDto>().ReverseMap();
    }
}