using Clientes.Infra.Entidades;
using Clientes.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClientesAPI.Controllers
{
    public class PrecoController : ApiController
    {

        IEmpresaServico _empresaServico;

        public PrecoController(IEmpresaServico empresaServico)
        {
            _empresaServico = empresaServico;
        }

        [Route("api/banco/mercado/preco/{*codigo}")]
        public Preco Get(string codigo)
        {
            return _empresaServico.BuscarPreco(codigo);
        }
    }
}
