using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppPB01Lab1_NEEMIAS.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext (DbContextOptions<ClienteContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppPB01Lab1_NEEMIAS.Models.Cliente> Cliente { get; set; }
    }
}
