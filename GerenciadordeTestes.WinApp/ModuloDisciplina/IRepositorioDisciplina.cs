namespace GerenciadordeTestes.WinApp.ModuloDisciplina
{
    public interface IRepositorioDisciplina
    {
        void Cadastrar(Disciplina novoDisciplina);
        bool Editar(int id, Disciplina disciplinaEditado);
        bool Excluir(int id);
        Disciplina SelecionarPorId(int id);
        List<Disciplina> SelecionarTodos();
        int ObterProximoId();
    }
}