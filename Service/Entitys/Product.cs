using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Entitys
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string manufacturer { get; set; }
    }
}
