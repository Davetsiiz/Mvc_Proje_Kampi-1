using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }


        //ilişkiler
        //1--Icollection(category)
        //sonsuz(çok)---virtual veya Propert isimide olbilir(Heading)



        public ICollection<Heading> Headings { get; set; } //1--sonsuz

    }
}