using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Concierge.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }



        public Guid? StoreId { get; set; }

        public string? LastName { get; set; }

        public Guid? TennantId { get; set; }



    }
}
