using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssetManagement.Models.AssetManagement
{
    public class Resource: BaseEntity
    {
        [Key]
        public int ResourceId { get; set; }

        [Required]
        public string ResourceName { get; set; }

        [Required]
        public string Quantity { get; set; }

        [Required]
        public string Description { get; set; }

        public string Size { get; set; }

        public string Color { get; set; }

        [Required]
        //[System.ComponentModel.DefaultValue(true)]
        public Boolean IsActive { get; set; }

        public int FacilityId { get; set; }
        public Facility Facility { get; set; }

    }
}