using GerenciadordeTestes.WinApp.Compartilhado;
using GerenciadordeTestes.WinApp.ModuloDisciplina;
using GerenciadordeTestes.WinApp.ModuloMateria;
//using GerenciadordeTestes.WinApp.ModuloQuestao;
//using GerenciadordeTestes.WinApp.ModuloTeste;


namespace GerenciadordeTestes.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;

        ContextoDados contexto;

        IRepositorioDisciplina repositorioDisciplina;
        IRepositorioMateria repositorioMateria;
        //IRepositorioQuestao repositorioQuestao;
        //IRepositorioTeste repositorioTeste;

        public event Action TemporizadorTerminou;

        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();
            lblTipoCadastro.Text = string.Empty;
            Instancia = this;

            contexto = new ContextoDados(true);
            repositorioDisciplina = new RepositorioDisciplina(contexto);
            repositorioMateria = new RepositorioMateria(contexto);
            //repositorioQuestao = new RepositorioQuestao(contexto);
            //repositorioTeste = new RepositorioTeste(contexto);

            //CadastrarRegistrosTeste();
        }

        public void AtualizarRodape(string texto)
        {
            stslblRodape.Text = texto;
        }

        public void Temporizador(string mensagem)
        {
            AtualizarRodape(mensagem);

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                TemporizadorTerminou?.Invoke();
            };
            timer.Start();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDisciplina(repositorioDisciplina);

            ConfigurarTelaPrincipal(controlador);
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMateria(repositorioMateria, repositorioDisciplina);
            
            ConfigurarTelaPrincipal(controlador);
        }

        private void questõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador.Adicionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorSelecionado)
        {
            //lblTipoCadastro.Text = "Cadastro de " + controladorSelecionado.TipoCadastro;

            lblTipoCadastro.Text = controladorSelecionado.TipoCadastro;

            ConfigurarToolBox(controladorSelecionado);
            ConfigurarListagem(controladorSelecionado);
        }

        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = controladorSelecionado is ControladorBase;
            btnEditar.Enabled = controladorSelecionado is ControladorBase;
            btnExcluir.Enabled = controladorSelecionado is ControladorBase;

            ConfigurarToolTips(controladorSelecionado);
        }

        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;
        }

        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemObjeto = controladorSelecionado.ObterListagem();
            listagemObjeto.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemObjeto);
        }

        //private void CadastrarRegistrosTeste()
        //{
        //    List<Disciplina> disciplinas = new List<Disciplina>()
        //    {
        //        new("Matematica"),
        //        new("Português"),
        //        new("Geografia")
        //    };

        //    repositorioDisciplina.CadastrarVarios(disciplinas);
        //}
    }
}