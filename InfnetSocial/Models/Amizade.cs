using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfnetSocial.Models
{
    public class Amizade
    {
        public int UsuarioIdA { get; set; }
        public int UsuarioIdB { get; set; }
        public Usuario UsuarioA { get; set; }
        public Usuario UsuarioB { get; set; }
    }
}
