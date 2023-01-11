using AutoMapper;

using ConnectivityLibrary.Dtos;
using ConnectivityLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeautyWebAPI.Profiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<ClientLibrary, ClientLibraryReadDto>();

            CreateMap<ClientLibraryCreateDto, ClientLibrary>();

            CreateMap<ClientLibraryUpdateDto, ClientLibrary>();

            CreateMap<ClientLibrary, ClientLibraryUpdateDto>();

        }
    }
}
