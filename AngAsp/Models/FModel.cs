using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngAsp.Models
{
    public class FModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}