using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoceSabor.Models
{
    public class Feedback
    {
        public int Id {get;set;}

        [StringLength(50)]
        public string Nome {get;set;}
        public int Nota {get;set;}

        [Column(TypeName = "TEXT")]
        public string Opiniao {get;set;}
    }
}