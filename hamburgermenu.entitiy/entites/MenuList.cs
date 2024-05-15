using hamburgermenu.entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamburgermenu.entitiy.entites
{
    public class MenuList 
    {
        public  int  ID { get; set; }

        public ICollection<HamburgerMenuName> menuler { get; set; }

        public ICollection<Sauce> soslar { get; set; }

        public ICollection<Drinks> icecekler { get; set; }
    }
}
