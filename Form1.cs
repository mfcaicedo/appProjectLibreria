using appProjectLibreria.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appProjectLibreria
{
    public partial class Form1 : Form
    {
        //Instancia de objeto de libreria 
        Libreria objLib = new Libreria();
        Libro objLibro = new Libro();
        Object[] DatosNit; 
        public Form1()
        {
            InitializeComponent();
            consultarLibrerias();
        }

        //Evento del boton crear libreria 
        private void btnCrearLib_Click(object sender, EventArgs e)
        {
            datosLibreria();
        }
        //Evento del boton cancelar -- crear librería
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtNit.ResetText();
            this.txtNombre.ResetText();
            this.txtLibDireccion.ResetText();
        }
        //Acción del boton cancelar crear libro. 
        private void btnLbrCancelar_Click(object sender, EventArgs e)
        {
            this.txtlbrCodigo.ResetText();
            this.txtLbrTitulo.ResetText();
            this.txtLbrNoPaginas.ResetText();
            this.txtLbrPrecio.ResetText();
        }
        private void tabContLib_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verifico   que se haya seleccionado la tabPageConsultarCiuAll para hacer la consulta automática. 
            if (tabContLib.SelectedIndex == 2)
            {
                if (this.comboBoxLibrerias.Items.Count != 0)
                {
                    this.comboBoxLibrerias.Items.Clear();
                }
                cargarComboBoxLibreria(0);
            }else if (tabContLib.SelectedIndex == 3)
            {
                if (this.comboBoxLibreriaConsult.Items.Count != 0)
                {
                    this.comboBoxLibreriaConsult.Items.Clear();
                }
                cargarComboBoxLibreria(1);
            }
        }
        //Evento del botón crearLibro -----
        private void btnLbrCrear_Click(object sender, EventArgs e)
        {
            datosLibro();
        }
        /**
       * Acción del boton Consultar libro. 
       */
        private void btnConsultarLibro_Click(object sender, EventArgs e)
        {
            consultarLibro();
        }
        /*
        * Acción del boton consultar libros
        */
        private void btnOpConsLbr_Click(object sender, EventArgs e)
        {
            tabContLib.SelectedTab = tabPagConsultarLbr;
        }
        /*
         * Acción del boton crear libros 
         */
        private void btnOpCrearLbr_Click(object sender, EventArgs e)
        {
            tabContLib.SelectedTab = tabPagCrearLbr;
        }
        /*
         * Acción del boton crear librería
         */
        private void btnOpCrearLib_Click(object sender, EventArgs e)
        {
            tabContLib.SelectedTab = tabPagCrearLib;
        }
        /**
         * MÉTODOS Y FUNCIONES QUE ME PERMITEN MOSTRAR DATOS EN LA VISTA 
         */

        //Función para llamar a crearLibreria y pasar los parámetros
        private void datosLibreria()
        {
            try
            {
                //Paso los datos de las cajas de texto a los atributos del obj librería
                objLib.LibNit = int.Parse(this.txtNit.Text);
                objLib.LibNombre = this.txtNombre.Text;
                objLib.LibDireccion = this.txtLibDireccion.Text;
                //llamo al método para crear la librería 
                objLib.crearLibreria(objLib);
                //actualizo la tabla de la libreria 
                consultarLibrerias();
            }
            catch (FormatException e)
            {
                if (this.txtNit.Text == "" || this.txtNombre.Text == "" || this.txtLibDireccion.Text == "")
                {
                    MessageBox.Show("Campos vacíos", "Crear Librería", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Tipo de dato incorrecto", "Crear Librería", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Error inesperado, intentelo nuevamente", "Crear Librería", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                //limpiar las campos de texto
                this.txtNit.ResetText();
                this.txtNombre.ResetText();
                this.txtLibDireccion.ResetText();
            }
            
        }
        /**
         *Método para llamar a consultarLibreria  
         */
        private void consultarLibrerias()
        {
            DataSet objDataSet = new DataSet();
            objDataSet = objLib.consultarLibrerias();
            this.dgvLibrerias.DataSource = objDataSet;
            this.dgvLibrerias.DataMember = "Librerias";
            if (objDataSet.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No hay ninguna librería registrada en el sistema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Función para cargar el comboBox con los nombres de las librerías 
        private void cargarComboBoxLibreria(int indicador)
        {
            DataTable objTable = new DataTable();
            DataSet objData = new DataSet();

            //cargo el objData con la consulta de las librerías
            objData = objLib.consultarLibrerias();

            // data.Tables[0] se refire a la tabla que consulté en la DB 
            objTable = objData.Tables[0];

            //Guardo la información obtenida de la consulta en arreglos 
            DatosNit = new object[objTable.Rows.Count];
            Object[] DatosNombre = new object[objTable.Rows.Count];
            for (int i = 0; i < objTable.Rows.Count; i++)
            {
                //Guardar la Columna libNit el el Arreglo
                DatosNit[i] = objTable.Rows[i]["Nit"].ToString();
                //Guardar la Columna libNombre el el Arreglo
                DatosNombre[i] = objTable.Rows[i]["Nombre"].ToString();
            }
            if (indicador == 1)
            {
                //lleno el comboBox con los nombre en el formulario de consultar libro
                for (int i = 0; i < DatosNombre.Length; i++)
                {
                    comboBoxLibreriaConsult.Items.Add(DatosNombre[i]);
                }
            }
            //Por default lleno el comoBox con los nombres en el formulario de crear libro
            for (int i = 0; i < DatosNombre.Length; i++)
            {
                comboBoxLibrerias.Items.Add(DatosNombre[i]);
            }
        }
        /**
        * Función para llamar a crearLibro y pasar los parámetros
        */
        private void datosLibro()
        {
            try
            {
                int nitLibreria = Convert.ToInt32(DatosNit[this.comboBoxLibrerias.SelectedIndex]);
                //paso los datos al objeto de libro
                objLibro.LbrCodigo = int.Parse(this.txtlbrCodigo.Text);
                objLibro.LibNit = nitLibreria;
                objLibro.LbrTitulo = this.txtLbrTitulo.Text;
                objLibro.LbrNopaginas = int.Parse(this.txtLbrNoPaginas.Text);
                objLibro.LbrCategoria = this.comboBoxLbrCat.SelectedItem.ToString();
                objLibro.LbrFechaImpresion = this.dateImpLibro.Value.ToString("dd/MM/yyyy");
                objLibro.LbrPrecio = double.Parse(this.txtLbrPrecio.Text);

                //llamo a la función para crear el libro. 
                objLibro.crearLibro(objLibro);
            }
            catch (FormatException e)
            {
                if (this.txtlbrCodigo.Text == "" || this.txtLbrTitulo.Text == "" || this.txtLbrPrecio.Text == "" ||
                    this.txtLbrNoPaginas.Text == "")
                {
                    MessageBox.Show("Campos vacíos", "Crear Libro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Tipo de dato incorrecto", "Crear Libro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error inesperado, intentelo nuevamente", "Crear Libro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                //limpiar las campos de texto
                this.txtlbrCodigo.ResetText();
                this.txtLbrTitulo.ResetText();
                this.txtLbrNoPaginas.ResetText();
                this.txtLbrPrecio.ResetText();
            }
        }
        /*
        * Método para llamar a consultarLibro con sus respectivos parámetros.
        */
        private void consultarLibro()
        {         
                //valido que se haya seleccionado un elemento en los combobox 
                if (this.comboBoxLibreriaConsult.SelectedItem == null)
                {
                    MessageBox.Show("¡Error! debe seleccionar una librería antes de hacer la consulta", "Consultar Libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else if (this.comboBoxCatLibroConsult.SelectedItem == null)
                {
                    MessageBox.Show("¡Error! debe seleccionar la categoría del libro antes de hacer la consulta", "Consultar Libro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DataSet objData = new DataSet();
                    //nit de la librería seleccionada
                    int libNit = Convert.ToInt32(DatosNit[this.comboBoxLibreriaConsult.SelectedIndex]);
                    string lbrCategoria = this.comboBoxCatLibroConsult.SelectedItem.ToString();
                    //llamo al método de consultar libro
                    objData = objLibro.consultarLibro(libNit, lbrCategoria);
                    //Lleno el DataGridView con la información de la consulta. 
                    this.dgvResultConsulta.DataSource = objData;
                    this.dgvResultConsulta.DataMember = "Libros";

                    if (objData.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("No hay ningún libro con los datos seleccionados en la consulta", "Consultar Libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
        }
    }
}
