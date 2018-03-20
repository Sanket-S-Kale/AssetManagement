﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssetManagement.Models.AssetManagement
{
    public class Facility : BaseEntity
    {
        [Key]
        public int FacilityId { get; set; }

        [Required]
        public string FacilityName { get; set; }

        public string Landmark { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [MaxLength(5)]
        public string ZipCode { get; set; }

        public List<Resource> Resources { get; set; }

        [Required]
        //[System.ComponentModel.DefaultValue(true)]
        public Boolean IsActive { get; set; }

    }
}