using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // para usar archivos 
using System.Runtime.Serialization.Formatters.Binary; // para serializar
using System.Runtime.Serialization;
using System.Collections;

namespace EJ2
{
    public partial class FormAgenda : System.Windows.Forms.Form
    {
        protected int NT;
        protected string pass = "";
        public FormAgenda()
        {
            InitializeComponent();
            
            try
            {
                // leer arcivo agenda y cargar objeto lista ver 
                FileStream flujo = new FileStream("Agenda.bin", FileMode.Open);
                BinaryFormatter lector = new BinaryFormatter();
                ClaseListaTareas listaver = (ClaseListaTareas)lector.Deserialize(flujo);
                flujo.Close();
              
                //configuracion de usuario
                if (listaver.FlagOrden=="Fecha") 
                {
                    listaver.OrdenarFecha();
                }
                if(listaver.FlagOrden == "Prioridad")
                {
                    listaver.OrdenarPrioridad();
                }

                // si se debe usar contraseña:
                if (listaver.UsarCont == 1)
                {
                    pass = listaver.Contraseña;   
                    listView1.Visible = false;
                    flowLayoutPanel2.Visible = false;

                    groupBox1.Visible = true;
                }

                //limpiar list view
                listView1.Items.Clear();

                // listaV ataja la list de lista ver 
                List<ClaseTarea> listaV = new List<ClaseTarea>();
                listaV = listaver.TraerLista();

                // mostrar en el list view la lista de tareas
                int i = 0;
                foreach (ClaseTarea tarea in listaV)
                {
                    ListViewItem item = new ListViewItem();
                    item = listView1.Items.Add(tarea.Titulo);
                    item.SubItems.Add(tarea.Prioridad);
                    item.SubItems.Add(tarea.Fecha.ToString());
                    item.SubItems.Add(tarea.Descripcion);
                    item.SubItems.Add(i.ToString());

                    i++;
                }


            }

            catch(System.IO.FileNotFoundException)
            {
                // si no se puede acceder al archivo, se crea
                ClaseListaTareas listaver = new ClaseListaTareas();
                FileStream flujo = new FileStream("Agenda.bin", FileMode.Create);
                BinaryFormatter escritor = new BinaryFormatter();
                escritor.Serialize(flujo, listaver);
                flujo.Close();
            }
            


        }

       


        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_nuev_Click(object sender, EventArgs e)
        {
            //instancio un nuevo form nueva tarea
            FormNuevaTarea NuevaTarea = new FormNuevaTarea();

            // se asigna al evento actualizar el metodo actualiza
            NuevaTarea.Actualizar += new FormNuevaTarea.ActualizarLV(Actualiza);

            //muestro ventana nueva tarea (forma modal)
            NuevaTarea.ShowDialog();
            

        }


        // metodo actualiza 
        public void Actualiza(string flag1 )
        {
            try
            {
                
                FileStream flujo = new FileStream("Agenda.bin", FileMode.Open);
                BinaryFormatter lector = new BinaryFormatter();
                ClaseListaTareas listaver = (ClaseListaTareas)lector.Deserialize(flujo);
                flujo.Close();

                //configuracion de usuario
                if (listaver.FlagOrden == "Fecha")
                {
                    listaver.OrdenarFecha();
                }
                if (listaver.FlagOrden == "Prioridad")
                {
                    listaver.OrdenarPrioridad();
                }

                //limpiar list view
                listView1.Items.Clear();

                // listaV ataja la list de lista ver 
                List<ClaseTarea> listaV = new List<ClaseTarea>();
                listaV = listaver.TraerLista();

                // mostrar en el list view la lista de tareas
                int i=0;
                foreach (ClaseTarea tarea in listaV)
                {
                    ListViewItem item = new ListViewItem();
                    item = listView1.Items.Add(tarea.Titulo);
                    item.SubItems.Add(tarea.Prioridad);
                    item.SubItems.Add(tarea.Fecha.ToString());
                    item.SubItems.Add(tarea.Descripcion);
                    item.SubItems.Add(i.ToString());

                    i++;

                }


            }

            catch (System.IO.FileNotFoundException)
            {
                ClaseListaTareas listaver = new ClaseListaTareas();
            }

        }

        
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void claseTarea1_Click(object sender, EventArgs e)
        {

        }

        private void claseTarea2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelTituloMain.Text = listView1.SelectedItems[0].SubItems[0].Text;
            label1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            label2.Text  = listView1.SelectedItems[0].SubItems[2].Text;
            label3.Text = listView1.SelectedItems[0].SubItems[3].Text;

            groupBoxEsc.Visible = true;
            labelTituloMain.Visible = true;
            buttonCerar.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label3.Visible = true;
            buttonBorrarTarea.Visible = true;


            NT = Convert.ToInt32(listView1.SelectedItems[0].SubItems[4].Text);

            Actualiza("");
        }

        private void buttonCerar_Click(object sender, EventArgs e)
        {
            groupBoxEsc.Visible = false;
            labelTituloMain.Visible = false;
            buttonCerar.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label3.Visible = false;
            buttonBorrarTarea.Visible = false;

        }

        private void buttonBorrarTarea_Click(object sender, EventArgs e)
        {
            FileStream flujo = new FileStream("Agenda.bin", FileMode.Open);
            BinaryFormatter lector = new BinaryFormatter();
            ClaseListaTareas listaver = (ClaseListaTareas)lector.Deserialize(flujo);
            flujo.Close();

            listaver.BorrarTarea(NT);

            // la lista se guarda en el archivo serializado
            FileStream flujo2 = new FileStream("Agenda.bin", FileMode.Create);
            BinaryFormatter escritor = new BinaryFormatter();
            escritor.Serialize(flujo2, listaver);
            flujo2.Close();

            Actualiza("");

            groupBoxEsc.Visible = false;
            labelTituloMain.Visible = false;
            buttonCerar.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label3.Visible = false;
            buttonBorrarTarea.Visible = false;

        }


        //clik en boton configuraciones
        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxEsc.Visible = false;

            //instancio un nuevo form configuraciones 
            FormConfig Configuraciones = new FormConfig();

            // se asigna al evento actualizar el metodo actualiza
            Configuraciones.Actualizar += new FormConfig.ActualizarLV(Actualiza);

            //muestro ventana Configuraciones (forma modal)
            Configuraciones.ShowDialog();


        }


        //Click en boton guardar como archivo de texto
        private void buttonGuardadTxt_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // aca va el codigo para guardar el archivo txt
                // ruta de archivo saveFileDialog1.FileName
                StreamWriter escritor = new StreamWriter((saveFileDialog1.FileName));
                //..............................................
                try
                {
                    FileStream flujo = new FileStream("Agenda.bin", FileMode.Open);
                    BinaryFormatter lector = new BinaryFormatter();
                    ClaseListaTareas listaver = (ClaseListaTareas)lector.Deserialize(flujo);
                    flujo.Close();

                    // listaV ataja la list de lista ver 
                    List<ClaseTarea> listaV = new List<ClaseTarea>();
                    listaV = listaver.TraerLista();

                    // 
                    foreach (ClaseTarea tarea in listaV)
                    {
                        escritor.WriteLine(("------------------------------------------------------------------------------------"));
                        escritor.WriteLine((tarea.Titulo));

                        escritor.WriteLine(("\nPrioridad:"));
                        escritor.WriteLine((tarea.Prioridad));

                        escritor.WriteLine(("\nFecha:"));
                        escritor.WriteLine((tarea.Fecha.ToString()));

                        escritor.WriteLine((tarea.Descripcion));
                        escritor.WriteLine(("------------------------------------------------------------------------------------"));

                    }

                }

                catch (System.IO.FileNotFoundException)
                {
                    escritor.Write(("ERROR AL GUARDAR"));
                }

                //..........................................
                escritor.Close();

            }
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            if (pass == textBoxCont.Text)
            {
                listView1.Visible = true;
                flowLayoutPanel2.Visible = true;

                groupBox1.Visible = false;
            }
            else
            {
                label6.Text = "Contraseña incorrecta. Vuelva a intentarlo";
            }
        }

        //clik en boton almanaque
        private void button2_Click(object sender, EventArgs e)
        {
            //instancio un nuevo form configuraciones 
            FormAlmanaque Almanaque = new FormAlmanaque();

            //muestro ventana Configuraciones (forma modal)
            Almanaque.Show();

        }
    }
}
