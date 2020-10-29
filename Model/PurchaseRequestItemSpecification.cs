﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RuhunaSupply.Model
{
    public class PurchaseRequestItemSpecification
    {
        public PurchaseRequestItemSpecification()
        { 
            
        }

        [Key]
        public int Id { get; set; }
        public PurchaseRequestItem PurchaseRequestItemId { get; set; }
        public Specification SpecificationId { get; set; }
    }
}
