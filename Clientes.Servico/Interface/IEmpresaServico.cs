using Clientes.Infra.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Servico.Interface
{
    public interface IEmpresaServico
    {
        IEnumerable<Empresa> BuscarEmpresa(string codigo);

        Preco BuscarPreco(string codigo);
    }
}
