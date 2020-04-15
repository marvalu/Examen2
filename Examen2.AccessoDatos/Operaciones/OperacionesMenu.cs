using Examen2.Entidades;
using System;
using System.Data;

namespace Examen2.AccessoDatos
{

    public class OperacionesMenu : IOperaciones<Menu>
    {
        Conexion conexion = new Conexion();
        public DataTable Buscar(int id)
        {
            string query = string.Format("SELECT * FROM Ingredientes Where IdMenu = {0};",id);

            return conexion.ConexionADO(query);
        }

        public DataTable BuscarTodos()
        {
            string query = string.Format("SELECT * FROM Menu;");

            return conexion.ConexionADO(query);
        }

        public void Elminiar(int id)
        {
            // string query = string.Format("DELETE Direccion WHERE Telefono = {0};", item.Id);
            string query = string.Format("Delete dbo.Menu WHERE IdMenu= {0};", id);
            conexion.NonQuery(query);
        }

        public void Insertar(Menu entidad)
        {
            string query = string.Format("INSERT INTO dbo.Menu (Nombre,Descripcion,Horario) " + "VALUES('{0}','{1}','{2}');", entidad.Nombre, entidad.Descripcion, entidad.Horario);
            conexion.NonQuery(query);




        }

        public void Modificar(Menu entidad)
        {

            string query = string.Format("UPDATE dbo.Menu SET Nombre='{0}',Descripcion='{1}',Horario='{2}' WHERE IdMenu= '{3}'; ", entidad.Nombre, entidad.Descripcion, entidad.Horario, entidad.ID);
            conexion.NonQuery(query);
        }


        
    }
}
