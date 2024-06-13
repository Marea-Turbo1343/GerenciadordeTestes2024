using GerenciadordeTestes.WinApp.Compartilhado;

namespace GerenciadordeTestes.WinApp.ModuloDisciplina
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(GerarColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Disciplina> disciplina)
        {
            grid.Rows.Clear();

            foreach (Disciplina i in disciplina)
                grid.Rows.Add(i.Id, i.Nome.ToTitleCase());
        }

        public int ObterRegistroSelecionado()
        {
            return grid.SelecionarId();
        }

        private DataGridViewColumn[] GerarColunas()
        {
            return new DataGridViewColumn[]
                        {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" }
                        };
        }
    }
}