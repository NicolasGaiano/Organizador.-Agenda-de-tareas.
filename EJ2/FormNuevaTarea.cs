using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO; // para usar archivos 
using System.Runtime.Serialization.Formatters.Binary; // para serializar
using System.Runtime.Serialization;

namespace EJ2
{
    public partial class FormNuevaTarea : System.Windows.Forms.Form
    {
        ClaseListaTareas listaguardar = new ClaseListaTareas();

        // delegado y evento actualizar 
        public delegate void ActualizarLV(string flag1);
        public event ActualizarLV Actualizar;

        public FormNuevaTarea()
        {
            InitializeComponent();

           
        }

        private void FormNuevaTarea_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuarTarea_Click(object sender, EventArgs e)
        {
            //al hacer click en guardar instacio un nuevo objeo Tarea
            ClaseTarea Tarea = new ClaseTarea();

            Tarea.Titulo = textBoxTitulo.Text;
            Tarea.Fecha = dateTimePicker1.Value;
            Tarea.Prioridad = comboBoxPrioridad.Text;
            Tarea.Descripcion = richTextBoxDescripcion.Text;

            //cargar lista actual
            try { 
            FileStream flujo1 = new FileStream("Agenda.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter lector = new BinaryFormatter();
            listaguardar = (ClaseListaTareas)lector.Deserialize(flujo1);
            flujo1.Close();
            }

            catch (System.IO.FileNotFoundException) { }

            //agregar tarea a la lista
             listaguardar.Guardar(Tarea);

            // la lista se guarda en el archivo serializado
            FileStream flujo = new FileStream("Agenda.bin", FileMode.Create);
            BinaryFormatter escritor = new BinaryFormatter();
            escritor.Serialize(flujo, listaguardar);
            flujo.Close();

            //al guardar ocurre el evento actualizar 
                string fl = "";
                Actualizar(fl);
              
            
            this.Close();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
