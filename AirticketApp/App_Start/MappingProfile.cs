using AirticketApp.Dtos;
using AirticketApp.Models;
using AutoMapper;

namespace AirticketApp.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Airport, AirportDto>();
            Mapper.CreateMap<AirportDto, Airport>();
            Mapper.CreateMap<Airport, Airport>();
        }
    }
}