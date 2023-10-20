using API.Dtos;
using AutoMapper;
using Dominio.Entities;

namespace API.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Rol,RolDto>().ReverseMap();
        CreateMap<Usuario,UsuarioDto>().ReverseMap();


        /*
        
        
        CreateMap<Mascota,MascotaEspecieDto>()
        .ForMember(dest=>dest.Especie,origen=>origen.MapFrom(origen=>origen.Raza.Especie.Nombre))
        .ReverseMap();
        
        
        CreateMap<Medicina,MedicinaPrecioDto>()
        .ReverseMap();


        */
    }
}
