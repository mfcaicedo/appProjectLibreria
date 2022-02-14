
namespace appProjectLibreria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.tabContLib = new System.Windows.Forms.TabControl();
            this.tabPagIndex = new System.Windows.Forms.TabPage();
            this.pnlOpcionesLibreria = new System.Windows.Forms.Panel();
            this.lblMejorOpcion = new System.Windows.Forms.Label();
            this.btnOpConsLbr = new System.Windows.Forms.Button();
            this.btnOpCrearLbr = new System.Windows.Forms.Button();
            this.btnOpCrearLib = new System.Windows.Forms.Button();
            this.pnlContenedorLibrerias = new System.Windows.Forms.Panel();
            this.dgvLibrerias = new System.Windows.Forms.DataGridView();
            this.lblNomLib = new System.Windows.Forms.Label();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.lblTituloIndex = new System.Windows.Forms.Label();
            this.tabPagCrearLib = new System.Windows.Forms.TabPage();
            this.pnlContenedorForLib = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrearLib = new System.Windows.Forms.Button();
            this.txtLibDireccion = new System.Windows.Forms.TextBox();
            this.lblLIbDireccion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblLibNombre = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.lblLibNit = new System.Windows.Forms.Label();
            this.lblForLib = new System.Windows.Forms.Label();
            this.tabPagCrearLbr = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLbrPrecio = new System.Windows.Forms.Label();
            this.dateImpLibro = new System.Windows.Forms.DateTimePicker();
            this.lblLbrFecha = new System.Windows.Forms.Label();
            this.comboBoxLbrCat = new System.Windows.Forms.ComboBox();
            this.txtLbrNoPaginas = new System.Windows.Forms.TextBox();
            this.lblLbrNoPaginas = new System.Windows.Forms.Label();
            this.comboBoxLibrerias = new System.Windows.Forms.ComboBox();
            this.lblLibreriaSelec = new System.Windows.Forms.Label();
            this.btnLbrCancelar = new System.Windows.Forms.Button();
            this.btnLbrCrear = new System.Windows.Forms.Button();
            this.txtLbrPrecio = new System.Windows.Forms.TextBox();
            this.lblLbrCategoria = new System.Windows.Forms.Label();
            this.txtLbrTitulo = new System.Windows.Forms.TextBox();
            this.lblLbrTitulo = new System.Windows.Forms.Label();
            this.txtlbrCodigo = new System.Windows.Forms.TextBox();
            this.lblLbrCodigo = new System.Windows.Forms.Label();
            this.tabPagConsultarLbr = new System.Windows.Forms.TabPage();
            this.pnlDatosConsulta = new System.Windows.Forms.Panel();
            this.btnConsultarLibro = new System.Windows.Forms.Button();
            this.comboBoxCatLibroConsult = new System.Windows.Forms.ComboBox();
            this.lblLbrCat = new System.Windows.Forms.Label();
            this.comboBoxLibreriaConsult = new System.Windows.Forms.ComboBox();
            this.lblSelectLibreriaConsult = new System.Windows.Forms.Label();
            this.lblDatosConsulta = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.pnlResultConsulta = new System.Windows.Forms.Panel();
            this.dgvResultConsulta = new System.Windows.Forms.DataGridView();
            this.pnlContenedor.SuspendLayout();
            this.tabContLib.SuspendLayout();
            this.tabPagIndex.SuspendLayout();
            this.pnlOpcionesLibreria.SuspendLayout();
            this.pnlContenedorLibrerias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrerias)).BeginInit();
            this.tabPagCrearLib.SuspendLayout();
            this.pnlContenedorForLib.SuspendLayout();
            this.tabPagCrearLbr.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPagConsultarLbr.SuspendLayout();
            this.pnlDatosConsulta.SuspendLayout();
            this.pnlResultConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.tabContLib);
            this.pnlContenedor.Location = new System.Drawing.Point(12, 12);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(891, 444);
            this.pnlContenedor.TabIndex = 0;
            // 
            // tabContLib
            // 
            this.tabContLib.Controls.Add(this.tabPagIndex);
            this.tabContLib.Controls.Add(this.tabPagCrearLib);
            this.tabContLib.Controls.Add(this.tabPagCrearLbr);
            this.tabContLib.Controls.Add(this.tabPagConsultarLbr);
            this.tabContLib.Location = new System.Drawing.Point(3, 3);
            this.tabContLib.Name = "tabContLib";
            this.tabContLib.RightToLeftLayout = true;
            this.tabContLib.SelectedIndex = 0;
            this.tabContLib.Size = new System.Drawing.Size(863, 412);
            this.tabContLib.TabIndex = 0;
            this.tabContLib.SelectedIndexChanged += new System.EventHandler(this.tabContLib_SelectedIndexChanged);
            // 
            // tabPagIndex
            // 
            this.tabPagIndex.BackgroundImage = global::appProjectLibreria.Properties.Resources.background1;
            this.tabPagIndex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPagIndex.Controls.Add(this.pnlOpcionesLibreria);
            this.tabPagIndex.Controls.Add(this.pnlContenedorLibrerias);
            this.tabPagIndex.Controls.Add(this.lblOpciones);
            this.tabPagIndex.Controls.Add(this.lblTituloIndex);
            this.tabPagIndex.Location = new System.Drawing.Point(4, 22);
            this.tabPagIndex.Name = "tabPagIndex";
            this.tabPagIndex.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagIndex.Size = new System.Drawing.Size(855, 386);
            this.tabPagIndex.TabIndex = 0;
            this.tabPagIndex.Text = "Indice";
            this.tabPagIndex.UseVisualStyleBackColor = true;
            // 
            // pnlOpcionesLibreria
            // 
            this.pnlOpcionesLibreria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(126)))), ((int)(((byte)(89)))));
            this.pnlOpcionesLibreria.Controls.Add(this.lblMejorOpcion);
            this.pnlOpcionesLibreria.Controls.Add(this.btnOpConsLbr);
            this.pnlOpcionesLibreria.Controls.Add(this.btnOpCrearLbr);
            this.pnlOpcionesLibreria.Controls.Add(this.btnOpCrearLib);
            this.pnlOpcionesLibreria.ForeColor = System.Drawing.Color.Transparent;
            this.pnlOpcionesLibreria.Location = new System.Drawing.Point(646, 132);
            this.pnlOpcionesLibreria.Name = "pnlOpcionesLibreria";
            this.pnlOpcionesLibreria.Size = new System.Drawing.Size(185, 248);
            this.pnlOpcionesLibreria.TabIndex = 8;
            // 
            // lblMejorOpcion
            // 
            this.lblMejorOpcion.AutoSize = true;
            this.lblMejorOpcion.BackColor = System.Drawing.Color.Transparent;
            this.lblMejorOpcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMejorOpcion.Location = new System.Drawing.Point(3, 132);
            this.lblMejorOpcion.Name = "lblMejorOpcion";
            this.lblMejorOpcion.Size = new System.Drawing.Size(162, 19);
            this.lblMejorOpcion.TabIndex = 7;
            this.lblMejorOpcion.Text = "Elige la mejor opción !!";
            // 
            // btnOpConsLbr
            // 
            this.btnOpConsLbr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(122)))));
            this.btnOpConsLbr.Location = new System.Drawing.Point(39, 54);
            this.btnOpConsLbr.Name = "btnOpConsLbr";
            this.btnOpConsLbr.Size = new System.Drawing.Size(98, 23);
            this.btnOpConsLbr.TabIndex = 6;
            this.btnOpConsLbr.Text = "Consultar libros";
            this.btnOpConsLbr.UseVisualStyleBackColor = false;
            this.btnOpConsLbr.Click += new System.EventHandler(this.btnOpConsLbr_Click);
            // 
            // btnOpCrearLbr
            // 
            this.btnOpCrearLbr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(122)))));
            this.btnOpCrearLbr.Location = new System.Drawing.Point(39, 94);
            this.btnOpCrearLbr.Name = "btnOpCrearLbr";
            this.btnOpCrearLbr.Size = new System.Drawing.Size(98, 23);
            this.btnOpCrearLbr.TabIndex = 5;
            this.btnOpCrearLbr.Text = "Crear libro";
            this.btnOpCrearLbr.UseVisualStyleBackColor = false;
            this.btnOpCrearLbr.Click += new System.EventHandler(this.btnOpCrearLbr_Click);
            // 
            // btnOpCrearLib
            // 
            this.btnOpCrearLib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(122)))));
            this.btnOpCrearLib.Location = new System.Drawing.Point(39, 14);
            this.btnOpCrearLib.Name = "btnOpCrearLib";
            this.btnOpCrearLib.Size = new System.Drawing.Size(98, 23);
            this.btnOpCrearLib.TabIndex = 4;
            this.btnOpCrearLib.Text = "Crear librería";
            this.btnOpCrearLib.UseVisualStyleBackColor = false;
            this.btnOpCrearLib.Click += new System.EventHandler(this.btnOpCrearLib_Click);
            // 
            // pnlContenedorLibrerias
            // 
            this.pnlContenedorLibrerias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(126)))), ((int)(((byte)(89)))));
            this.pnlContenedorLibrerias.Controls.Add(this.dgvLibrerias);
            this.pnlContenedorLibrerias.Controls.Add(this.lblNomLib);
            this.pnlContenedorLibrerias.Location = new System.Drawing.Point(47, 128);
            this.pnlContenedorLibrerias.Name = "pnlContenedorLibrerias";
            this.pnlContenedorLibrerias.Size = new System.Drawing.Size(572, 196);
            this.pnlContenedorLibrerias.TabIndex = 7;
            // 
            // dgvLibrerias
            // 
            this.dgvLibrerias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibrerias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(122)))));
            this.dgvLibrerias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrerias.Location = new System.Drawing.Point(3, 3);
            this.dgvLibrerias.Name = "dgvLibrerias";
            this.dgvLibrerias.Size = new System.Drawing.Size(566, 152);
            this.dgvLibrerias.TabIndex = 1;
            // 
            // lblNomLib
            // 
            this.lblNomLib.AutoSize = true;
            this.lblNomLib.BackColor = System.Drawing.Color.Transparent;
            this.lblNomLib.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomLib.ForeColor = System.Drawing.Color.White;
            this.lblNomLib.Location = new System.Drawing.Point(3, 161);
            this.lblNomLib.Name = "lblNomLib";
            this.lblNomLib.Size = new System.Drawing.Size(306, 19);
            this.lblNomLib.TabIndex = 2;
            this.lblNomLib.Text = "Librerías inscritas actualemnte en el sistema";
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.BackColor = System.Drawing.Color.Transparent;
            this.lblOpciones.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpciones.ForeColor = System.Drawing.Color.White;
            this.lblOpciones.Location = new System.Drawing.Point(642, 110);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(141, 19);
            this.lblOpciones.TabIndex = 3;
            this.lblOpciones.Text = "Opciones del gestor";
            // 
            // lblTituloIndex
            // 
            this.lblTituloIndex.AutoSize = true;
            this.lblTituloIndex.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloIndex.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIndex.ForeColor = System.Drawing.Color.White;
            this.lblTituloIndex.Location = new System.Drawing.Point(33, 94);
            this.lblTituloIndex.Name = "lblTituloIndex";
            this.lblTituloIndex.Size = new System.Drawing.Size(361, 22);
            this.lblTituloIndex.TabIndex = 0;
            this.lblTituloIndex.Text = "SISTEMA DE GESTIÓN DE LIBRERÍAS";
            // 
            // tabPagCrearLib
            // 
            this.tabPagCrearLib.BackgroundImage = global::appProjectLibreria.Properties.Resources.background1;
            this.tabPagCrearLib.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPagCrearLib.Controls.Add(this.pnlContenedorForLib);
            this.tabPagCrearLib.Controls.Add(this.lblForLib);
            this.tabPagCrearLib.Location = new System.Drawing.Point(4, 22);
            this.tabPagCrearLib.Name = "tabPagCrearLib";
            this.tabPagCrearLib.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagCrearLib.Size = new System.Drawing.Size(855, 386);
            this.tabPagCrearLib.TabIndex = 1;
            this.tabPagCrearLib.Text = "Crear librería";
            this.tabPagCrearLib.UseVisualStyleBackColor = true;
            // 
            // pnlContenedorForLib
            // 
            this.pnlContenedorForLib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(126)))), ((int)(((byte)(89)))));
            this.pnlContenedorForLib.Controls.Add(this.btnCancelar);
            this.pnlContenedorForLib.Controls.Add(this.btnCrearLib);
            this.pnlContenedorForLib.Controls.Add(this.txtLibDireccion);
            this.pnlContenedorForLib.Controls.Add(this.lblLIbDireccion);
            this.pnlContenedorForLib.Controls.Add(this.txtNombre);
            this.pnlContenedorForLib.Controls.Add(this.lblLibNombre);
            this.pnlContenedorForLib.Controls.Add(this.txtNit);
            this.pnlContenedorForLib.Controls.Add(this.lblLibNit);
            this.pnlContenedorForLib.Location = new System.Drawing.Point(151, 33);
            this.pnlContenedorForLib.Name = "pnlContenedorForLib";
            this.pnlContenedorForLib.Size = new System.Drawing.Size(539, 276);
            this.pnlContenedorForLib.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(445, 204);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrearLib
            // 
            this.btnCrearLib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(122)))));
            this.btnCrearLib.ForeColor = System.Drawing.Color.White;
            this.btnCrearLib.Location = new System.Drawing.Point(445, 175);
            this.btnCrearLib.Name = "btnCrearLib";
            this.btnCrearLib.Size = new System.Drawing.Size(75, 23);
            this.btnCrearLib.TabIndex = 6;
            this.btnCrearLib.Text = "Crear";
            this.btnCrearLib.UseVisualStyleBackColor = false;
            this.btnCrearLib.Click += new System.EventHandler(this.btnCrearLib_Click);
            // 
            // txtLibDireccion
            // 
            this.txtLibDireccion.Location = new System.Drawing.Point(25, 134);
            this.txtLibDireccion.Name = "txtLibDireccion";
            this.txtLibDireccion.Size = new System.Drawing.Size(495, 20);
            this.txtLibDireccion.TabIndex = 5;
            // 
            // lblLIbDireccion
            // 
            this.lblLIbDireccion.AutoSize = true;
            this.lblLIbDireccion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLIbDireccion.ForeColor = System.Drawing.Color.White;
            this.lblLIbDireccion.Location = new System.Drawing.Point(21, 112);
            this.lblLIbDireccion.Name = "lblLIbDireccion";
            this.lblLIbDireccion.Size = new System.Drawing.Size(82, 19);
            this.lblLIbDireccion.TabIndex = 4;
            this.lblLIbDireccion.Text = "Dirección: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(25, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(495, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblLibNombre
            // 
            this.lblLibNombre.AutoSize = true;
            this.lblLibNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibNombre.ForeColor = System.Drawing.Color.White;
            this.lblLibNombre.Location = new System.Drawing.Point(21, 63);
            this.lblLibNombre.Name = "lblLibNombre";
            this.lblLibNombre.Size = new System.Drawing.Size(68, 19);
            this.lblLibNombre.TabIndex = 2;
            this.lblLibNombre.Text = "Nombre:";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(25, 33);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(495, 20);
            this.txtNit.TabIndex = 1;
            // 
            // lblLibNit
            // 
            this.lblLibNit.AutoSize = true;
            this.lblLibNit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibNit.ForeColor = System.Drawing.Color.White;
            this.lblLibNit.Location = new System.Drawing.Point(21, 11);
            this.lblLibNit.Name = "lblLibNit";
            this.lblLibNit.Size = new System.Drawing.Size(35, 19);
            this.lblLibNit.TabIndex = 0;
            this.lblLibNit.Text = "Nit:";
            // 
            // lblForLib
            // 
            this.lblForLib.AutoSize = true;
            this.lblForLib.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForLib.ForeColor = System.Drawing.SystemColors.Info;
            this.lblForLib.Location = new System.Drawing.Point(302, 8);
            this.lblForLib.Name = "lblForLib";
            this.lblForLib.Size = new System.Drawing.Size(261, 22);
            this.lblForLib.TabIndex = 0;
            this.lblForLib.Text = "Formulario de registro librería";
            // 
            // tabPagCrearLbr
            // 
            this.tabPagCrearLbr.BackgroundImage = global::appProjectLibreria.Properties.Resources.background1;
            this.tabPagCrearLbr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPagCrearLbr.Controls.Add(this.label3);
            this.tabPagCrearLbr.Controls.Add(this.panel1);
            this.tabPagCrearLbr.Location = new System.Drawing.Point(4, 22);
            this.tabPagCrearLbr.Name = "tabPagCrearLbr";
            this.tabPagCrearLbr.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagCrearLbr.Size = new System.Drawing.Size(855, 386);
            this.tabPagCrearLbr.TabIndex = 2;
            this.tabPagCrearLbr.Text = "Crear libro";
            this.tabPagCrearLbr.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Formulario de registro librería";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(126)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.lblLbrPrecio);
            this.panel1.Controls.Add(this.dateImpLibro);
            this.panel1.Controls.Add(this.lblLbrFecha);
            this.panel1.Controls.Add(this.comboBoxLbrCat);
            this.panel1.Controls.Add(this.txtLbrNoPaginas);
            this.panel1.Controls.Add(this.lblLbrNoPaginas);
            this.panel1.Controls.Add(this.comboBoxLibrerias);
            this.panel1.Controls.Add(this.lblLibreriaSelec);
            this.panel1.Controls.Add(this.btnLbrCancelar);
            this.panel1.Controls.Add(this.btnLbrCrear);
            this.panel1.Controls.Add(this.txtLbrPrecio);
            this.panel1.Controls.Add(this.lblLbrCategoria);
            this.panel1.Controls.Add(this.txtLbrTitulo);
            this.panel1.Controls.Add(this.lblLbrTitulo);
            this.panel1.Controls.Add(this.txtlbrCodigo);
            this.panel1.Controls.Add(this.lblLbrCodigo);
            this.panel1.Location = new System.Drawing.Point(6, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 276);
            this.panel1.TabIndex = 2;
            // 
            // lblLbrPrecio
            // 
            this.lblLbrPrecio.AutoSize = true;
            this.lblLbrPrecio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLbrPrecio.ForeColor = System.Drawing.Color.White;
            this.lblLbrPrecio.Location = new System.Drawing.Point(21, 176);
            this.lblLbrPrecio.Name = "lblLbrPrecio";
            this.lblLbrPrecio.Size = new System.Drawing.Size(60, 19);
            this.lblLbrPrecio.TabIndex = 15;
            this.lblLbrPrecio.Text = "Precio: ";
            // 
            // dateImpLibro
            // 
            this.dateImpLibro.Location = new System.Drawing.Point(461, 139);
            this.dateImpLibro.Name = "dateImpLibro";
            this.dateImpLibro.Size = new System.Drawing.Size(347, 20);
            this.dateImpLibro.TabIndex = 14;
            // 
            // lblLbrFecha
            // 
            this.lblLbrFecha.AutoSize = true;
            this.lblLbrFecha.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLbrFecha.ForeColor = System.Drawing.Color.White;
            this.lblLbrFecha.Location = new System.Drawing.Point(457, 116);
            this.lblLbrFecha.Name = "lblLbrFecha";
            this.lblLbrFecha.Size = new System.Drawing.Size(127, 19);
            this.lblLbrFecha.TabIndex = 13;
            this.lblLbrFecha.Text = "Fecha impresión: ";
            // 
            // comboBoxLbrCat
            // 
            this.comboBoxLbrCat.FormattingEnabled = true;
            this.comboBoxLbrCat.Items.AddRange(new object[] {
            "Drama",
            "Suspenso",
            "Aventura"});
            this.comboBoxLbrCat.Location = new System.Drawing.Point(25, 138);
            this.comboBoxLbrCat.Name = "comboBoxLbrCat";
            this.comboBoxLbrCat.Size = new System.Drawing.Size(347, 21);
            this.comboBoxLbrCat.TabIndex = 12;
            // 
            // txtLbrNoPaginas
            // 
            this.txtLbrNoPaginas.Location = new System.Drawing.Point(461, 85);
            this.txtLbrNoPaginas.Name = "txtLbrNoPaginas";
            this.txtLbrNoPaginas.Size = new System.Drawing.Size(347, 20);
            this.txtLbrNoPaginas.TabIndex = 11;
            // 
            // lblLbrNoPaginas
            // 
            this.lblLbrNoPaginas.AutoSize = true;
            this.lblLbrNoPaginas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLbrNoPaginas.ForeColor = System.Drawing.Color.White;
            this.lblLbrNoPaginas.Location = new System.Drawing.Point(457, 63);
            this.lblLbrNoPaginas.Name = "lblLbrNoPaginas";
            this.lblLbrNoPaginas.Size = new System.Drawing.Size(143, 19);
            this.lblLbrNoPaginas.TabIndex = 10;
            this.lblLbrNoPaginas.Text = "Número de páginas:";
            // 
            // comboBoxLibrerias
            // 
            this.comboBoxLibrerias.FormattingEnabled = true;
            this.comboBoxLibrerias.Location = new System.Drawing.Point(461, 32);
            this.comboBoxLibrerias.Name = "comboBoxLibrerias";
            this.comboBoxLibrerias.Size = new System.Drawing.Size(347, 21);
            this.comboBoxLibrerias.TabIndex = 9;
            // 
            // lblLibreriaSelec
            // 
            this.lblLibreriaSelec.AutoSize = true;
            this.lblLibreriaSelec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibreriaSelec.ForeColor = System.Drawing.Color.White;
            this.lblLibreriaSelec.Location = new System.Drawing.Point(457, 11);
            this.lblLibreriaSelec.Name = "lblLibreriaSelec";
            this.lblLibreriaSelec.Size = new System.Drawing.Size(153, 19);
            this.lblLibreriaSelec.TabIndex = 8;
            this.lblLibreriaSelec.Text = "Seleccione la librería:";
            // 
            // btnLbrCancelar
            // 
            this.btnLbrCancelar.BackColor = System.Drawing.Color.Red;
            this.btnLbrCancelar.ForeColor = System.Drawing.Color.White;
            this.btnLbrCancelar.Location = new System.Drawing.Point(733, 227);
            this.btnLbrCancelar.Name = "btnLbrCancelar";
            this.btnLbrCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnLbrCancelar.TabIndex = 7;
            this.btnLbrCancelar.Text = "Cancelar";
            this.btnLbrCancelar.UseVisualStyleBackColor = false;
            this.btnLbrCancelar.Click += new System.EventHandler(this.btnLbrCancelar_Click);
            // 
            // btnLbrCrear
            // 
            this.btnLbrCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(122)))));
            this.btnLbrCrear.ForeColor = System.Drawing.Color.White;
            this.btnLbrCrear.Location = new System.Drawing.Point(733, 198);
            this.btnLbrCrear.Name = "btnLbrCrear";
            this.btnLbrCrear.Size = new System.Drawing.Size(75, 23);
            this.btnLbrCrear.TabIndex = 6;
            this.btnLbrCrear.Text = "Crear";
            this.btnLbrCrear.UseVisualStyleBackColor = false;
            this.btnLbrCrear.Click += new System.EventHandler(this.btnLbrCrear_Click);
            // 
            // txtLbrPrecio
            // 
            this.txtLbrPrecio.Location = new System.Drawing.Point(25, 198);
            this.txtLbrPrecio.Name = "txtLbrPrecio";
            this.txtLbrPrecio.Size = new System.Drawing.Size(347, 20);
            this.txtLbrPrecio.TabIndex = 5;
            // 
            // lblLbrCategoria
            // 
            this.lblLbrCategoria.AutoSize = true;
            this.lblLbrCategoria.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLbrCategoria.ForeColor = System.Drawing.Color.White;
            this.lblLbrCategoria.Location = new System.Drawing.Point(21, 116);
            this.lblLbrCategoria.Name = "lblLbrCategoria";
            this.lblLbrCategoria.Size = new System.Drawing.Size(84, 19);
            this.lblLbrCategoria.TabIndex = 4;
            this.lblLbrCategoria.Text = "Categoría: ";
            // 
            // txtLbrTitulo
            // 
            this.txtLbrTitulo.Location = new System.Drawing.Point(25, 85);
            this.txtLbrTitulo.Name = "txtLbrTitulo";
            this.txtLbrTitulo.Size = new System.Drawing.Size(347, 20);
            this.txtLbrTitulo.TabIndex = 3;
            // 
            // lblLbrTitulo
            // 
            this.lblLbrTitulo.AutoSize = true;
            this.lblLbrTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLbrTitulo.ForeColor = System.Drawing.Color.White;
            this.lblLbrTitulo.Location = new System.Drawing.Point(21, 63);
            this.lblLbrTitulo.Name = "lblLbrTitulo";
            this.lblLbrTitulo.Size = new System.Drawing.Size(53, 19);
            this.lblLbrTitulo.TabIndex = 2;
            this.lblLbrTitulo.Text = "Título:";
            // 
            // txtlbrCodigo
            // 
            this.txtlbrCodigo.Location = new System.Drawing.Point(25, 33);
            this.txtlbrCodigo.Name = "txtlbrCodigo";
            this.txtlbrCodigo.Size = new System.Drawing.Size(347, 20);
            this.txtlbrCodigo.TabIndex = 1;
            // 
            // lblLbrCodigo
            // 
            this.lblLbrCodigo.AutoSize = true;
            this.lblLbrCodigo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLbrCodigo.ForeColor = System.Drawing.Color.White;
            this.lblLbrCodigo.Location = new System.Drawing.Point(21, 11);
            this.lblLbrCodigo.Name = "lblLbrCodigo";
            this.lblLbrCodigo.Size = new System.Drawing.Size(61, 19);
            this.lblLbrCodigo.TabIndex = 0;
            this.lblLbrCodigo.Text = "Código:";
            // 
            // tabPagConsultarLbr
            // 
            this.tabPagConsultarLbr.BackgroundImage = global::appProjectLibreria.Properties.Resources.background1;
            this.tabPagConsultarLbr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPagConsultarLbr.Controls.Add(this.pnlDatosConsulta);
            this.tabPagConsultarLbr.Controls.Add(this.lblDatosConsulta);
            this.tabPagConsultarLbr.Controls.Add(this.lblConsulta);
            this.tabPagConsultarLbr.Controls.Add(this.pnlResultConsulta);
            this.tabPagConsultarLbr.Location = new System.Drawing.Point(4, 22);
            this.tabPagConsultarLbr.Name = "tabPagConsultarLbr";
            this.tabPagConsultarLbr.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagConsultarLbr.Size = new System.Drawing.Size(855, 386);
            this.tabPagConsultarLbr.TabIndex = 3;
            this.tabPagConsultarLbr.Text = "Consultar libros";
            this.tabPagConsultarLbr.UseVisualStyleBackColor = true;
            // 
            // pnlDatosConsulta
            // 
            this.pnlDatosConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(126)))), ((int)(((byte)(89)))));
            this.pnlDatosConsulta.Controls.Add(this.btnConsultarLibro);
            this.pnlDatosConsulta.Controls.Add(this.comboBoxCatLibroConsult);
            this.pnlDatosConsulta.Controls.Add(this.lblLbrCat);
            this.pnlDatosConsulta.Controls.Add(this.comboBoxLibreriaConsult);
            this.pnlDatosConsulta.Controls.Add(this.lblSelectLibreriaConsult);
            this.pnlDatosConsulta.Location = new System.Drawing.Point(646, 130);
            this.pnlDatosConsulta.Name = "pnlDatosConsulta";
            this.pnlDatosConsulta.Size = new System.Drawing.Size(186, 250);
            this.pnlDatosConsulta.TabIndex = 6;
            // 
            // btnConsultarLibro
            // 
            this.btnConsultarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(122)))));
            this.btnConsultarLibro.ForeColor = System.Drawing.Color.White;
            this.btnConsultarLibro.Location = new System.Drawing.Point(53, 146);
            this.btnConsultarLibro.Name = "btnConsultarLibro";
            this.btnConsultarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarLibro.TabIndex = 4;
            this.btnConsultarLibro.Text = "Consultar";
            this.btnConsultarLibro.UseVisualStyleBackColor = false;
            this.btnConsultarLibro.Click += new System.EventHandler(this.btnConsultarLibro_Click);
            // 
            // comboBoxCatLibroConsult
            // 
            this.comboBoxCatLibroConsult.FormattingEnabled = true;
            this.comboBoxCatLibroConsult.Items.AddRange(new object[] {
            "Drama",
            "Suspenso",
            "Aventura"});
            this.comboBoxCatLibroConsult.Location = new System.Drawing.Point(7, 98);
            this.comboBoxCatLibroConsult.Name = "comboBoxCatLibroConsult";
            this.comboBoxCatLibroConsult.Size = new System.Drawing.Size(176, 21);
            this.comboBoxCatLibroConsult.TabIndex = 3;
            // 
            // lblLbrCat
            // 
            this.lblLbrCat.AutoSize = true;
            this.lblLbrCat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLbrCat.ForeColor = System.Drawing.Color.White;
            this.lblLbrCat.Location = new System.Drawing.Point(3, 57);
            this.lblLbrCat.Name = "lblLbrCat";
            this.lblLbrCat.Size = new System.Drawing.Size(162, 38);
            this.lblLbrCat.TabIndex = 2;
            this.lblLbrCat.Text = "Seleccione la categoría\r\ndel libro:";
            // 
            // comboBoxLibreriaConsult
            // 
            this.comboBoxLibreriaConsult.FormattingEnabled = true;
            this.comboBoxLibreriaConsult.Location = new System.Drawing.Point(7, 33);
            this.comboBoxLibreriaConsult.Name = "comboBoxLibreriaConsult";
            this.comboBoxLibreriaConsult.Size = new System.Drawing.Size(176, 21);
            this.comboBoxLibreriaConsult.TabIndex = 1;
            // 
            // lblSelectLibreriaConsult
            // 
            this.lblSelectLibreriaConsult.AutoSize = true;
            this.lblSelectLibreriaConsult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectLibreriaConsult.ForeColor = System.Drawing.Color.White;
            this.lblSelectLibreriaConsult.Location = new System.Drawing.Point(3, 11);
            this.lblSelectLibreriaConsult.Name = "lblSelectLibreriaConsult";
            this.lblSelectLibreriaConsult.Size = new System.Drawing.Size(145, 19);
            this.lblSelectLibreriaConsult.TabIndex = 0;
            this.lblSelectLibreriaConsult.Text = "Selccione la librería:";
            // 
            // lblDatosConsulta
            // 
            this.lblDatosConsulta.AutoSize = true;
            this.lblDatosConsulta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosConsulta.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDatosConsulta.Location = new System.Drawing.Point(642, 105);
            this.lblDatosConsulta.Name = "lblDatosConsulta";
            this.lblDatosConsulta.Size = new System.Drawing.Size(63, 22);
            this.lblDatosConsulta.TabIndex = 5;
            this.lblDatosConsulta.Text = "Datos:";
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.ForeColor = System.Drawing.SystemColors.Info;
            this.lblConsulta.Location = new System.Drawing.Point(27, 94);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(97, 22);
            this.lblConsulta.TabIndex = 4;
            this.lblConsulta.Text = "Resultado:";
            // 
            // pnlResultConsulta
            // 
            this.pnlResultConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(126)))), ((int)(((byte)(89)))));
            this.pnlResultConsulta.Controls.Add(this.dgvResultConsulta);
            this.pnlResultConsulta.Location = new System.Drawing.Point(46, 128);
            this.pnlResultConsulta.Name = "pnlResultConsulta";
            this.pnlResultConsulta.Size = new System.Drawing.Size(575, 197);
            this.pnlResultConsulta.TabIndex = 0;
            // 
            // dgvResultConsulta
            // 
            this.dgvResultConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(122)))));
            this.dgvResultConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultConsulta.Location = new System.Drawing.Point(14, 13);
            this.dgvResultConsulta.Name = "dgvResultConsulta";
            this.dgvResultConsulta.Size = new System.Drawing.Size(546, 150);
            this.dgvResultConsulta.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 513);
            this.Controls.Add(this.pnlContenedor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlContenedor.ResumeLayout(false);
            this.tabContLib.ResumeLayout(false);
            this.tabPagIndex.ResumeLayout(false);
            this.tabPagIndex.PerformLayout();
            this.pnlOpcionesLibreria.ResumeLayout(false);
            this.pnlOpcionesLibreria.PerformLayout();
            this.pnlContenedorLibrerias.ResumeLayout(false);
            this.pnlContenedorLibrerias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrerias)).EndInit();
            this.tabPagCrearLib.ResumeLayout(false);
            this.tabPagCrearLib.PerformLayout();
            this.pnlContenedorForLib.ResumeLayout(false);
            this.pnlContenedorForLib.PerformLayout();
            this.tabPagCrearLbr.ResumeLayout(false);
            this.tabPagCrearLbr.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPagConsultarLbr.ResumeLayout(false);
            this.tabPagConsultarLbr.PerformLayout();
            this.pnlDatosConsulta.ResumeLayout(false);
            this.pnlDatosConsulta.PerformLayout();
            this.pnlResultConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.TabControl tabContLib;
        private System.Windows.Forms.TabPage tabPagIndex;
        private System.Windows.Forms.TabPage tabPagCrearLib;
        private System.Windows.Forms.Button btnOpConsLbr;
        private System.Windows.Forms.Button btnOpCrearLbr;
        private System.Windows.Forms.Button btnOpCrearLib;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.Label lblNomLib;
        private System.Windows.Forms.DataGridView dgvLibrerias;
        private System.Windows.Forms.Label lblTituloIndex;
        private System.Windows.Forms.TabPage tabPagCrearLbr;
        private System.Windows.Forms.TabPage tabPagConsultarLbr;
        private System.Windows.Forms.Panel pnlContenedorForLib;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrearLib;
        private System.Windows.Forms.TextBox txtLibDireccion;
        private System.Windows.Forms.Label lblLIbDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblLibNombre;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label lblLibNit;
        private System.Windows.Forms.Label lblForLib;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLbrPrecio;
        private System.Windows.Forms.DateTimePicker dateImpLibro;
        private System.Windows.Forms.Label lblLbrFecha;
        private System.Windows.Forms.ComboBox comboBoxLbrCat;
        private System.Windows.Forms.TextBox txtLbrNoPaginas;
        private System.Windows.Forms.Label lblLbrNoPaginas;
        private System.Windows.Forms.ComboBox comboBoxLibrerias;
        private System.Windows.Forms.Label lblLibreriaSelec;
        private System.Windows.Forms.Button btnLbrCancelar;
        private System.Windows.Forms.Button btnLbrCrear;
        private System.Windows.Forms.TextBox txtLbrPrecio;
        private System.Windows.Forms.Label lblLbrCategoria;
        private System.Windows.Forms.TextBox txtLbrTitulo;
        private System.Windows.Forms.Label lblLbrTitulo;
        private System.Windows.Forms.TextBox txtlbrCodigo;
        private System.Windows.Forms.Label lblLbrCodigo;
        private System.Windows.Forms.Panel pnlDatosConsulta;
        private System.Windows.Forms.Label lblLbrCat;
        private System.Windows.Forms.ComboBox comboBoxLibreriaConsult;
        private System.Windows.Forms.Label lblSelectLibreriaConsult;
        private System.Windows.Forms.Label lblDatosConsulta;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Panel pnlResultConsulta;
        private System.Windows.Forms.Panel pnlOpcionesLibreria;
        private System.Windows.Forms.Label lblMejorOpcion;
        private System.Windows.Forms.Panel pnlContenedorLibrerias;
        private System.Windows.Forms.Button btnConsultarLibro;
        private System.Windows.Forms.ComboBox comboBoxCatLibroConsult;
        private System.Windows.Forms.DataGridView dgvResultConsulta;
    }
}

