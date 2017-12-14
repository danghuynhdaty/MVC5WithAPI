using OnlineShop.Model.Abstracts;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace OnlineShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // thuộc tính tự tăng
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Alias { get; set; }

        public int CategoryID { get; set; }
        public string Image { get; set; }
        public XElement MoreImage { get; set; }
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; }
        public int? Warranty { get; set; }
        public string Desciption { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int ViewCount { get; set; }

        /// <summary>
        /// khóa ngoại
        /// </summary>
        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }

        /// <summary>
        /// danh sách tất cả orderdetails có khóa chính nằm trong class này
        /// </summary>
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
        /// <summary>
        /// danh sách các  tag liên quan tới sản phẩm
        /// </summary>
        public virtual IEnumerable<PostTag> PostTags { get; set; }
    }
}