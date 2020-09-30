using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Begginers_Mod01.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required, StringLength(25)]
        public string Name { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
