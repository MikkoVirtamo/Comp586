using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class MoviesList
    {
        [Key]
        public string UserID { get; set; }
        public string Movies { get; set; }
        
    }
}
