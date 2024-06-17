using GerenciadordeTestes.WinApp.Compartilhado;
using GerenciadordeTestes.WinApp.ModuloMateria;

namespace GerenciadordeTestes.WinApp.ModuloDisciplina
{
    public class RepositorioDisciplina : RepositorioBase<Disciplina>, IRepositorioDisciplina
    {
        public RepositorioDisciplina(ContextoDados contexto) : base(contexto)
        {
            if (contexto.Disciplinas.Any()) contadorId = contexto.Disciplinas.Max(d => d.Id) + 1;
        }

        protected override List<Disciplina> ObterRegistros()
        {
            return contexto.Disciplinas;
        }

        public int ObterProximoId()
        {
            if (contexto.Disciplinas.Any())
                return contexto.Disciplinas.Max(c => c.Id) + 1;
            else
                return 1;
        }

        public override bool Excluir(int id)
        {
            Disciplina disciplina = SelecionarPorId(id);

            List<Materia> materiasRelacionadas = contexto.Materias.FindAll(m => m.Disciplina.Id == disciplina.Id);

            foreach (Materia m in materiasRelacionadas)
                m.Disciplina = null;

            return base.Excluir(id);
        }
    }
}