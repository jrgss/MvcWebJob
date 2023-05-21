using Microsoft.EntityFrameworkCore;
using MvcWebJob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcWebJob.Data
{
    public class NoticiasContext: DbContext
    {
        public NoticiasContext(DbContextOptions<NoticiasContext> options) : base(options) { }
        public DbSet<Noticia>Noticias { get; set; }
    }
}
