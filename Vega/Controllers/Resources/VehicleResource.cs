using System.Collections.Generic;

namespace Vega.Controllers.Resources
{
    public class VehicleResource
    {
        public int Id { get; set; }
        public bool isRegistered { get; set; }
        public MakeResource Make { get; set; }
        public ModelResource Model { get; set; }
        public ContactResource Contact { get; set; }
        public ICollection<VehicleFeatureResource> VehicleFeatures { get; set; }        
    }
}