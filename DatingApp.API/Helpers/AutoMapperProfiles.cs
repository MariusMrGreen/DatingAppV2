using System.Runtime.InteropServices;
using AutoMapper;
using DatingApp.API.Models;
using DatingApp.API.Dtos;
using System.Linq;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User,UserForListDto>()
                .ForMember(x => x.PhotoUrl, opt => opt.MapFrom(x => x.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(x => x.Age, opt => opt.MapFrom(x => x.DateOfBirth.CalculateAge()));
            CreateMap<User,UserForDetailedDto>()
                .ForMember(x => x.PhotoUrl, opt => opt.MapFrom(x => x.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(x => x.Age, opt => opt.MapFrom(x => x.DateOfBirth.CalculateAge()));
            CreateMap<Photo,PhotosForDetailedDto>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<Photo, PhotoForReturnDto>();
            CreateMap<PhotoForCreationDto, Photo>();
        }
    }
}