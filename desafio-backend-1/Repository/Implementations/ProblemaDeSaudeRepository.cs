using desafio_backend_1.DataBase;
using desafio_backend_1.Models.Clientes;

namespace desafio_backend_1.Repository.Interfaces
{
    public class ProblemaDeSaudeRepository : IProblemaDeSaudeRepository
    {
        public IEnumerable<ProblemaDeSaude> GetAllProblemasDeSaude()
        {
            return ProblemaDeSaudeDB.ProblemasDeSaude;
        }

        public IEnumerable<ProblemaDeSaude> GetProblemaDeSaudeByCliente(int clienteId)
        {
            return ProblemaDeSaudeDB.ProblemasDeSaude
                .Where(x => x.ClienteId == clienteId);
        }

        public void CreateProblemaDeSaude(ProblemaDeSaude problemaDeSaude)
        {
            ProblemaDeSaudeDB.Add(problemaDeSaude);
        }

        public void UpdateProblemaDeSaude(ProblemaDeSaude problemaDeSaude)
        {
            ProblemaDeSaudeDB.Edit(problemaDeSaude.Id, problemaDeSaude);
        }
    }
}
