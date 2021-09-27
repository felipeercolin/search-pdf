using System.Collections.Generic;

namespace SearchPdf.Interfaces
{
    interface IBaseServiceNegocio<T> where T : class
    {
        List<T> SelectTodos(bool desativa);

        List<T> SelectTodos(string nome, bool desativa);

        T SelectPorId(int id);

        T Save(T entidade);

        bool UpdateAtivaDesativa(int id, bool desativa);
    }
}
