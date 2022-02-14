using appProjectLibreria.logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using System.Windows.Forms;

namespace appProjectLibreria.datos
{
    class Db
    {
        /**
         * Conexión a la base de datos 
         */
        OracleConnection conexion = new OracleConnection(@"Data Source = localhost; User ID = labdbproject1; Password = laboratorio");

        /**
         * Métodos y funciones 
         */
        //Método para crear la librería llamando a un procedimiento de PL/SQL 
        public void creacionLibreria(Libreria objLibreria)
        {
            try
            {
                //1. Abrir la conexión 
                conexion.Open();
                //2. Creo la instancia de OracleCommand 
                OracleCommand comando = new OracleCommand();
                comando.Connection = conexion;
                //3. llamo al procedimiento que me hace la inserción en este caso
                comando.CommandText = "PRCINSERTARLIBRERIA";
                //4. Pasamos los paramatros que recibe el procedimiento 
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("v_libnit", objLibreria.LibNit);
                comando.Parameters.Add(" v_libnombre", objLibreria.LibNombre);
                comando.Parameters.Add("v_lidireccion", objLibreria.LibDireccion);

                //3. Ejercutamos la consulta.
                comando.ExecuteNonQuery();

                MessageBox.Show("Librería insertada con éxito", "Crear Librería", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception e)
            {
                MessageBox.Show("Ocurrio un error inesperado, intente nuevamente", "Crear Librería", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                //4. Cerrar la conexión 
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }   
            }
        }
        /**
         * Método para crear el libro 
         */
        public void crearLibro(Libro objLibro)
        {
            try
            {
                //1. Abrir la conexión 
                conexion.Open();
                //2. Creo la instancia de OracleCommand 
                OracleCommand comando = new OracleCommand();
                comando.Connection = conexion;
                //3. llamo al procedimiento que me hace la inserción en este caso
                comando.CommandText = "PRCINSERTARLIBRO";
                //4. Pasamos los paramatros que recibe el procedimiento 
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("v_lbrCodigo", objLibro.LbrCodigo);
                comando.Parameters.Add("v_libnit", objLibro.LibNit);
                comando.Parameters.Add(" v_lbrTitulo", objLibro.LbrTitulo);
                comando.Parameters.Add("v_lbrNopaginas", objLibro.LbrNopaginas);
                comando.Parameters.Add("v_lbrCategoria", objLibro.LbrCategoria);
                comando.Parameters.Add("v_lbrFechaImpresion", objLibro.LbrFechaImpresion);
                comando.Parameters.Add("v_lbrPrecio", objLibro.LbrPrecio);

                //3. Ejercutamos la consulta.
                comando.ExecuteNonQuery();

                MessageBox.Show("Libro insertado con éxito", "Crear Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error inesperado, intente nuevamente", "Crear Libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //4. Cerrar la conexión 
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

            }
        }
        //Método para consultar todas las librerias 
        public DataSet consultarLibrerias()
        {
            try
            {
                //1. Abro la conexion
                conexion.Open();
                //2. invoco el PA de la base de datos que me hace la consulta 
                OracleCommand comando = new OracleCommand("labdbproject1.PRCCONSULTARLIBRERIA", conexion);
                //3. paso los parametros que recibe el procedimiento 
                comando.Parameters.Add("cursorInfoLib", OracleDbType.RefCursor, ParameterDirection.Output);
                comando.CommandType = CommandType.StoredProcedure;
                //4. Creamos un adaptador para llenas el DataSet con los datos de la consulta 
                OracleDataAdapter objAdapter = new OracleDataAdapter(comando);
                //5. Guardo los datos en el DataSet 
                DataSet objData = new DataSet();
                objAdapter.Fill(objData, "Librerias");
                return objData;
            }
            catch (Exception e){
                return null;
            }finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
        /*
         * Método que me permite consultar los libros de una librería de una respectiva categoría.
         */
        public DataSet consultaLibros(int libNit, string lbrCategoria)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("labdbproject1.PRCCONSULTARLIBRO", conexion);
                comando.Parameters.Add("v_nitLibreria", OracleDbType.Decimal, libNit, ParameterDirection.Input);
                comando.Parameters.Add("v_lbrCategoria", OracleDbType.Varchar2, 256, lbrCategoria, ParameterDirection.Input);
                comando.Parameters.Add("v_resultCursor", OracleDbType.RefCursor, ParameterDirection.Output);
                comando.CommandType = CommandType.StoredProcedure;
                OracleDataAdapter objAdatador = new OracleDataAdapter(comando);
                DataSet objData = new DataSet();
                objAdatador.Fill(objData, "Libros");
                return objData;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

    }
}
