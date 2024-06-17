using GerenciadordeTestes.WinApp.Compartilhado;
using GerenciadordeTestes.WinApp.ModuloMateria;

namespace GerenciadordeTestes.WinApp.ModuloDisciplina
{
    public class Disciplina : EntidadeBase
    {
        public string Nome { get; set; }

        public List<Materia> Materias { get; set; }

        public Disciplina()
        {
        }

        public Disciplina(string nome)
        {
            Nome = nome;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Disciplina atualizado = (Disciplina)novoRegistro;

            Nome = atualizado.Nome;
        }

        public bool ExisteDisciplina(List<Disciplina> disciplinas)
        {
            foreach (Disciplina d in disciplinas)
                if (d.Nome == Nome)
                    return true;

            return false;
        }

        public override string ToString()
        {
            return Nome.ToTitleCase();
        }
    }
}