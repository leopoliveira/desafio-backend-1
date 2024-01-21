using desafio_backend_1.Models.Enums;

namespace desafio_backend_1.Models.Clientes
{
    public class ProblemaDeSaude
    {
        public string Nome { get; set; }

        public EnumGrauDoProblema GrauDoProblema { get; set; }
    }
}
