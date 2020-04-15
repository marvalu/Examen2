using Examen2.AccessoDatos;
using Examen2.Entidades;
using System.Data;

namespace Examen2.Logica
{
    public class Operaciones
    {

        #region Operaciones Menu




        Menu menu = new Menu("prueba", "Prueba", "pru");


        OperacionesMenu operacionesMenu = new OperacionesMenu();

        public void realizarPruebas(Menu menu)
        {

            operacionesMenu.Insertar(menu);
        }
        public DataTable mostrarTodo() {

            return operacionesMenu.BuscarTodos();
        }


        public void EliminarMenu(int nombre) {


            operacionesMenu.Elminiar(nombre);
        
        
        }

        public void modificar(Menu menu) {

            operacionesMenu.Modificar(menu);
        
        
        }

        public DataTable BuscarIngrediente(int id) {

            return operacionesMenu.Buscar(id);
        }

        #endregion

        #region Operaciones Ingredientes

        #endregion







    }
}
