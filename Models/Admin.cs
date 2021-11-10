using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoceSabor.Models
{
    public class Admin
    {
        public int Id {get;set;}

        [StringLength(10)]
        public string Login {get;set;}
        
        [StringLength(10)]
        public string Senha {get;set;}
    }
}