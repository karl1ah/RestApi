using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApi.Repository.Models
{
    [Table("HayvanBilgileri")]
    public partial class HayvanBilgileri
    {
        [Key]
        [StringLength(14)]
        public string KulakNo { get; set; } = null!;
        [StringLength(14)]
        public string IsletmeNo { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? DogumTarihi { get; set; }
        [StringLength(8)]
        public string? Cinsiyet { get; set; }
        [StringLength(15)]
        public string? Irki { get; set; }
        [StringLength(10)]
        public string? KupelemeTarihi { get; set; }
        [Column("kupeleyen")]
        [StringLength(50)]
        public string? Kupeleyen { get; set; }
        [StringLength(12)]
        public string? BrusellaAsiTarihi { get; set; }
        [StringLength(10)]
        public string? SapAsiTarihi { get; set; }
        [StringLength(50)]
        public string? Tohumlayan { get; set; }
        [StringLength(12)]
        public string? TohumlamaTarihi { get; set; }
        [StringLength(14)]
        public string? BabaKulakNo { get; set; }
        [StringLength(90)]
        public string? AskiDestekDurumu { get; set; }
        [StringLength(90)]
        public string? AskiDestekNedeni { get; set; }
        [StringLength(10)]
        public string? AskiDestekTutari { get; set; }
        [StringLength(90)]
        public string? IcmalDestekDurumu { get; set; }
        [StringLength(90)]
        public string? IcmalDestekNedeni { get; set; }
        [Column("icmal_list_tutar")]
        [StringLength(10)]
        public string? IcmalListTutar { get; set; }
        [StringLength(20)]
        public string? Adi { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? BuzalamaTarihi { get; set; }
        [StringLength(14)]
        public string? BuzagiKulakNo { get; set; }
    }
}
