using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // thuộc tính tự tăng
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// cái này dùng để lấy ra tất cả các menu có khóa ngoại bằng ID của class này
        /// </summary>
        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}