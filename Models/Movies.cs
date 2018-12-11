using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Movies
    {
        [Key]
        public string Title { get; set; }
        public string Director { get; set; }
     
    }
}
