using desafio_backend_1.Models.Clientes;

namespace desafio_backend_1.DataBase
{
    internal static class ProblemaDeSaudeDB
    {
        private static List<ProblemaDeSaude> _problemasDeSaude;

        public static List<ProblemaDeSaude> ProblemasDeSaude
        {
            get
            {
                return _problemasDeSaude ?? new List<ProblemaDeSaude>();
            }
        }

        public static void Add(ProblemaDeSaude problema)
        {
            _problemasDeSaude.Add(problema);
        }

        public static void Edit(int id, ProblemaDeSaude problema)
        {
            var problemaDeSaude = _problemasDeSaude.SingleOrDefault(x => x.Id == id) ??
                throw new ArgumentNullException("There is no ProblemaDeSaude with this Id");

            _problemasDeSaude.Remove(problemaDeSaude);

            Add(problema);
        }
    }
}
