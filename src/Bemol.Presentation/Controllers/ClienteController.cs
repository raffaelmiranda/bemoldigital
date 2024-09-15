using Bemol.Application.Interfaces;
using Bemol.Application.Models;
using Bemol.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bemol.Presentation.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteAppService _clienteApp;

        public ClienteController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }
        public IActionResult Index()
        {
            var clientes = _clienteApp.Obter();

            List<ClienteViewModel> response = new List<ClienteViewModel>();
            foreach (var item in clientes)
            {
                ClienteViewModel view = new ClienteViewModel();
                view.Id = item.Id;
                view.Nome = item.Nome;
                view.Cpf = item.Cpf;
                view.Cep = item.Cep;
                view.Rua = item.Rua;
                view.Email = item.Email;

                response.Add(view);
            }
           

            return View(response);
        }

        public ActionResult Details(int id)
        {
            var cliente = _clienteApp.ObterPorId(id);

            ClienteViewModel view = new ClienteViewModel();
            view.Id = cliente.Id;
            view.Nome = cliente.Nome;
            view.Cpf = cliente.Cpf;
            view.Cep = cliente.Cep;
            view.Rua = cliente.Rua;
            view.Email = cliente.Email;

            return View(view);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel request)
        {
            if (ModelState.IsValid)
            {
                Cliente cliente = new Cliente(request.Id, request.Nome, request.Cpf, request.Cep, request.Rua, request.Email);

                _clienteApp.Salvar(cliente);

                return RedirectToAction("Index");
            }

            return View(request);
        }

        public ActionResult Edit(int id)
        {
            var cliente = _clienteApp.ObterPorId(id);

            ClienteViewModel view = new ClienteViewModel();
            view.Id = cliente.Id;
            view.Nome = cliente.Nome;
            view.Cpf = cliente.Cpf;
            view.Cep = cliente.Cep;
            view.Rua = cliente.Rua;
            view.Email = cliente.Email;

            return View(view);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel request)
        {
            if (ModelState.IsValid)
            {
                Cliente cliente = new Cliente(request.Id, request.Nome, request.Cpf, request.Cep, request.Rua, request.Email);
                
                _clienteApp.Atualizar(cliente);
                return RedirectToAction("Index");
            }
            return View(request);
        }

        public ActionResult Delete(int id)
        {
            var cliente = _clienteApp.ObterPorId(id);

            ClienteViewModel view = new ClienteViewModel();
            view.Id = cliente.Id;
            view.Nome = cliente.Nome;
            view.Cpf = cliente.Cpf;
            view.Cep = cliente.Cep;
            view.Rua = cliente.Rua;
            view.Email = cliente.Email;

            return View(view);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var cliente = _clienteApp.ObterPorId(id);
            _clienteApp.Remover(cliente);

            return RedirectToAction("Index");
        }

    }
}
