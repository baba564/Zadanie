namespace Raport.Enitity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Raport")]
    public partial class Raport
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Nazwa { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime Data { get; set; }

        [Key]
        [Column(Order = 3)]
        public TimeSpan Godzina { get; set; }

        [Key]
        [Column(Order = 4)]
        public string Użytkownik { get; set; }

        [Key]
        [Column(Order = 5)]
        public string Lokal { get; set; }
    }
}
