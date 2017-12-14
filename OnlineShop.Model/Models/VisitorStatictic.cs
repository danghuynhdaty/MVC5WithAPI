using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Model.Models
{
    [Table("VisitorStatictics")]
    public class VisitorStatictic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // thuộc tính tự tăng
        public int ID { get; set; }

        [Required]
        public DateTime VistedDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string IpAddress { get; set; }
    }
}