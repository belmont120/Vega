using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Vega.Controllers.Resources
{
    public class MakeResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ModelResource> Models { get; set; }
        public ICollection<VehicleResource> Vehicles { get; set; }

        public MakeResource()
        {
            this.Models = new Collection<ModelResource>();
        }        
    }
}