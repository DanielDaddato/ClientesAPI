using Clientes.Infra.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Infra.Interfaces
{
    public interface IClienteRepositorio
    {
        IEnumerable<Cliente> Listar();

        int Adicionar(Cliente cliente);

    }
}
