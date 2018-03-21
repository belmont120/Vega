using AutoMapper;
using Vega.Controllers.Resources;
using Vega.Models;

namespace Vega.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Contact, ContactResource>();
            CreateMap<Vehicle, VehicleResource>();
            CreateMap<Feature, FeatureResource>();
            CreateMap<VehicleFeature, VehicleFeatureResource>();
        }
    }
}