using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApi.Repository.Models
{
    [Table("Iletisim")]
    public partial class Iletisim
    {
        [StringLength(35)]
        public string? Isim { get; set; }
        [StringLength(50)]
        public string? Aciklama { get; set; }
        [StringLength(20)]
        public string? Tip { get; set; }
        [StringLength(10)]
        public string? Bilinmeyen { get; set; }
        [Key]
        public int IletisimId { get; set; }
        public string? Resim { get; set; }
    }
}
