using GerenciadordeTestes.WinApp.Compartilhado;

namespace GerenciadordeTestes.WinApp.ModuloMateria
{
    public class RepositorioMateria : RepositorioBase<Materia>, IRepositorioMateria
    {
        public RepositorioMateria(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Materia> ObterRegistros()
        {
            return contexto.Materias;
        }
    }
}