using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingId { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
       
        public DateTime HeadingDate { get; set; }

        //ilişki category 
        public int CategoryId { get; set; } //db yesutun olarak ekledik
        public virtual Category Category { get; set; }//sonsuz

        //ilişki content
        public ICollection<Content> Contents { get; set; } //1-

        //ilişki writer
        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }  //sonsuz--
    }
}