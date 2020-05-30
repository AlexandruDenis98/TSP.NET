using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClientWeb.Models;

namespace ClientWeb.Data
{
    public class ClientWebContext : DbContext
    {
        public ClientWebContext (DbContextOptions<ClientWebContext> options)
            : base(options)
        {
        }

        public DbSet<ClientWeb.Models.FileDTO> FileDTO { get; set; }

        public DbSet<ClientWeb.Models.FileKeywordDTO> FileKeywordDTO { get; set; }
    }
}
