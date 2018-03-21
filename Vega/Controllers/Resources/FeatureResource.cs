using System.Collections.Generic;

namespace Vega.Controllers.Resources
{
    public class FeatureResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<VehicleFeatureResource> VehicleFeatures { get; set; }

    }
}