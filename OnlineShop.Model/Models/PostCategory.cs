using OnlineShop.Model.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public String Name { get; set; }

        [Required]
        [MaxLength(250)]
        public String Alias { get; set; }

        public int? DisplayOrder { get; set; }

        public int? ParentID { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public bool? HomeFlag { get; set; }


        public virtual IEnumerable<Post> Posts  { get; set; }
    }
}