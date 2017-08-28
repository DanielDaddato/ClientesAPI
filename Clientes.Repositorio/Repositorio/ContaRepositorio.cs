using Clientes.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clientes.Infra.Entidades;
using Clientes.Infra.Entidades.Context;
using System.Data.Entity;

namespace Clientes.Infra.Repositorio
{
    public class ContaRepositorio : IContaRepositorio
    {
        public int Adicionar(Conta conta)
        {
            using (var context = new ClienteContext())
            {
                context.Contas.Add(conta);
                return context.SaveChanges();
            }
        }

        public IEnumerable<Conta> BuscarPorCliente(Guid clienteID)
        {
            using (var context = new ClienteContext())
            {
                return context.Contas.Where(x => x.ClienteID == clienteID).Select(x => x).ToList();
            }
        }

        public int Editar(Conta conta)
        {
            using (var context = new ClienteContext())
            {
                context.Contas.Attach(conta);
                context.Entry(conta).State = EntityState.Modified;
                return context.SaveChanges();
            }
        }
    }
}
