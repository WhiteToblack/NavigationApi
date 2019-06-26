using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NavigationApp.Model
{  
    public class Menu
    {
        //Menu Adı
        public string Name { get; set; }
        //Menu elemanları
        public string[] Childrens { get; set; }
    }
}
