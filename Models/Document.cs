using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProdocNET.Models
{
    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public String Title { get; set; }
        public String Description { get; set; }
        [Required]
        public String Content { get; set; }
        [Required]
        public DateTime AddedAtDate { get; set; }
        [Required]
        public long CategoryId { get; set; }
    }
}