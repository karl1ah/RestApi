using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApi.Repository.Models
{
    [Table("IsletmeBilgileri")]
    public partial class IsletmeBilgileri
    {
        [StringLength(70)]
        public string? Kaza { get; set; }
        [StringLength(35)]
        public string? Koy { get; set; }
        [StringLength(50)]
        public string? Isim { get; set; }
        [StringLength(20)]
        public string? Isletmeturu { get; set; }
        [Column("TC")]
        [StringLength(11)]
        public string Tc { get; set; } = null!;
        [StringLength(8)]
        public string? BankaSubesi { get; set; }
        [StringLength(35)]
        public string? BankaHesapNumarasi { get; set; }
        [StringLength(15)]
        public string? EvTelefon { get; set; }
        [StringLength(15)]
        public string? CepTelefon { get; set; }
        public double? Bakiye { get; set; }
        [Key]
        [StringLength(14)]
        public string IsletmeNo { get; set; } = null!;
        [StringLength(25)]
        public string? Email { get; set; }
        [StringLength(20)]
        public string? Sifre { get; set; }
        [StringLength(30)]
        public string? Sinif { get; set; }
        [StringLength(50)]
        public string? Aciklama { get; set; }
        public string? Resim { get; set; }
    }
}
