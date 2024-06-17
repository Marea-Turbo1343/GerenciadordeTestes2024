using GerenciadordeTestes.WinApp.ModuloDisciplina;

namespace GerenciadordeTestes.WinApp.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        private Materia materia;
        private IRepositorioMateria repositorioMateria;
        private bool modoEdicao;

        public Materia Materia
        {
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                cmbDisciplinas.SelectedItem = value.Disciplina;

                if (rdbPrimeira.Checked == true)
                {
                    value.Serie = "1ª";
                }
                if (rdbSegunda.Checked == true)
                {
                    value.Serie = "2ª";
                }
            }
            get => materia;
        }

        public TelaMateriaForm(IRepositorioMateria repositorioMateria, bool modoEdicao = false)
        {
            InitializeComponent();

            this.repositorioMateria = repositorioMateria;
            this.modoEdicao = modoEdicao;

            if (modoEdicao)
            {
                this.Text = "Editar Matéria";
            }
            else
            {
                int proximoId = repositorioMateria.ObterProximoId();
                txtId.Text = proximoId.ToString();
            }
        }

        public void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cmbDisciplinas.Items.Clear();

            foreach (Disciplina d in disciplinas)
                cmbDisciplinas.Items.Add(d);
        }

        private void rdbPrimeira_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPrimeira.Checked == true)
                rdbSegunda.Checked = false;
            else
                rdbSegunda.Checked = true;
        }

        private void rdbSegunda_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSegunda.Checked == true)
                rdbPrimeira.Checked = false;
            else
                rdbPrimeira.Checked = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            Disciplina disciplina = (Disciplina)cmbDisciplinas.SelectedItem;
            string serie = "";

            if (rdbPrimeira.Checked == true)
            {
                serie = "1ª";
            }
            if (rdbSegunda.Checked == true)
            {
                serie = "2ª";
            }

            materia = new Materia(nome, disciplina, serie);

            List<string> erros = disciplina.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}