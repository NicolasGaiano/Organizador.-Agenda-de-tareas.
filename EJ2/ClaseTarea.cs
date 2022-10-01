using System;
using System.Collections.Generic;
using System.Text;
using System.IO; // para usar archivos 
using System.Runtime.Serialization.Formatters.Binary; // para serializar
using System.Runtime.Serialization;
using System.Linq; // para orderBy

namespace EJ2
{
    [Serializable]
    class ClaseTarea 
    {
        protected string titulo;
        protected DateTime fecha;
        protected string prioridad;
        protected string descripcion;

        
       public ClaseTarea()
        {

        }

        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }
        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }
        public string Prioridad
        {
            get
            {
                return prioridad;
            }
            set
            {
                prioridad = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

    }

    [Serializable]
    class ClaseListaTareas
    {
        public List<ClaseTarea> listaTareas = new List<ClaseTarea>();

        protected string contraseña = "";
        protected    int usarCont = 0;
        protected string flagOrden = "Fecha";



        public ClaseListaTareas()
        {

        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }
            set
            {
                contraseña = value;
            }
        }
        public int UsarCont
        {
            get
            {
                return usarCont;
            }
            set
            {
                usarCont = value;
            }
        }
        public string FlagOrden
        {
            get
            {
                return flagOrden;
            }
            set
            {
                flagOrden = value;
            }
        }

        public void Guardar(ClaseTarea NuevaTarea)
        {
            //la tarea se agrega a lalista
            listaTareas.Add(NuevaTarea);

        }
        public ClaseTarea VerTarea(int i)
        {
            //maneja la excepcion i fuera de la lista
            try
            {
                return listaTareas[i];
            }
            
            catch (SystemException)
            {
                ClaseTarea t = new ClaseTarea();
                t.Titulo = "ERROR";
                return t;
            }
            
        }

        public List<ClaseTarea> TraerLista()
        {
            return listaTareas;
        }

        public void BorrarTarea(int NT)
        {
            listaTareas.RemoveAt(NT);
        }


        public void OrdenarFecha()
        {

            IEnumerable<ClaseTarea> lisTareasOrd = listaTareas.OrderBy(tareas => tareas.Fecha);

            listaTareas =lisTareasOrd.ToList();
        }

        public void OrdenarPrioridad()
        {
            IEnumerable<ClaseTarea> lisTareasOrd = listaTareas.OrderBy(tareas => tareas.Prioridad);

            listaTareas = lisTareasOrd.ToList();

        }
    }
}
