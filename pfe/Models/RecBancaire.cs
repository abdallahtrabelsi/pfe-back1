using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pfe.Models
{
    public class RecBancaire
    {
        [Key]
        public int DepBanId { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Date { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string NCH { get; set; }

        [Column(TypeName = "nvarchar(8)")]
        public string CO { get; set; }

        [Column(TypeName = "nvarchar(8)")]
        public string Tiers { get; set; }

        [Column(TypeName = "nvarchar(8)")]
        public string Montant { get; set; }

        [Column(TypeName = "nvarchar(8)")]
        public string Libelle { get; set; }

        [Column(TypeName = "nvarchar(8)")]
        public string MVT { get; set; }
    }
}
