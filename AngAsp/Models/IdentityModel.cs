using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace AngAsp.Models
{
    public class IdentityDBContext : DbContext 
    {
        public DbSet<FModel> MyModel { get; set; }
    }
}   