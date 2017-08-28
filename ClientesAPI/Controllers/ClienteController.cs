using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Clientes.Infra.Interfaces;
using Clientes.Infra.Entidades;

namespace ClientesAPI.Controllers
{
    public class ClienteController : ApiController
    {
        private IClienteRepositorio _clienteRepositorio;

        public ClienteController(Clientes.Infra.Interfaces.IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
            
        // GET: api/Cliente
        public HttpResponseMessage Get(IClienteRepositorio clienteRepositorio)
        {
            var clientes = _clienteRepositorio.Listar();


            return Request.CreateResponse(HttpStatusCode.OK, clientes);
        }

        // POST: api/Cliente
        public void Post([FromBody]Cliente cliente )
        {
            _clienteRepositorio.Adicionar(cliente);
        }

        // PUT: api/Cliente/5
        public void Put(Guid id, [FromBody]Cliente cliente)
        {
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
        }
    }
}
