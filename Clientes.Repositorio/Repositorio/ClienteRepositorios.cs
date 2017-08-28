using Clientes.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clientes.Infra.Entidades;
using Clientes.Infra.Entidades.Context;

namespace Clientes.Infra.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        public int Adicionar(Cliente cliente)
        {
            using (var context = new ClienteContext())
            {
                context.Clientes.Add(cliente);
                return context.SaveChanges();
            }
        }

        public IEnumerable<Cliente> Listar()
        {
            using (var context = new ClienteContext())
            {
                return context.Clientes.ToList();
            }
        }

    }
}
