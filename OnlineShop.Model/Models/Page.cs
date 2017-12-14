using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Model.Models
{
    [Table("Pages")]
    public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // thuộc tính tự tăng
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        public string Content { get; set; }

        [MaxLength(250)]
        public string MetaDescription { get; set; }

        [MaxLength(250)]
        public string MetaKeyWord { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}