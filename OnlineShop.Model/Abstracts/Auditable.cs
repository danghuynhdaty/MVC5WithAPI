using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Model.Abstracts
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { get; set; }

        [MaxLength(256)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
         
        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        [Required]
        public bool Status { get; set; }

        [MaxLength(256)]
        public string MetaKeyWord { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }
    }
}