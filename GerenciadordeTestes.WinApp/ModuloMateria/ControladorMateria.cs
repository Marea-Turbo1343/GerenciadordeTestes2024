using GerenciadordeTestes.WinApp.Compartilhado;
using GerenciadordeTestes.WinApp.ModuloDisciplina;

namespace GerenciadordeTestes.WinApp.ModuloMateria
{
    public class ControladorMateria : ControladorBase
    {
        private TabelaMateriaControl tabelaMateria;

        private IRepositorioMateria repositorioMateria;
        private IRepositorioDisciplina repositorioDisciplina;

        public ControladorMateria(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override string TipoCadastro { get { return "Matérias"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar uma nova matéria"; } }

        public override string ToolTipEditar { get { return "Editar uma matéria existente"; } }

        public override string ToolTipExcluir { get { return "Excluir uma matéria existente"; } }

        public void AtualizarListagem()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            tabelaMateria.AtualizarRegistros(materias);

            TelaPrincipalForm.Instancia.AtualizarRodape(ObterTextoRodape(materias));
        }

        private static string ObterTextoRodape(List<Materia> materias)
        {
            if (materias.Count == 0)
                return "Nenhuma matéria cadastrada até o momento!";
            else if (materias.Count == 1)
                return "Exibindo 1 matéria";
            else
                return $"Exibindo {materias.Count} matérias.";
        }

        public override void Adicionar()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm(repositorioMateria);

            List<Disciplina> disciplinasCadastradas = repositorioDisciplina.SelecionarTodos();

            telaMateria.CarregarDisciplinas(disciplinasCadastradas);

            DialogResult resultado = telaMateria.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Materia novaMateria = telaMateria.Materia;

            repositorioMateria.Cadastrar(novaMateria);

            CarregarMaterias();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{novaMateria.Nome}\" foi criado com sucesso!");
        }

        public override void Editar()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm(repositorioMateria);

            List<Disciplina> disciplinasCadastradas = repositorioDisciplina.SelecionarTodos();

            telaMateria.CarregarDisciplinas(disciplinasCadastradas);

            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            Materia materiaSelecionada = repositorioMateria.SelecionarPorId(idSelecionado);

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Não é possível realizar esta ação sem um registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            telaMateria.Materia = materiaSelecionada;

            DialogResult resultado = telaMateria.ShowDialog();

            if (resultado != DialogResult.OK)
                return;

            Materia materiaEditada = telaMateria.Materia;

            repositorioMateria.Editar(materiaSelecionada.Id, materiaEditada);

            CarregarMaterias();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{materiaSelecionada.Nome}\" foi atualizado com sucesso!");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaMateria.ObterRegistroSelecionado();

            Materia materiaSelecionada = repositorioMateria.SelecionarPorId(idSelecionado);

            if (materiaSelecionada == null)
            {
                MessageBox.Show("Não é possível realizar esta ação sem um registro selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show($"Tem certeza que deseja excluir a matéria \"{materiaSelecionada.Nome}\"?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado != DialogResult.Yes)
                return;

            repositorioMateria.Excluir(materiaSelecionada.Id);

            CarregarMaterias();

            TelaPrincipalForm.Instancia.AtualizarRodape($"O registro \"{materiaSelecionada.Nome}\" foi removido com sucesso!");
        }

        public void CarregarMaterias()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            tabelaMateria.AtualizarRegistros(materias);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaMateria == null)
                tabelaMateria = new TabelaMateriaControl();

            CarregarMaterias();

            AtualizarListagem();

            return tabelaMateria;
        }
    }
}