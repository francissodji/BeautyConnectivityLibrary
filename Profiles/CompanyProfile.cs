using AutoMapper;
using ConnectivityLibrary.Dtos;
using ConnectivityLibrary.Models;

namespace BeautyWebAPI.Profiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<CompanyLibrary, CompanyLibraryReadDto>();

            CreateMap<CompanyLibraryCreateDto, CompanyLibrary>();

            CreateMap<CompanyLibraryUpdateDto, CompanyLibrary>();

            CreateMap<CompanyLibrary, CompanyLibraryUpdateDto>();

        }
    }
}
