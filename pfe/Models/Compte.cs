using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pfe.Models
{
    public class Compte
    {
        [Key]
        public int CompteId { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string CO { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Lib { get; set; }

        [Column(TypeName = "nvarchar(8)")]
        public string DB { get; set; }

        [Column(TypeName = "nvarchar(8)")]
        public string CR { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string TypeCompte { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string CompteDB { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string OuvertDB { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string OuvertCR { get; set; }
    }
}
