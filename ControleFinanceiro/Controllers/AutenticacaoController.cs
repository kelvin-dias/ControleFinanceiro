using Modelo.ViewModelo;
using Persistencia.Context;
using System.Web.Mvc;
using System.Linq;
using System.Security.Policy;
using System.Security.Claims;
using System.Web;
using System;

namespace ControleFinanceiro.Controllers
{
    public class AutenticacaoController : Controller
    {
        private EFContext context = new EFContext();

        // GET: Autenticacao
        public ActionResult Login(string ReturnUrl)
        {
            var viewModel = new LoginViewModel
            {
                UrlRetorno = ReturnUrl
            };

            return View(viewModel);
        }

        // POST: Autenticacao
        [HttpPost]
        public ActionResult Login(LoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var usuario = context.Usuarios.FirstOrDefault(x => x.LoginUsuario == viewModel.LoginUsuario);

            if (usuario == null)
            {
                ModelState.AddModelError("LoginUsuario", "Login incorreto");
                return View(viewModel);
            }

            if (usuario.Senha != viewModel.Senha)
            {
                ModelState.AddModelError("Senha", "Senha incorreta");
                return View(viewModel);
            }

            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, usuario.NomeUsuario),
                new Claim("Login", usuario.LoginUsuario)
            }, "AplicationCookie");

            Request.GetOwinContext().Authentication.SignIn(identity);

            if (!String.IsNullOrWhiteSpace(viewModel.UrlRetorno) || Url.IsLocalUrl(viewModel.UrlRetorno))
            {
                return RedirectToAction("Dashboard", "Home");

                //problema ao direcionar para página solicitada.
                //return Redirect(viewModel.UrlRetorno);
            }
            else
            {
                return RedirectToAction("Dashboard", "Home");
            }
        }
        public ActionResult Logout()
        {
            var teste = User.Identity.Name;
            Request.GetOwinContext().Authentication.SignOut("ApplicationCookie");
            return RedirectToAction("Login", "Autenticacao");
        }
    }
}