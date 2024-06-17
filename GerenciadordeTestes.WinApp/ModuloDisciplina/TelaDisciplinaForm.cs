namespace GerenciadordeTestes.WinApp.ModuloDisciplina
{
    public partial class TelaDisciplinaForm : Form
    {
        private Disciplina disciplina;
        private IRepositorioDisciplina repositorioDisciplina;
        private bool modoEdicao;

        public Disciplina Disciplina
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
            }
            get => disciplina;
        }

        public TelaDisciplinaForm(IRepositorioDisciplina repositorioDisciplina, bool modoEdicao = false)
        {
            InitializeComponent();

            this.repositorioDisciplina = repositorioDisciplina;
            this.modoEdicao = modoEdicao;

            if (modoEdicao)
            {
                this.Text = "Editar Disciplina";
            }
            else
            {
                int proximoId = repositorioDisciplina.ObterProximoId();
                txtId.Text = proximoId.ToString();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            disciplina = new Disciplina(nome);

            List<string> erros = disciplina.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}