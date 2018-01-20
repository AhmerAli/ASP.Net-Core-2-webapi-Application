using server.Models;
using AutoMapper;
 

namespace server.ViewModels.Mappings
{
    public class ViewModelToEntityMappingProfile : Profile
    {
        public ViewModelToEntityMappingProfile()
        {
            CreateMap<RegistrationViewModel, EmployeeProfile>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
        }
    }
}