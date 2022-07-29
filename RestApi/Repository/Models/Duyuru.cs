using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApi.Repository.Models
{
    [Table("Duyuru")]
    public partial class Duyuru
    {
        public Duyuru()
        {
            DuyuruAlts = new HashSet<DuyuruAlt>();
        }

        [Key]
        [StringLength(14)]
        public string GonderNo { get; set; } = null!;
        [StringLength(10)]
        public string? Tip { get; set; }
        [StringLength(100)]
        public string? Aciklama { get; set; }
        [StringLength(10)]
        public string? Tarih { get; set; }
        public int? Evet { get; set; }
        public int? Hayır { get; set; }
        public string? Resim { get; set; }

        [InverseProperty("GonderiNoNavigation")]
        public virtual ICollection<DuyuruAlt> DuyuruAlts { get; set; }
    }
}
