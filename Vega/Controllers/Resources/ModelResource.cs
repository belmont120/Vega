using System.Collections.Generic;

namespace Vega.Controllers.Resources
{
    public class ModelResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MakeResource Make { get; set; }
        public ICollection<VehicleResource> Vehicles { get; set; }        
    }
}