using desafio_backend_1.DataBase;
using desafio_backend_1.Models.Clientes;
using desafio_backend_1.Repository.Interfaces;
using desafio_backend_1.Services.Interfaces;

namespace desafio_backend_1.Services.Implementations
{
    public class ProblemaDeSaudeService : IProblemaDeSaudeService
    {
        private readonly IProblemaDeSaudeRepository _repository;

        public ProblemaDeSaudeService(IProblemaDeSaudeRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<ProblemaDeSaude> GetAllProblemasDeSaude()
        {
            try
            {
                return _repository.GetAllProblemasDeSaude();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<ProblemaDeSaude> GetProblemaDeSaudeByCliente(int clienteId)
        {
            try
            {
                return _repository.GetProblemaDeSaudeByCliente(clienteId);
            }
            catch
            {
                throw;
            }
        }

        public void CreateProblemaDeSaude(ProblemaDeSaude problemaDeSaude)
        {
            try
            {
                _repository.CreateProblemaDeSaude(problemaDeSaude);
            }
            catch
            {
                throw;
            }
        }

        public void UpdateProblemaDeSaude(ProblemaDeSaude problemaDeSaude)
        {
            try
            {
                _repository.UpdateProblemaDeSaude(problemaDeSaude);
            }
            catch
            {
                throw;
            }
        }
    }
}
