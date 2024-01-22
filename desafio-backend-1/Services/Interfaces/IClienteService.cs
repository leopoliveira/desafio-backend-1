using desafio_backend_1.Models.Clientes;
using desafio_backend_1.Models.Enums;

namespace desafio_backend_1.Services.Interfaces
{
    public interface IClienteService
    {
        IEnumerable<Cliente> GetAllClientes();

        Cliente GetClienteById(int id);

        void CreateCliente(Cliente cliente);

        void UpdateCliente(Cliente cliente);

        decimal CalculateGrauProblemas(List<EnumGrauDoProblema> graus);
    }
}
