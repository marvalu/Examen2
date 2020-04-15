namespace Examen2.Entidades
{
    public class Ingredientes
    {

        private string _nombreIngre;
        private string _descripcionIngre;
        private int _id;
        //  Menu idMenu;

        public string NombreIngre { get => _nombreIngre; set => _nombreIngre = value; }
        public string DescripcionIngre { get => _descripcionIngre; set => _descripcionIngre = value; }
        public int Id { get => _id; set => _id = value; }

      

        public Ingredientes(string nombreIngre, string descripcionIngre)
        {
            _nombreIngre = nombreIngre;
            _descripcionIngre = descripcionIngre;
            

        }

        public Ingredientes(string nombreIngre, string descripcionIngre, int Id)
        {
            _nombreIngre = nombreIngre;
            _descripcionIngre = descripcionIngre;
            _id = Id;

        }

        public Ingredientes() { }
    }
}
