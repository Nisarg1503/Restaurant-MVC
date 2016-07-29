namespace Assignment_3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        public int MenuID { get; set; }

        [Required]
        [StringLength(300)]
        public string MenuName { get; set; }

        [Required]
        [StringLength(150)]
        public string ShortDecs { get; set; }

        public decimal? Rate { get; set; }
    }
}
