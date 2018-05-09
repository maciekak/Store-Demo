using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StoreDemo.Models
{
    public class OrderModel
    {
        [Key]
        public int Id { get; set; }

        public decimal PriceForAll { get; set; }
        public bool Realised { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual ClientModel Client { get; set; }
        [ForeignKey("Product")]
        public int ProductId  { get; set; }
        public virtual ProductModel Product { get; set; }
    }
}