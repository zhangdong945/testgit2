namespace testgit2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class book
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string title { get; set; }

        [Key]
        [Column(Order = 3)]
        public double price { get; set; }

        [StringLength(50)]
        public string description { get; set; }

        public int? salesAmount { get; set; }
    }
}
