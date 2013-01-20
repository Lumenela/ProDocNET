using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProdocNET.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id {get; set;}
        [Required]
        public String Name {get; set;}
        public long ParentId {get; set;}
        public List<Category> Children { get; set; }
    }
}