using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;



namespace Projecto_Esw.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
       public virtual ICollection<Reserva> Reservas { get; set; }

       public virtual ICollection<ReservaIda> Reserva { get; set; }


    }
}
