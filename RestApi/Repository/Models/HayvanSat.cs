using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApi.Repository.Models
{
    [Table("HayvanSat")]
    public partial class HayvanSat
    {
        [Key]
        public int SatisId { get; set; }
        [StringLength(14)]
        public string? IsletmeNo { get; set; }
        [StringLength(14)]
        public string? Cinsiyet { get; set; }
        [StringLength(3)]
        public string? Yas { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Tarih { get; set; }
        [StringLength(80)]
        public string? Aciklama { get; set; }
        [StringLength(15)]
        public string? Tel { get; set; }
        [StringLength(7)]
        public string? Fiyat { get; set; }
        public string? Resim { get; set; }
    }
}
