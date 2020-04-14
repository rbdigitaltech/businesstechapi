using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace businesstechapi.Models
{
    public class InicializaBD
    {
        public static void Initialize(BTContexto context)
        {
            context.Database.EnsureCreated();
        }
    }
}
