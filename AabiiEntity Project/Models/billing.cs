namespace AabiiEntity_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("billing")]
    public partial class billing
    {
        public int id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        public int? cost { get; set; }
    }
}
