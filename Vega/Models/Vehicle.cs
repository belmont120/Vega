using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vega.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required]
        public bool isRegistered { get; set; }
        public Make Make { get; set; }
        public int MakeId { get; set; }
        public Model Model { get; set; }
        public int ModelId { get; set; }
        public Contact Contact { get; set; }
        public int ContactId { get; set; }
        public DateTime LastUpdate { get; set; }
        public ICollection<VehicleFeature> VehicleFeatures { get; set; }
    }
}