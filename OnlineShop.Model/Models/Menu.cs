using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Model.Models
{
    [Table("Menu")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // thuộc tính tự tăng
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        [Required]
        public int GroupID { get; set; }


        public string Target { get; set; }

        [Required]
        public bool Status { get; set; }




        /// <summary>
        /// khóa ngoại cho bảng này
        /// GroupID là khóa ngoại
        /// </summary>
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { get; set; }
    }
}