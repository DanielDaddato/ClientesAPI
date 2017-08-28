using Clientes.Infra.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Clientes.Servico.Interface;
using System.Threading.Tasks;

namespace ClientesAPI.Controllers
{
    public class EmpresaController : ApiController
    {
        IEmpresaServico _empresaServico;

        public EmpresaController(IEmpresaServico empresaServico)
        {
            _empresaServico = empresaServico;
        }

        [Route("api/banco/mercado/pesquisa/{*codigo}")]
        public IEnumerable<Empresa> GET(string codigo)
        {
            return _empresaServico.BuscarEmpresa(codigo);
        }

    } 
}
