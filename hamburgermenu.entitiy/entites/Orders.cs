using hamburgermenu.entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamburgermenu.entitiy.entites
{
    public class Orders
    {
        public int ID { get; set; }
        public string Menu { get; set; }
        public string Soslar { get; set; }
        public string Boyut { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime ADDTime { get; set; }


    }

}
