using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // thuộc tính tự tăng
        public int ID { get; set; }

        [MaxLength(256)]
        public string CustomerName { get; set; }

        [MaxLength(256)]
        public string CustomerAddress { get; set; }

        [MaxLength(256)]
        public string CustomerEmail { get; set; }

        [MaxLength(50)]
        public string CustomerPhone { get; set; }

        [MaxLength(500)]
        public string CustomerMessage { get; set; }

        public DateTime? CreatedDate { get; set; }

        [MaxLength(256)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        [Required]
        public bool Status { get; set; }

        [MaxLength(256)]
        public string PaymentMethod { get; set; }

        [MaxLength(50)]
        public string PaymentStatus { get; set; }



        /// <summary>
        /// list tất cả orderdetail có khóa chính nằm trong class này
        /// </summary>
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }

    }
}