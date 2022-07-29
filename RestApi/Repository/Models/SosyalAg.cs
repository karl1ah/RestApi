using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApi.Repository.Models
{
    [Table("SosyalAg")]
    public partial class SosyalAg
    {
        [Key]
        public int GonderiKodu { get; set; }
        [StringLength(14)]
        public string? IsletmeNo { get; set; }
        [StringLength(100)]
        public string? Aciklama { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Tarih { get; set; }
        public string? Resim { get; set; }
    }
}
