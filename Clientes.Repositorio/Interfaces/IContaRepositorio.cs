using Clientes.Infra.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Infra.Interfaces
{
    public interface IContaRepositorio
    {
        IEnumerable<Conta> BuscarPorCliente(Guid clienteID);

        int Adicionar(Conta conta);

        int Editar(Conta conta);


    }
}
