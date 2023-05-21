using Microsoft.AspNetCore.Mvc;
using MvcWebJob.Models;
using MvcWebJob.Repositories;
using System.Collections.Generic;

namespace MvcWebJob.Controllers
{
    public class NoticiasController : Controller
    {
        private RepositoryNoticias repo;
        public NoticiasController(RepositoryNoticias repo)
        {
            this.repo = repo;
        }
        public async Task<IActionResult>Index()
        {
            List<Noticia> news = await this.repo.BaseGetNoticiasAsync();
            return View(news);
        }
    }
}
