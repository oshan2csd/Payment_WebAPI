using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_WebAPI.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PMId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]//limiting data space required in sql db. By defalt it's nvarchar(max)
        public string CardOwnerName{ get; set; }

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string CardNumber { get; set; }

        [Required]
        [Column(TypeName ="varchar(5)")] // MM/YY
        public string ExpiryDate { get; set; }

        [Required]
        [Column(TypeName = "varchar(3)")]
        public string CVV { get; set; }


    }
}
