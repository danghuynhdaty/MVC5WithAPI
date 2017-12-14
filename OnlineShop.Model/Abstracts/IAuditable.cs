using System;

namespace OnlineShop.Model.Abstracts
{
    /// <summary>
    /// class dùng để chưa các thuộc tính dùng chung cho nhiều bảng
    /// </summary>
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
    }
}