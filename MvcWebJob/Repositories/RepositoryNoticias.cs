using Microsoft.EntityFrameworkCore;
using MvcWebJob.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using MvcWebJob.Data;


namespace MvcWebJob.Repositories
{
    public class RepositoryNoticias
    {

        private NoticiasContext context;
        public RepositoryNoticias(NoticiasContext context)
        {
            this.context = context;
        }
     public async Task<List<Noticia>> BaseGetNoticiasAsync()
        {
            var consulta = from datos in this.context.Noticias
                           select datos;
            List<Noticia> noticias= await consulta.ToListAsync();
            return noticias;
        }
    }
}
