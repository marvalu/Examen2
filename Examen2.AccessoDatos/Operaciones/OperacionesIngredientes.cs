using Examen2.Entidades;
using System.Data;

namespace Examen2.AccessoDatos
{
    public class OperacionesIngredientes : IOperaciones<Ingredientes>
    {
        Conexion conexion = new Conexion();
        public DataTable Buscar(int id)
        {
            throw new System.NotImplementedException();
        }

        public DataTable BuscarTodos()
        {
            string query = string.Format("SELECT * FROM Ingredientes;");

            return conexion.ConexionADO(query);

           
        }

        public void Elminiar(int id)
        {
            // string query = string.Format("DELETE Direccion WHERE Telefono = {0};", item.Id);
            string query = string.Format("Delete dbo.Ingrediente WHERE IdIngrediente= {0};", id);
            conexion.NonQuery(query);
        }

        public void Insertar(Ingredientes entidad)
        {
            string query = string.Format("INSERT INTO[dbo].[Ingredientes](Nombre, Descripcion)" + " VALUES ('{0}','{1}');", entidad.NombreIngre, entidad.DescripcionIngre);
            conexion.NonQuery(query);


        }

        public void Modificar(Ingredientes entidad)
        {
            throw new System.NotImplementedException();
        }
    }
}
