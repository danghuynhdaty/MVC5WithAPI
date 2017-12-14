using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int ProductID { get; set; }

        [Key]
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