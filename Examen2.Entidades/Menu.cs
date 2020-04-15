namespace Examen2.Entidades
{
    public class Menu
    {

        private string _nombre;
        private string _descripcion;
        private string _horario;
        private int _id;



        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Horario { get => _horario; set => _horario = value; }
        public int ID { get => _id; set => _id = value; }
        public Menu(string nombre, string descripcion, string horario, int ID)
        {
            _nombre = nombre;
            _descripcion = descripcion;
            _horario = horario;
            _id = ID;
        }
        public Menu(string nombre, string descripcion, string horario)
        {
            _nombre = nombre;
            _descripcion = descripcion;
            _horario = horario;
            
        }
        public Menu() { }



    }
}
