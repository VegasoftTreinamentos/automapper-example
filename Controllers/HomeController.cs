using automapper_domain;
using automapper_example.Models;
using System.Web.Mvc;

namespace automapper_example.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var usuario = new Usuario
            {
                Nome = "Rafael",
                Sobrenome = "de Oliveira Marques",
                Email = "rafaelomarques@gmail.com"
            };
            
            var usuarioView = AutoMapper.Mapper.Map<UsuarioViewModel>(usuario);

            ViewBag.UsuarioView = usuarioView;
            ViewBag.UsuarioDomain = AutoMapper.Mapper.Map<Usuario>(usuarioView);
            
            return View();
        }
    }
}
