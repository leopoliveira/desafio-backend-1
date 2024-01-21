using desafio_backend_1.Models.Enums;

namespace desafio_backend_1.Models.Clientes
{
    public class ProblemaDeSaude
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public EnumGrauDoProblema GrauDoProblema { get; set; }

        public int ClienteId { get; set; }
    }
}
