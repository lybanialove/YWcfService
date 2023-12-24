
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Service.Entitys
{
    public class Order
    {
        [Key]
        public int id { get; set; }
        public string adress { get; set; }
        public string numbers { get; set; }
        public List<Product> products { get; set; }
    }
}
