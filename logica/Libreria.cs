using appProjectLibreria.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProjectLibreria.logica
{
    class Libreria
    {
        /*Atributos*/
        private int libNit;
        private string libNombre;
        private string libDireccion;
        //intancia de Db
        Db objdb = new Db();
        /*Constructor*/
        public Libreria()
        {

        }
        public Libreria(int libNit, string libNombre, string libDireccion)
        {
            this.LibNit = libNit;
            this.LibNombre = libNombre;
            this.LibDireccion = libDireccion;
        }

        /*Getters and setters*/
        public int LibNit { get => libNit; set => libNit = value; }
        public string LibNombre { get => libNombre; set => libNombre = value; }
        public string LibDireccion { get => libDireccion; set => libDireccion = value; }

        /**
         * Métodos y funciones 
         */
        /*Método para crear la librería*/
        public void crearLibreria(Libreria objLibreria)
        {
            //llamo a la función que me hace el insert en la base de datos 
            objdb.creacionLibreria(objLibreria);
        }
        /**
         * Método para consultar las librerias 
         */
        public DataSet consultarLibrerias()
        {
            DataSet objDataSet = new DataSet();
            objDataSet = objdb.consultarLibrerias();
            return objDataSet; 
        }
        
    }
}
