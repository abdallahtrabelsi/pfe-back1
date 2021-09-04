using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pfe.Models
{
    public class Payeur
    {
        [Key]
        public int PayeurId { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string CardOwnerName { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Phone { get; set; }
    }
}
