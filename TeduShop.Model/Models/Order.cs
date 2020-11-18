﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order:AudiTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerAddress { get; set; }
        [Required]
        [MaxLength(50)]
        public string CustomerPhone { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerMessage { get; set; }
        [Required]
        [MaxLength(256)]
        public string PaymentMethod { get; set; }
        [MaxLength(256)]
        public string PaymentStatus { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
