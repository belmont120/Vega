using System.Collections.Generic;

namespace Vega.Controllers.Resources
{
    public class ContactResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public ICollection<VehicleResource> Vehicles { get; set; }
    }
}