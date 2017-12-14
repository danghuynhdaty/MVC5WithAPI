using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Model.Models
{
    [Table("ProductCategorys")]
    public class ProductCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // thuộc tính tự tăng
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }
        public string Desciption { get; set; }
        public int? ParentID { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? HomeFlag { get; set; }

        /// <summary>
        /// danh sách các product có khóa ngoại bằng ID này
        /// </summary>
        public virtual IEnumerable<Product> Products { get; set; }
   
    }
}
