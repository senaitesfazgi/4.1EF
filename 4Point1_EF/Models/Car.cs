using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _4Point1_EF.Models
{
    [Table("car")]
    public partial class Car
    {
        [Key]
        [Column("ID", TypeName = "int(10)")]
        public int Id { get; set; }
        [Column("ManufacturerID", TypeName = "int(10)")]
        public int ManufacturerID { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Model { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Colour { get; set; }

        [ForeignKey(nameof(ManufacturerID))]
        [InverseProperty("Cars")]
        public virtual Manufacturer Manufacturer { get; set; }
    }
}
