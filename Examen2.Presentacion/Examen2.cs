using System;
using System.Data;
using System.Windows.Forms;
using Examen2.Entidades;

namespace Examen2.Presentacion
{
    public partial class Examen2 : Form
    {

        Logica.Operaciones operaciones = new Logica.Operaciones();
        public Examen2()
        {
            InitializeComponent();
            Tabla();
            tablaingrediente();
        }
        void Tabla()
        {
            DataTable table = new DataTable();
            table = operaciones.mostrarTodo();
            dg_menu.DataSource = table;
        }

        void tablaingrediente() {

            DataTable table = new DataTable();
            table = operaciones.mostrarTodo();
            dataGridView1.DataSource = table;

        }
        
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
          //  Entidades.Menu menu = new Entidades.Menu();
//menu.ID = int.Parse(dg_menu.Rows[dg_menu.CurrentRow.Index].Cells[6].Value.ToString());
            operaciones.EliminarMenu (int.Parse(textBox3.Text));
            Tabla();
        }

        private void btn_agregar_ingrediente_Click(object sender, EventArgs e)
        {
            //implementar

            Ingredientes ingredientes = new Ingredientes();
            ingredientes.NombreIngre = textBox2.Text;
            ingredientes.DescripcionIngre = textBox1.Text;
            operaciones.AgregarIngrediente(ingredientes);
            tablaingrediente();
        }

        private void btn_eliminar_ingrediente_Click(object sender, EventArgs e)
        {
            //eliminar

            operaciones.EliminarMenu(int.Parse(textBox3.Text));
            operaciones.EliminarIngrediente(int.Parse(textBox3.Text));
            tablaingrediente();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Entidades.Menu menu = new Entidades.Menu();
            menu.Nombre = txb_nombre.Text;
            menu.Descripcion = txb_descripcion.Text;


            if (rb_desayuno.Checked == true)
            {
                menu.Horario = "Desayuno";
            }
            else if (rb_almuerzo.Checked == true)
            {
                menu.Horario = "Almuerzo";
            }
            else if (rb_cena.Checked == true) {
                menu.Horario = "Cena";
            }
            
            operaciones.realizarPruebas(menu);
            Tabla();

        }

        private void dg_menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pruebas con mesage 

            int rowindex = dg_menu.CurrentRow.Index;
            DataGridViewRow row = dg_menu.Rows[rowindex];
            string h=row.Cells[0].Value.ToString(); 
            int pru = int.Parse(h);
            //MessageBox.Show(row.Cells[0].Value.ToString() + " " + row.Cells[1].Value.ToString() +" " +row.Cells[2].Value.ToString() + " "+row.Cells[3].Value.ToString());



            //L  -> AGREGAR UN INGREDIENTE SACA EL VALOR DEL ID MENU, INGREDIENTE NOMNBRE, DESCRIPCION Y ID DEL MENU
            //sacar un select a ingredientes para poder validarlos los mismos
            // funcion llamar ingrediente
            //envio row.cell...

            //DataGridViewRow row12 = this.dataGridView1.SelectedRows[0];
            //row.Cells["ColumnName"].Value

            //dg_menu.CurrentRow.Cells. CurrentRow.Cells["ColumnName"].Value
            DataTable table1 = new DataTable();
            table1 = operaciones.BuscarIngrediente(int.Parse(h));
            dataGridView1.DataSource = table1;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //modificar
            MessageBox.Show("Debe de estar seguro de haber llenado los campos requeridos para modificar BD, Nombre, descripcion y Horario");
            try
            {
                if (txb_nombre != null && txb_descripcion != null && textBox3 != null) {

                    Entidades.Menu menu = new Entidades.Menu();
                    menu.Nombre = txb_nombre.Text;
                    menu.Descripcion = txb_descripcion.Text;


                    if (rb_desayuno.Checked == true)
                    {
                        menu.Horario = "Desayuno";
                    }
                    else if (rb_almuerzo.Checked == true)
                    {
                        menu.Horario = "Almuerzo";
                    }
                    else if (rb_cena.Checked == true)
                    {
                        menu.Horario = "Cena";
                    }
                    operaciones.modificar(menu);
                    Tabla();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("error modificando");
            }
            Tabla();

        }
    }
}
