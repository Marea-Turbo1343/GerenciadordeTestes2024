namespace GerenciadordeTestes.WinApp.ModuloMateria
{
    public interface IRepositorioMateria
    {
        void Cadastrar(Materia novoMateria);
        bool Editar(int id, Materia materiaEditado);
        bool Excluir(int id);
        Materia SelecionarPorId(int id);
        List<Materia> SelecionarTodos();
        int ObterProximoId();
    }
}