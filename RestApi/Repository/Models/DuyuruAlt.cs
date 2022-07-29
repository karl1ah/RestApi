using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestApi.Repository.Models
{
    [Table("DuyuruAlt")]
    public partial class DuyuruAlt
    {
        [Key]
        public int Duyuruid { get; set; }
        [StringLength(14)]
        public string GonderiNo { get; set; } = null!;
        [StringLength(14)]
        public string? IsletmeNo { get; set; }
        public int Sayi { get; set; }

        [ForeignKey("GonderiNo")]
        [InverseProperty("DuyuruAlts")]
        public virtual Duyuru GonderiNoNavigation { get; set; } = null!;
    }
}
