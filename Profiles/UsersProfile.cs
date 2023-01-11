using AutoMapper;
using ConnectivityLibrary.Dtos;
using ConnectivityLibrary.Models;
using ConnectivityLibrary.ModelsHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BeautyWebAPI.Profiles
{
    public class UsersProfile: Profile
    {

        public UsersProfile()
        {
            CreateMap<UserLibrary, UserLibraryReadDto>();

            CreateMap<UserLibraryCreateDto, UserLibrary>();

            CreateMap<UserLibraryUpdateDto, UserLibrary>();

            CreateMap<UserLibrary, UserLibraryUpdateDto>();

            CreateMap<UserLoginReadDto, UserResponsDto>();


            //Client
            CreateMap<UserClientInCompanyLibrary, UserCreated>();

            CreateMap<UserCreated, UserClientInCompanyLibrary>();

            //Associate
            CreateMap<UserAssociateInCompanyLibrary, UserCreated>();

            CreateMap<UserCreated, UserAssociateInCompanyLibrary>();


            CreateMap<UserAssociateInCompanyLibrary, UserCreated>();
            CreateMap<UserClientInCompanyLibrary, UserCreated>();

            //Register
            CreateMap<RegisterLibrary, RegisterLibraryCreateDto>();

            CreateMap<RegisterLibraryCreateDto, RegisterLibrary>();
        }



    }
}
