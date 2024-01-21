using System.Linq.Expressions;

using desafio_backend_1.DataBase;
using desafio_backend_1.Models.Clientes;

namespace desafio_backend_1.Repository.Interfaces
{
    public class ClienteRepository : IClienteRepository
    {
        public IEnumerable<Cliente> GetAllClientes()
        {
            return ClienteDB.Clientes;
        }

        public Cliente GetClienteById(int id)
        {
            return ClienteDB.Clientes
                .SingleOrDefault(x => x.Id == id);
        }

        public void CreateCliente(Cliente cliente)
        {
            ClienteDB.Add(cliente);
        }

        public void UpdateCliente(Cliente cliente)
        {
            ClienteDB.Edit(cliente.Id, cliente);
        }
    }
}
