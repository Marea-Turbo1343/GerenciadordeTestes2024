using GerenciadordeTestes.WinApp.Compartilhado;

namespace GerenciadordeTestes.WinApp.ModuloMateria
{
    public class RepositorioMateria : RepositorioBase<Materia>, IRepositorioMateria
    {
        public RepositorioMateria(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Materias.Any()) contadorId = contexto.Materias.Max(m => m.Id) + 1;
        }

        public int ObterProximoId()
        {
            if (contexto.Materias.Any())
                return contexto.Materias.Max(c => c.Id) + 1;
            else
                return 1;
        }

        protected override List<Materia> ObterRegistros()
        {
            return contexto.Materias;
        }

        public override bool Excluir(int id)
        {
            Materia materia = SelecionarPorId(id);

            //List<Questao> questoesRelacionadas = contexto.Questoes.FindAll(q => q.Materia.Id == materia.Id);

            //foreach (Questao q in questoesRelacionadas)
            //    q.Materia = null;

            return base.Excluir(id);
        }
    }
}