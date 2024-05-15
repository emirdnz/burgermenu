using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamburgermenu.entites
{
    public class BaseClass 
    {
        [Key]
        [Column(Order =1)]
        public int Id { get; set; }
       
        [Required]
        [Column(Order =2)]      
        public string Name { get; set; }    

        public string? Description { get; set; }
        
        
        [Required]
        [Column(Order = 3)]
        public int Price { get; set; }  

     }
}
