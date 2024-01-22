using desafio_backend_1.DataBase;
using desafio_backend_1.Models.Clientes;
using desafio_backend_1.Models.Enums;
using desafio_backend_1.Repository.Interfaces;
using desafio_backend_1.Services.Interfaces;

namespace desafio_backend_1.Services.Implementations
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Cliente> GetAllClientes()
        {
            try
            {
                return _repository.GetAllClientes();
            }
            catch
            {
                throw;
            }
        }

        public Cliente GetClienteById(int id)
        {
            try
            {
                return _repository.GetClienteById(id);
            }
            catch
            {
                throw;
            }
        }

        public void CreateCliente(Cliente cliente)
        {
            try
            {
                _repository.CreateCliente(cliente);
            }
            catch
            {
                throw;
            }
        }

        public void UpdateCliente(Cliente cliente)
        {
            try
            {
                _repository.UpdateCliente(cliente);
            }
            catch
            {
                throw;
            }
        }

        public decimal CalculateGrauProblemas(List<EnumGrauDoProblema> graus)
        {
            double somaDosGraus = graus.Sum(x => (int)x);

            return (decimal)((1 / (1 + Math.Pow(Math.E, -2.8 + somaDosGraus))) * 100);
        }
    }
}
