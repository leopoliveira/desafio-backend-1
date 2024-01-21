using desafio_backend_1.Models.Clientes;

namespace desafio_backend_1.DataBase
{
    internal static class ClienteDB
    {
        private static List<Cliente> _clientes;

        public static List<Cliente> Clientes
        {
            get
            {
                return _clientes ?? new List<Cliente>();
            }
        }

        public static void Add(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        public static void Edit(int id, Cliente novoCliente)
        {
            var cliente = _clientes.SingleOrDefault(x => x.Id == id) ??
                throw new ArgumentNullException("There is no Cliente with this Id");

            _clientes.Remove(cliente);

            Add(novoCliente);
        }
    }
}
