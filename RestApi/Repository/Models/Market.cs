using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApi.Repository.Models
{
    [Table("Market")]
    public partial class Market
    {
        [Key]
        [StringLength(14)]
        public string UrunKodu { get; set; } = null!;
        [StringLength(50)]
        public string? Aciklama { get; set; }
        [StringLength(7)]
        public string? Fiyat { get; set; }
        public bool? AktifPasif { get; set; }
        public string? Resim { get; set; }
    }
}
