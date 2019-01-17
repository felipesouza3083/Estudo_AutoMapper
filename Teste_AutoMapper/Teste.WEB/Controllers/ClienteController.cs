using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teste.Entidades;
using Teste.WEB.Models.Cliente;

namespace Teste.WEB.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {

            var cliente = new Cliente { Nome = "Teste", Sobrenome = "Um", Ativo = true, DataNascimento = DateTime.Now };

            var copia = Mapper.Map<ClienteConsultaViewModel>(cliente);

            copia.NumeroDaSorte = 10;

            Teste();

            return View();
        }

        public void Teste()
        {
            var cliente = new ClienteConsultaViewModel { Nome = "Teste", Sobrenome = "2", Ativo = true, DataNascimento = DateTime.Now, NumeroDaSorte = 11 };

            var copia = Mapper.Map<Cliente>(cliente);
        }
    }
}