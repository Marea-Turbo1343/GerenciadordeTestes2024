﻿using Gerador_de_Testes.Compartilhado;
using Gerador_de_Testes.ModuloMateria;
//using GerenciadordeTestes.WinApp.ModuloMateria;
using GerenciadordeTestes.WinApp;
using static System.Net.Mime.MediaTypeNames;
namespace Gerador_de_Testes.ModuloDisciplina
{
    public partial class TelaDisciplinaForm : Form
    {
        private List<Materia> materias = [];
        private Disciplina disciplina;
        public Disciplina Disciplina
        {
            get => disciplina;
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                foreach (Materia m in value.Materias)
                    materias.Add(m);
            }
        }
        ContextoDados contexto;
        readonly int id;

        public TelaDisciplinaForm(int id, ContextoDados contexto)
        {
            InitializeComponent();
            txtId.Text = id.ToString();
            this.contexto = contexto;
            this.id = id;
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            if (ValidarNome(nome)) return;

            disciplina = new(nome, materias);

            ValidacaoDeCampos(disciplina);
        }

        private bool ValidarNome(string nome)
        {
            foreach (Disciplina d in contexto.Disciplinas)
                if (d.Nome.Validation() == nome.Validation())
                    if (d.Id != id)
                    {
                        TelaPrincipalForm.Instancia.AtualizarRodape(
                            $"Já existe uma disciplina com o nome \"{nome.ToTitleCase().Trim()}\". Tente novamente.");

                        DialogResult = DialogResult.None;
                        return true;
                    }
            return false;
        }
        private void ValidacaoDeCampos(EntidadeBase entidade)
        {
            List<string> erros = entidade.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}