using AutoMapper;
using ConnectivityLibrary.Dtos;
using ConnectivityLibrary.Models;
using System.Runtime;

namespace BeautyWebAPI.Profiles
{
    public class AssociateProfile: Profile
    {
        public AssociateProfile()
        {
            CreateMap<AssociateLibrary, AssociateLibraryReadDto>();

            CreateMap<AssociateLibraryCreateDto, AssociateLibrary>();

            CreateMap<AssociateLibraryUpdateDto, AssociateLibrary>();

            CreateMap<AssociateLibrary, AssociateLibraryUpdateDto>();

            //CreateMap<Associate, AssociateLibrary>();
            //CreateMap<AssociateLibrary, Associate>();
        }
    }
}
