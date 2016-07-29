namespace Assignment_3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FullDish")]
    public partial class FullDish
    {
        [Key]
        public int MenuID { get; set; }

        [Required]
        [StringLength(300)]
        public string MenuName { get; set; }

        [Required]
        [StringLength(500)]
        public string DetailedDecs { get; set; }

        public decimal Rate { get; set; }
    }
}
