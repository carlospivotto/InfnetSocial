using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfnetSocial.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public IdentityUser IdentityUser { get; set; }
        
        public ICollection<Amizade> AmizadesA { get; set; }
        public ICollection<Amizade> AmizadesB { get; set; }
    }
}
