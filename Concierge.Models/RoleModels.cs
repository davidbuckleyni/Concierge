﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierge.Models
{
    public class RoleModels
    {
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "UserName")]
        public string UserName { get; set; }
    }
}
