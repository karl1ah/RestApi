using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApi.Repository.Models
{
    [Table("HesapOzeti")]
    public partial class HesapOzeti
    {
        [StringLength(10)]
        public string? Aciklama { get; set; }
        [Column("TC")]
        [StringLength(11)]
        public string Tc { get; set; } = null!;
        [StringLength(20)]
        public string? IslemDetay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Tarih { get; set; }
        [Key]
        public int HesapId { get; set; }
        public double? Tutar { get; set; }
    }
}
