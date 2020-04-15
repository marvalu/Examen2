using System.Data;

namespace Examen2.AccessoDatos
{
    public interface IOperaciones<T>
    {
        void Insertar(T entidad);
        void Elminiar(int id);
        void Modificar(T entidad);
        DataTable Buscar(int id);
        DataTable BuscarTodos();


    }
}
