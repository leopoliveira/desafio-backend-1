using desafio_backend_1.Models.Enums;

namespace desafio_backend_1.Models.Clientes
{
    public class ProblemaDeSaude(int id, string nome, EnumGrauDoProblema grauDoProblema, int clienteId)
    {
        public int Id { get; set; } = id;

        public string Nome { get; set; } = nome;

        public EnumGrauDoProblema GrauDoProblema { get; set; } = grauDoProblema;

        public int ClienteId { get; set; } = clienteId;
    }
}
