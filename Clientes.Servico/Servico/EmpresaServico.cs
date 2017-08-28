using Clientes.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clientes.Infra.Entidades;
using RestSharp;
using System.Net;

namespace Clientes.Servico.Servico
{
    public class EmpresaServico : IEmpresaServico
    {

        public IEnumerable<Empresa> BuscarEmpresa(string codigo)
        {
            var client = new RestClient("http://dev.markitondemand.com");
            var request = new RestRequest("Api/v2/Lookup/json?input=" + codigo);

            var resposta = client.Execute<List<Empresa>>(request);

            if (resposta.StatusCode != HttpStatusCode.OK)
            {
                throw new  Exception();
            }
            return resposta.Data;
        }

        public Preco BuscarPreco(string codigo)
        {

            var client = new RestClient("http://dev.markitondemand.com");
            var request = new RestRequest("Api/v2/Quote/json?symbol=" + codigo);

            var resposta = client.Execute<Preco>(request);

            if (resposta.StatusCode != HttpStatusCode.OK)
            {
                throw new Exception();
            }
            return resposta.Data;
        }
    }
}
