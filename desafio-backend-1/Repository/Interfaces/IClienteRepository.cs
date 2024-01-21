using System.Linq.Expressions;

using desafio_backend_1.Models.Clientes;

namespace desafio_backend_1.Repository.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetAllClientes();

        Cliente GetClienteById(int id);

        void CreateCliente(Cliente cliente);

        void UpdateCliente(Cliente cliente);
    }
}
