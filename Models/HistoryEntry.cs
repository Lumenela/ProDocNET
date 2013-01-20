using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProdocNET.Models
{
    public class HistoryEntry
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public String SearchQuery { get; set; }
        [Required]
        public String Link { get; set; }
        [Required]
        public DateTime SearchDate { get; set; }
    }
}