using Projecto_Esw.Models.AccountViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projecto_Esw.Models.ManageViewModels
{
    public class RemoveLoginViewModel
   {
        //public RegisterViewModel register { get; set;}


        public string LoginProvider { get; set; }
         public string ProviderKey { get; set; }
    }
}
