using AutoMapper;

namespace _01WebApi.Profiles;

public class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        CreateMap<Entities.Employee, Models.EmployeeDto>();
        CreateMap<Models.RequestModels.EmployeeRequestModelDto, Entities.Employee>();
    }
}