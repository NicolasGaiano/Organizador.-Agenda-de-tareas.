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


    public partial class FormConfig : Form
    {
        // delegado y evento actualizar 
        public delegate void ActualizarLV(string flag1);
        public event ActualizarLV Actualizar;

        public FormConfig()
        {
            InitializeComponent();
            try
            {
                FileStream flujo1 = new FileStream("Agenda.bin", FileMode.Open, FileAccess.Read);
                BinaryFormatter lector = new BinaryFormatter();
                ClaseListaTareas lista = (ClaseListaTareas)lector.Deserialize(flujo1);
                flujo1.Close();

                textBoxContra.Text = lista.Contraseña;
                if (lista.UsarCont == 1) 
                {
                    checkBox1.Checked = true;
                }

                comboBoxConf.Text = lista.FlagOrden;
                
                
            }

            catch (System.IO.FileNotFoundException) { }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxConf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfGuardar_Click(object sender, EventArgs e)
        {
            //guardar configuracion de usuario

            if (comboBoxConf.Text == "Fecha")
            {
                //cargar lista actual
                try
                {
                    FileStream flujo1 = new FileStream("Agenda.bin", FileMode.Open, FileAccess.Read);
                    BinaryFormatter lector = new BinaryFormatter();
                    ClaseListaTareas listaOrdenar = (ClaseListaTareas)lector.Deserialize(flujo1);
                    flujo1.Close();

                    listaOrdenar.OrdenarFecha();
                    listaOrdenar.FlagOrden = comboBoxConf.Text;

                    // la lista se guarda en el archivo serializado
                    FileStream flujo = new FileStream("Agenda.bin", FileMode.Create);
                    BinaryFormatter escritor = new BinaryFormatter();
                    escritor.Serialize(flujo, listaOrdenar);
                    flujo.Close();

                }

                catch (System.IO.FileNotFoundException) { }

                

            }
            if (comboBoxConf.Text == "Prioridad")
            {
                //cargar lista actual
                try
                {
                    FileStream flujo1 = new FileStream("Agenda.bin", FileMode.Open, FileAccess.Read);
                    BinaryFormatter lector = new BinaryFormatter();
                    ClaseListaTareas listaOrdenar = (ClaseListaTareas)lector.Deserialize(flujo1);
                    flujo1.Close();

                    listaOrdenar.OrdenarPrioridad();
                    listaOrdenar.FlagOrden = comboBoxConf.Text;

                    // la lista se guarda en el archivo serializado
                    FileStream flujo = new FileStream("Agenda.bin", FileMode.Create);
                    BinaryFormatter escritor = new BinaryFormatter();
                    escritor.Serialize(flujo, listaOrdenar);
                    flujo.Close();

                   
                }

                catch (System.IO.FileNotFoundException) { }

            }


            //cargar lista actual
            try
            {
                FileStream flujo1 = new FileStream("Agenda.bin", FileMode.Open, FileAccess.Read);
                BinaryFormatter lector = new BinaryFormatter();
                ClaseListaTareas listaver = (ClaseListaTareas)lector.Deserialize(flujo1);
                flujo1.Close();

                listaver.Contraseña = textBoxContra.Text;
                if (checkBox1.Checked == true)
                {
                    listaver.UsarCont = 1;
                }
                else
                {
                    listaver.UsarCont = 0;
                }

                // la lista se guarda en el archivo serializado
                FileStream flujo = new FileStream("Agenda.bin", FileMode.Create);
                BinaryFormatter escritor = new BinaryFormatter();
                escritor.Serialize(flujo, listaver);
                flujo.Close();


            }

            catch (System.IO.FileNotFoundException) { }

            //evento actualizar 

            string f2 = "";
                Actualizar(f2);
            

            this.Close();
        }

        private void buttonConfCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
