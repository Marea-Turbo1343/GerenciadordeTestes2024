using GerenciadordeTestes.WinApp.ModuloDisciplina;

namespace GerenciadordeTestes.WinApp.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        private Materia materia;

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

        public TelaMateriaForm()
        {
            InitializeComponent();
        }

        public void CarregarDisciplinas(List<Disciplina> disciplinas)
        {
            cmbDisciplinas.Items.Clear();

            foreach (Disciplina d in disciplinas)
                cmbDisciplinas.Items.Add(d);
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
    }
}