namespace BibliotecaJM
{
    partial class FM_Prestamos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_lecLabel;
            System.Windows.Forms.Label nombre_lecLabel;
            System.Windows.Forms.Label domicilio_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            this.gbBuscarLibro = new System.Windows.Forms.GroupBox();
            this.bPrestar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbAutorLibro = new System.Windows.Forms.TextBox();
            this.lAutorLibro = new System.Windows.Forms.Label();
            this.bBuscarIdLibro = new System.Windows.Forms.Button();
            this.bBuscarTituloLibro = new System.Windows.Forms.Button();
            this.tbBuscarTituloLibro = new System.Windows.Forms.TextBox();
            this.tbBuscarIdLibro = new System.Windows.Forms.TextBox();
            this.lTituloLibro = new System.Windows.Forms.Label();
            this.lIdLibro = new System.Windows.Forms.Label();
            this.gbBuscarLector = new System.Windows.Forms.GroupBox();
            this.librosPrestadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosPrestadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaLibrosPrestados = new BibliotecaJM.VistaLibrosPrestados();
            this.lNombre = new System.Windows.Forms.Label();
            this.lid = new System.Windows.Forms.Label();
            this.bBuscarNombre = new System.Windows.Forms.Button();
            this.bBuscarId = new System.Windows.Forms.Button();
            this.tbBuscarNombre = new System.Windows.Forms.TextBox();
            this.tbBuscarId = new System.Windows.Forms.TextBox();
            this.librosPrestadosTableAdapter = new BibliotecaJM.VistaLibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter();
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager();
            this.id_lecTextBox = new System.Windows.Forms.TextBox();
            this.nombre_lecTextBox = new System.Windows.Forms.TextBox();
            this.domicilio_lecTextBox = new System.Windows.Forms.TextBox();
            this.fecha_penalizacion_lecDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.tableAdapterManager1 = new BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            this.gbBuscarLibro.SuspendLayout();
            this.gbBuscarLector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaLibrosPrestados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuscarLibro
            // 
            this.gbBuscarLibro.Controls.Add(this.librosDataGridView);
            this.gbBuscarLibro.Controls.Add(this.bPrestar);
            this.gbBuscarLibro.Controls.Add(this.button1);
            this.gbBuscarLibro.Controls.Add(this.tbAutorLibro);
            this.gbBuscarLibro.Controls.Add(this.lAutorLibro);
            this.gbBuscarLibro.Controls.Add(this.bBuscarIdLibro);
            this.gbBuscarLibro.Controls.Add(this.bBuscarTituloLibro);
            this.gbBuscarLibro.Controls.Add(this.tbBuscarTituloLibro);
            this.gbBuscarLibro.Controls.Add(this.tbBuscarIdLibro);
            this.gbBuscarLibro.Controls.Add(this.lTituloLibro);
            this.gbBuscarLibro.Controls.Add(this.lIdLibro);
            this.gbBuscarLibro.Location = new System.Drawing.Point(523, 22);
            this.gbBuscarLibro.Name = "gbBuscarLibro";
            this.gbBuscarLibro.Size = new System.Drawing.Size(435, 569);
            this.gbBuscarLibro.TabIndex = 6;
            this.gbBuscarLibro.TabStop = false;
            this.gbBuscarLibro.Text = "BuscarLibro";
            // 
            // bPrestar
            // 
            this.bPrestar.Location = new System.Drawing.Point(15, 509);
            this.bPrestar.Name = "bPrestar";
            this.bPrestar.Size = new System.Drawing.Size(314, 23);
            this.bPrestar.TabIndex = 7;
            this.bPrestar.Text = "REALIZAR PRESTAMO";
            this.bPrestar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbAutorLibro
            // 
            this.tbAutorLibro.Location = new System.Drawing.Point(83, 114);
            this.tbAutorLibro.Name = "tbAutorLibro";
            this.tbAutorLibro.Size = new System.Drawing.Size(152, 20);
            this.tbAutorLibro.TabIndex = 5;
            // 
            // lAutorLibro
            // 
            this.lAutorLibro.AutoSize = true;
            this.lAutorLibro.Location = new System.Drawing.Point(12, 114);
            this.lAutorLibro.Name = "lAutorLibro";
            this.lAutorLibro.Size = new System.Drawing.Size(32, 13);
            this.lAutorLibro.TabIndex = 4;
            this.lAutorLibro.Text = "Autor";
            // 
            // bBuscarIdLibro
            // 
            this.bBuscarIdLibro.Location = new System.Drawing.Point(241, 30);
            this.bBuscarIdLibro.Name = "bBuscarIdLibro";
            this.bBuscarIdLibro.Size = new System.Drawing.Size(75, 23);
            this.bBuscarIdLibro.TabIndex = 3;
            this.bBuscarIdLibro.Text = "Buscar";
            this.bBuscarIdLibro.UseVisualStyleBackColor = true;
            // 
            // bBuscarTituloLibro
            // 
            this.bBuscarTituloLibro.Location = new System.Drawing.Point(241, 78);
            this.bBuscarTituloLibro.Name = "bBuscarTituloLibro";
            this.bBuscarTituloLibro.Size = new System.Drawing.Size(75, 23);
            this.bBuscarTituloLibro.TabIndex = 3;
            this.bBuscarTituloLibro.Text = "Buscar";
            this.bBuscarTituloLibro.UseVisualStyleBackColor = true;
            // 
            // tbBuscarTituloLibro
            // 
            this.tbBuscarTituloLibro.Location = new System.Drawing.Point(83, 78);
            this.tbBuscarTituloLibro.Name = "tbBuscarTituloLibro";
            this.tbBuscarTituloLibro.Size = new System.Drawing.Size(152, 20);
            this.tbBuscarTituloLibro.TabIndex = 2;
            // 
            // tbBuscarIdLibro
            // 
            this.tbBuscarIdLibro.Location = new System.Drawing.Point(83, 33);
            this.tbBuscarIdLibro.Name = "tbBuscarIdLibro";
            this.tbBuscarIdLibro.Size = new System.Drawing.Size(152, 20);
            this.tbBuscarIdLibro.TabIndex = 2;
            // 
            // lTituloLibro
            // 
            this.lTituloLibro.AutoSize = true;
            this.lTituloLibro.Location = new System.Drawing.Point(12, 78);
            this.lTituloLibro.Name = "lTituloLibro";
            this.lTituloLibro.Size = new System.Drawing.Size(33, 13);
            this.lTituloLibro.TabIndex = 1;
            this.lTituloLibro.Text = "Titulo";
            // 
            // lIdLibro
            // 
            this.lIdLibro.AutoSize = true;
            this.lIdLibro.Location = new System.Drawing.Point(12, 33);
            this.lIdLibro.Name = "lIdLibro";
            this.lIdLibro.Size = new System.Drawing.Size(65, 13);
            this.lIdLibro.TabIndex = 1;
            this.lIdLibro.Text = "Identificador";
            // 
            // gbBuscarLector
            // 
            this.gbBuscarLector.Controls.Add(id_lecLabel);
            this.gbBuscarLector.Controls.Add(this.id_lecTextBox);
            this.gbBuscarLector.Controls.Add(nombre_lecLabel);
            this.gbBuscarLector.Controls.Add(this.nombre_lecTextBox);
            this.gbBuscarLector.Controls.Add(domicilio_lecLabel);
            this.gbBuscarLector.Controls.Add(this.domicilio_lecTextBox);
            this.gbBuscarLector.Controls.Add(fecha_penalizacion_lecLabel);
            this.gbBuscarLector.Controls.Add(this.fecha_penalizacion_lecDateTimePicker);
            this.gbBuscarLector.Controls.Add(this.librosPrestadosDataGridView);
            this.gbBuscarLector.Controls.Add(this.lNombre);
            this.gbBuscarLector.Controls.Add(this.lid);
            this.gbBuscarLector.Controls.Add(this.bBuscarNombre);
            this.gbBuscarLector.Controls.Add(this.bBuscarId);
            this.gbBuscarLector.Controls.Add(this.tbBuscarNombre);
            this.gbBuscarLector.Controls.Add(this.tbBuscarId);
            this.gbBuscarLector.Location = new System.Drawing.Point(21, 22);
            this.gbBuscarLector.Name = "gbBuscarLector";
            this.gbBuscarLector.Size = new System.Drawing.Size(682, 569);
            this.gbBuscarLector.TabIndex = 5;
            this.gbBuscarLector.TabStop = false;
            this.gbBuscarLector.Text = "BuscarLector";
            // 
            // librosPrestadosDataGridView
            // 
            this.librosPrestadosDataGridView.AllowUserToAddRows = false;
            this.librosPrestadosDataGridView.AllowUserToDeleteRows = false;
            this.librosPrestadosDataGridView.AutoGenerateColumns = false;
            this.librosPrestadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosPrestadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.librosPrestadosDataGridView.DataSource = this.librosPrestadosBindingSource;
            this.librosPrestadosDataGridView.Location = new System.Drawing.Point(16, 234);
            this.librosPrestadosDataGridView.Name = "librosPrestadosDataGridView";
            this.librosPrestadosDataGridView.ReadOnly = true;
            this.librosPrestadosDataGridView.Size = new System.Drawing.Size(444, 307);
            this.librosPrestadosDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_lib";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn2.HeaderText = "titulo_lib";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fecha_presta_pre";
            this.dataGridViewTextBoxColumn3.HeaderText = "fecha_presta_pre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn4.HeaderText = "fecha_devol_pre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // librosPrestadosBindingSource
            // 
            this.librosPrestadosBindingSource.DataMember = "LibrosPrestados";
            this.librosPrestadosBindingSource.DataSource = this.vistaLibrosPrestados;
            // 
            // vistaLibrosPrestados
            // 
            this.vistaLibrosPrestados.DataSetName = "VistaLibrosPrestados";
            this.vistaLibrosPrestados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(13, 55);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 4;
            this.lNombre.Text = "Nombre";
            // 
            // lid
            // 
            this.lid.AutoSize = true;
            this.lid.Location = new System.Drawing.Point(13, 20);
            this.lid.Name = "lid";
            this.lid.Size = new System.Drawing.Size(18, 13);
            this.lid.TabIndex = 4;
            this.lid.Text = "ID";
            // 
            // bBuscarNombre
            // 
            this.bBuscarNombre.Location = new System.Drawing.Point(209, 55);
            this.bBuscarNombre.Name = "bBuscarNombre";
            this.bBuscarNombre.Size = new System.Drawing.Size(75, 23);
            this.bBuscarNombre.TabIndex = 3;
            this.bBuscarNombre.Text = "Buscar";
            this.bBuscarNombre.UseVisualStyleBackColor = true;
            // 
            // bBuscarId
            // 
            this.bBuscarId.Location = new System.Drawing.Point(209, 15);
            this.bBuscarId.Name = "bBuscarId";
            this.bBuscarId.Size = new System.Drawing.Size(75, 23);
            this.bBuscarId.TabIndex = 3;
            this.bBuscarId.Text = "Buscar";
            this.bBuscarId.UseVisualStyleBackColor = true;
            // 
            // tbBuscarNombre
            // 
            this.tbBuscarNombre.Location = new System.Drawing.Point(59, 55);
            this.tbBuscarNombre.Name = "tbBuscarNombre";
            this.tbBuscarNombre.Size = new System.Drawing.Size(135, 20);
            this.tbBuscarNombre.TabIndex = 2;
            // 
            // tbBuscarId
            // 
            this.tbBuscarId.Location = new System.Drawing.Point(58, 17);
            this.tbBuscarId.Name = "tbBuscarId";
            this.tbBuscarId.Size = new System.Drawing.Size(136, 20);
            this.tbBuscarId.TabIndex = 1;
            // 
            // librosPrestadosTableAdapter
            // 
            this.librosPrestadosTableAdapter.ClearBeforeFill = true;
            // 
            // dS_Lectores
            // 
            this.dS_Lectores.DataSetName = "DS_Lectores";
            this.dS_Lectores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.dS_Lectores;
            // 
            // lectoresTableAdapter
            // 
            this.lectoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lectoresTableAdapter = this.lectoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(56, 97);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(35, 13);
            id_lecLabel.TabIndex = 16;
            id_lecLabel.Text = "id lec:";
            // 
            // id_lecTextBox
            // 
            this.id_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecTextBox.Location = new System.Drawing.Point(178, 94);
            this.id_lecTextBox.Name = "id_lecTextBox";
            this.id_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_lecTextBox.TabIndex = 17;
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(56, 123);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(62, 13);
            nombre_lecLabel.TabIndex = 18;
            nombre_lecLabel.Text = "nombre lec:";
            // 
            // nombre_lecTextBox
            // 
            this.nombre_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecTextBox.Location = new System.Drawing.Point(178, 120);
            this.nombre_lecTextBox.Name = "nombre_lecTextBox";
            this.nombre_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombre_lecTextBox.TabIndex = 19;
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(56, 149);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(67, 13);
            domicilio_lecLabel.TabIndex = 20;
            domicilio_lecLabel.Text = "domicilio lec:";
            // 
            // domicilio_lecTextBox
            // 
            this.domicilio_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecTextBox.Location = new System.Drawing.Point(178, 146);
            this.domicilio_lecTextBox.Name = "domicilio_lecTextBox";
            this.domicilio_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.domicilio_lecTextBox.TabIndex = 21;
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(55, 180);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(116, 13);
            fecha_penalizacion_lecLabel.TabIndex = 28;
            fecha_penalizacion_lecLabel.Text = "fecha penalizacion lec:";
            // 
            // fecha_penalizacion_lecDateTimePicker
            // 
            this.fecha_penalizacion_lecDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lectoresBindingSource, "fecha_penalizacion_lec", true));
            this.fecha_penalizacion_lecDateTimePicker.Location = new System.Drawing.Point(178, 180);
            this.fecha_penalizacion_lecDateTimePicker.Name = "fecha_penalizacion_lecDateTimePicker";
            this.fecha_penalizacion_lecDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_penalizacion_lecDateTimePicker.TabIndex = 29;
            // 
            // dS_Libros
            // 
            this.dS_Libros.DataSetName = "DS_Libros";
            this.dS_Libros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.dS_Libros;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.librosTableAdapter = this.librosTableAdapter;
            this.tableAdapterManager1.UpdateOrder = BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AllowUserToAddRows = false;
            this.librosDataGridView.AllowUserToDeleteRows = false;
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(15, 167);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.ReadOnly = true;
            this.librosDataGridView.Size = new System.Drawing.Size(414, 336);
            this.librosDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_lib";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn6.HeaderText = "titulo_lib";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "autor_lib";
            this.dataGridViewTextBoxColumn7.HeaderText = "autor_lib";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "seccion_lib";
            this.dataGridViewTextBoxColumn8.HeaderText = "seccion_lib";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn9.HeaderText = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // FM_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(958, 636);
            this.Controls.Add(this.gbBuscarLibro);
            this.Controls.Add(this.gbBuscarLector);
            this.Name = "FM_Prestamos";
            this.Load += new System.EventHandler(this.FM_Prestamos_Load);
            this.gbBuscarLibro.ResumeLayout(false);
            this.gbBuscarLibro.PerformLayout();
            this.gbBuscarLector.ResumeLayout(false);
            this.gbBuscarLector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosPrestadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaLibrosPrestados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscarLibro;
        private System.Windows.Forms.Button bPrestar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbAutorLibro;
        private System.Windows.Forms.Label lAutorLibro;
        private System.Windows.Forms.Button bBuscarIdLibro;
        private System.Windows.Forms.Button bBuscarTituloLibro;
        private System.Windows.Forms.TextBox tbBuscarTituloLibro;
        private System.Windows.Forms.TextBox tbBuscarIdLibro;
        private System.Windows.Forms.Label lTituloLibro;
        private System.Windows.Forms.Label lIdLibro;
        private System.Windows.Forms.GroupBox gbBuscarLector;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lid;
        private System.Windows.Forms.Button bBuscarNombre;
        private System.Windows.Forms.Button bBuscarId;
        private System.Windows.Forms.TextBox tbBuscarNombre;
        private System.Windows.Forms.TextBox tbBuscarId;
        private VistaLibrosPrestados vistaLibrosPrestados;
        private System.Windows.Forms.BindingSource librosPrestadosBindingSource;
        private VistaLibrosPrestadosTableAdapters.LibrosPrestadosTableAdapter librosPrestadosTableAdapter;
        private System.Windows.Forms.DataGridView librosPrestadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private DS_LectoresTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_lecTextBox;
        private System.Windows.Forms.TextBox nombre_lecTextBox;
        private System.Windows.Forms.TextBox domicilio_lecTextBox;
        private System.Windows.Forms.DateTimePicker fecha_penalizacion_lecDateTimePicker;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private DS_LibrosTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}
