﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Concierge.Models.Enums;

namespace Concierge.Models
{
   public  class Buildings
    {

        public int Id { get; set; }

        public BuildingTypeEnum Type { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }



    }
}
