using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApi.Repository.Models
{
    public partial class Hakkımızdum
    {
        [Key]
        public int Personelid { get; set; }
        [StringLength(35)]
        public string? AdSoyad { get; set; }
        [StringLength(50)]
        public string? Aciklama { get; set; }
        [StringLength(15)]
        public string? Tel { get; set; }
        [StringLength(15)]
        public string? Tip { get; set; }
        [StringLength(10)]
        public string? Bilinmeyen { get; set; }
        public string? Resim { get; set; }
    }
}
