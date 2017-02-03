using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projecto_Esw.Models
{
    public class ReservaIda

    {
        public int ReservaIdaId { get; set; }

        [Required]
        public string Origem { get; set; }

        [Required]
        public string Destino { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataPartida { get; set; }
        
        public int TipoJatoId { get; set; }

        public int CompanhiaId { get; set; }

        public virtual Companhia Companhia { get; set; }
        public virtual TipoJato TipoJato { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime HoraPartida { get; set; }

        public int NumeroPessoas { get; set; }

    }
}
