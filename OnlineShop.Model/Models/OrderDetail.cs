using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [Column(Order =1)]
        public int ProductID { get; set; }

        [Key]
        [Column(Order = 2)]
        public int OrderID { get; set; }

        public int Wantity { get; set; }
        public decimal Cost { get; set; }

        #region Khóa ngoại

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }

        #endregion Khóa ngoại
    }
}