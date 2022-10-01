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
using System.Linq;

namespace EJ2
{
    public partial class FormAlmanaque : Form
    {
        public FormAlmanaque()
        {
            InitializeComponent();

            //cargar lista actual si existe el archivo
            try
            {
                FileStream flujo1 = new FileStream("Agenda.bin", FileMode.Open, FileAccess.Read);
                BinaryFormatter lector = new BinaryFormatter();
                ClaseListaTareas listaAlmanaque = (ClaseListaTareas)lector.Deserialize(flujo1);
                flujo1.Close();

                // lista ataja la list de el objeto listaAlmanaque 
                List<ClaseTarea> lista = new List<ClaseTarea>();
                lista = listaAlmanaque.TraerLista();

                var count= lista.Count();//var contiene la cantidad de elementos de lista

                DateTime[] dias = new DateTime[count];
                int i = 0;

                //obtengo las fechas de las tareas 
                foreach (ClaseTarea tarea in lista)
                {
                    dias [i] = tarea.Fecha;
                    i++;
                }

                //las fechas de las tareas se muestran en negritas
                monthCalendar1.BoldedDates = dias;
            }

            catch (System.IO.FileNotFoundException) { }
        }

        private void FormAlmanaque_Load(object sender, EventArgs e)
        { 

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
