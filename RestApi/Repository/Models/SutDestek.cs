using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApi.Repository.Models
{
    [Table("SutDestek")]
    public partial class SutDestek
    {
        [Key]
        public int SutId { get; set; }
        [Column("TC")]
        [StringLength(11)]
        public string Tc { get; set; } = null!;
        [StringLength(35)]
        public string? AdiSoyadi { get; set; }
        public double? Miktari { get; set; }
        public double? Fiyati { get; set; }
        [StringLength(85)]
        public string? FirmaAdi { get; set; }
        public double? EleGecen { get; set; }
    }
}
