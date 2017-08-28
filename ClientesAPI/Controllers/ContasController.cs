using Clientes.Infra.Entidades;
using Clientes.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClientesAPI.Controllers
{
    public class ContasController : ApiController
    {
        IContaRepositorio _contaRepositorio;

        public ContasController(IContaRepositorio contaRepositorio)
        {
            _contaRepositorio = contaRepositorio;
        }

        // GET: api/Contas/5
        public IEnumerable<Conta> Get(Guid clienteID)
        {
            var contas = _contaRepositorio.BuscarPorCliente(clienteID);
            return contas;
        }

        // POST: api/Contas
        public void Post([FromBody]Conta conta)
        {
            _contaRepositorio.Adicionar(conta);
        }

        // PUT: api/Contas/5
        public void Put([FromBody]Conta conta)
        {
            _contaRepositorio.Editar(conta);
        }

    }
}
