using CRUD_CLIENTES.Models.Contexto;
using CRUD_CLIENTES.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_CLIENTES.Controllers
{
    public class ClientesController : Controller
    {

        private readonly Contexto _contexto; 
        public ClientesController(Contexto contexto) 
        {
            _contexto = contexto;
        }
        public IActionResult Index()
        {
            var lista = _contexto.Clientes.ToList();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var clientes = new Clientes();
            return View(clientes);
        }

        [HttpPost]
        public IActionResult Create(Clientes clientes)
        {
            if (ModelState.IsValid) 
            {
                _contexto.Clientes.Add(clientes);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(clientes);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var clientes = _contexto.Clientes.Find(Id);
            if (clientes!=null)
            {
                
            }
            return View(clientes);
        }

        [HttpPost]
        public IActionResult Edit(Clientes clientes)
        {
            if (ModelState.IsValid)
            {
                _contexto.Clientes.Update(clientes);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(clientes);
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var clientes = _contexto.Clientes.Find(Id);
            return View(clientes);
        }

        [HttpPost]
        public IActionResult Delete(Clientes _clientes)
        {
            var clientes = _contexto.Clientes.Find(_clientes.Id);
            if (clientes != null)
            {
                _contexto.Clientes.Remove(clientes);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(clientes);
        }

        [HttpGet]
        public IActionResult Details(int Id)
        {
            var clientes = _contexto.Clientes.Find(Id);
            return View(clientes);
        }

    }
}
