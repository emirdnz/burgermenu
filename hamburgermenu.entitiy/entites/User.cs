using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamburgermenu.entitiy.entites
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [MaxLength(30)]
        public string Password { get; set; }

        public string? LastName { get; set; }
        [NotMapped]

        public string? FirstName { get; set; }

        public string? FullName
        {
            get 
            {
                return FirstName + " " + LastName;
            }
        }

    }
}
