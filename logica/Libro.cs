using appProjectLibreria.datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appProjectLibreria.logica
{
    class Libro
    {

        /**
         * Atributos 
         */
        private int lbrCodigo;
        private int libNit; 
        private string lbrTitulo;
        private int lbrNopaginas;
        private string lbrCategoria;
        private string lbrFechaImpresion;
        private double lbrPrecio;

        //instancia de objetos 
        Db objDb = new Db();
        /**
         * Constructor 
         */
        public Libro()
        {

        }
        public Libro(int lbrCodigo, int libNit, string lbrTitulo, int lbrNopaginas, 
                    string lbrCategoria, string lbrFechaImpresion, double lbrPrecio)
        {
            this.LbrCodigo = lbrCodigo;
            this.LibNit = libNit;
            this.LbrTitulo = lbrTitulo;
            this.LbrNopaginas = lbrNopaginas;
            this.LbrCategoria = lbrCategoria;
            this.LbrFechaImpresion = lbrFechaImpresion;
            this.LbrPrecio = lbrPrecio; 
        }
        /**
       * Getters and setters 
       */
        public int LbrCodigo { get => lbrCodigo; set => lbrCodigo = value; }
        public int LibNit { get => libNit; set => libNit = value; }
        public string LbrTitulo { get => lbrTitulo; set => lbrTitulo = value; }
        public int LbrNopaginas { get => lbrNopaginas; set => lbrNopaginas = value; }
        public string LbrCategoria { get => lbrCategoria; set => lbrCategoria = value; }
        public string LbrFechaImpresion { get => lbrFechaImpresion; set => lbrFechaImpresion = value; }
        public double LbrPrecio { get => lbrPrecio; set => lbrPrecio = value; }

        /**
         * Métodos y funciones 
         */
        public void crearLibro(Libro objLibro)
        {
            //llamo la función que hace la inserción en la base de datos con un PA (PL/SQL)
            objDb.crearLibro(objLibro);
        }
        /**
         * Método para consultar un libro 
         */
        public DataSet consultarLibro(int libNit, string lbrCategoria)
        {
            DataSet objData = new DataSet(); 
            objData = objDb.consultaLibros(libNit, lbrCategoria);
            return objData;
        }


    }
}
