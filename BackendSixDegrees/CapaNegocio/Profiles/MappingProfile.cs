using AutoMapper;
using CapaNegocio.Features.User.Queries.GetUsers;
using Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Usuarios
            //Query
            CreateMap<Usuario, ResponseGetUserVm>().ReverseMap();
        }
    }
}
