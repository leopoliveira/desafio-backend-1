using desafio_backend_1.Models.Clientes;

namespace desafio_backend_1.Services.Interfaces
{
    public interface IProblemaDeSaudeService
    {
        IEnumerable<ProblemaDeSaude> GetAllProblemasDeSaude();

        IEnumerable<ProblemaDeSaude> GetProblemaDeSaudeByCliente(int clienteId);

        void CreateProblemaDeSaude(ProblemaDeSaude problemaDeSaude);

        void UpdateProblemaDeSaude(ProblemaDeSaude problemaDeSaude);
    }
}
