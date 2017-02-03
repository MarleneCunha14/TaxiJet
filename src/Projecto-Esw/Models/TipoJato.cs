using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projecto_Esw.Models
{
    public class TipoJato
    {
        public int TipoJatoId { get; set; }
        
        public string Nome { get; set; }

        public double Preco { get; set; }
    }
}
