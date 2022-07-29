using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApi.Repository.Models
{
    [Table("HayPazVerileri")]
    public partial class HayPazVerileri
    {
        [Key]
        [Column("HPId")]
        [StringLength(10)]
        public string Hpid { get; set; } = null!;
        [StringLength(8)]
        public string? Isi { get; set; }
        [StringLength(8)]
        public string? Nem { get; set; }
        [StringLength(50)]
        public string? Bilinmeyen { get; set; }
        public int? HayvanSayisi { get; set; }
        [Column("AEBF")]
        [StringLength(10)]
        public string? Aebf { get; set; }
        [Column("ADBF")]
        [StringLength(10)]
        public string? Adbf { get; set; }
        [StringLength(10)]
        public string? GebeDuveF { get; set; }
        [StringLength(10)]
        public string? KisirInekF { get; set; }
        [StringLength(10)]
        public string? EtKgF { get; set; }
        [Column("HayvanSayısıGH")]
        [StringLength(10)]
        public string? HayvanSayısıGh { get; set; }
    }
}
