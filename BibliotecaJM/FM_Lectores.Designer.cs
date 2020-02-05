namespace BibliotecaJM
{
    partial class FM_Lectores
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
            System.Windows.Forms.Label provincia_lecLabel;
            System.Windows.Forms.Label email_lecLabel;
            System.Windows.Forms.Label fecha_nacimiento_lecLabel;
            System.Windows.Forms.Label fecha_penalizacion_lecLabel;
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.bProvincias = new System.Windows.Forms.Button();
            this.id_lecTextBox = new System.Windows.Forms.TextBox();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Lectores = new BibliotecaJM.DS_Lectores();
            this.nombre_lecTextBox = new System.Windows.Forms.TextBox();
            this.domicilio_lecTextBox = new System.Windows.Forms.TextBox();
            this.provincia_lecTextBox = new System.Windows.Forms.TextBox();
            this.email_lecTextBox = new System.Windows.Forms.TextBox();
            this.fecha_nacimiento_lecDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_penalizacion_lecDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bAceptarLector = new System.Windows.Forms.Button();
            this.bCancelarLector = new System.Windows.Forms.Button();
            this.gbBuscarLector = new System.Windows.Forms.GroupBox();
            this.lectoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEliminarLector = new System.Windows.Forms.Button();
            this.bModificarLector = new System.Windows.Forms.Button();
            this.bNuevoLector = new System.Windows.Forms.Button();
            this.lNombre = new System.Windows.Forms.Label();
            this.lid = new System.Windows.Forms.Label();
            this.bBuscarNombreLector = new System.Windows.Forms.Button();
            this.bBuscarIdLector = new System.Windows.Forms.Button();
            this.tbBuscarNombre = new System.Windows.Forms.TextBox();
            this.tbBuscarId = new System.Windows.Forms.TextBox();
            this.lectoresTableAdapter = new BibliotecaJM.DS_LectoresTableAdapters.lectoresTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_LectoresTableAdapters.TableAdapterManager();
            this.tbNombreProvincia = new System.Windows.Forms.TextBox();
            id_lecLabel = new System.Windows.Forms.Label();
            nombre_lecLabel = new System.Windows.Forms.Label();
            domicilio_lecLabel = new System.Windows.Forms.Label();
            provincia_lecLabel = new System.Windows.Forms.Label();
            email_lecLabel = new System.Windows.Forms.Label();
            fecha_nacimiento_lecLabel = new System.Windows.Forms.Label();
            fecha_penalizacion_lecLabel = new System.Windows.Forms.Label();
            this.gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).BeginInit();
            this.gbBuscarLector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lecLabel
            // 
            id_lecLabel.AutoSize = true;
            id_lecLabel.Location = new System.Drawing.Point(26, 25);
            id_lecLabel.Name = "id_lecLabel";
            id_lecLabel.Size = new System.Drawing.Size(35, 13);
            id_lecLabel.TabIndex = 8;
            id_lecLabel.Text = "id lec:";
            // 
            // nombre_lecLabel
            // 
            nombre_lecLabel.AutoSize = true;
            nombre_lecLabel.Location = new System.Drawing.Point(26, 51);
            nombre_lecLabel.Name = "nombre_lecLabel";
            nombre_lecLabel.Size = new System.Drawing.Size(62, 13);
            nombre_lecLabel.TabIndex = 10;
            nombre_lecLabel.Text = "nombre lec:";
            // 
            // domicilio_lecLabel
            // 
            domicilio_lecLabel.AutoSize = true;
            domicilio_lecLabel.Location = new System.Drawing.Point(26, 77);
            domicilio_lecLabel.Name = "domicilio_lecLabel";
            domicilio_lecLabel.Size = new System.Drawing.Size(67, 13);
            domicilio_lecLabel.TabIndex = 12;
            domicilio_lecLabel.Text = "domicilio lec:";
            // 
            // provincia_lecLabel
            // 
            provincia_lecLabel.AutoSize = true;
            provincia_lecLabel.Location = new System.Drawing.Point(26, 103);
            provincia_lecLabel.Name = "provincia_lecLabel";
            provincia_lecLabel.Size = new System.Drawing.Size(70, 13);
            provincia_lecLabel.TabIndex = 14;
            provincia_lecLabel.Text = "provincia lec:";
            // 
            // email_lecLabel
            // 
            email_lecLabel.AutoSize = true;
            email_lecLabel.Location = new System.Drawing.Point(26, 129);
            email_lecLabel.Name = "email_lecLabel";
            email_lecLabel.Size = new System.Drawing.Size(51, 13);
            email_lecLabel.TabIndex = 16;
            email_lecLabel.Text = "email lec:";
            // 
            // fecha_nacimiento_lecLabel
            // 
            fecha_nacimiento_lecLabel.AutoSize = true;
            fecha_nacimiento_lecLabel.Location = new System.Drawing.Point(26, 156);
            fecha_nacimiento_lecLabel.Name = "fecha_nacimiento_lecLabel";
            fecha_nacimiento_lecLabel.Size = new System.Drawing.Size(108, 13);
            fecha_nacimiento_lecLabel.TabIndex = 18;
            fecha_nacimiento_lecLabel.Text = "fecha nacimiento lec:";
            // 
            // fecha_penalizacion_lecLabel
            // 
            fecha_penalizacion_lecLabel.AutoSize = true;
            fecha_penalizacion_lecLabel.Location = new System.Drawing.Point(26, 182);
            fecha_penalizacion_lecLabel.Name = "fecha_penalizacion_lecLabel";
            fecha_penalizacion_lecLabel.Size = new System.Drawing.Size(116, 13);
            fecha_penalizacion_lecLabel.TabIndex = 20;
            fecha_penalizacion_lecLabel.Text = "fecha penalizacion lec:";
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.tbNombreProvincia);
            this.gbDetalle.Controls.Add(this.bProvincias);
            this.gbDetalle.Controls.Add(id_lecLabel);
            this.gbDetalle.Controls.Add(this.id_lecTextBox);
            this.gbDetalle.Controls.Add(nombre_lecLabel);
            this.gbDetalle.Controls.Add(this.nombre_lecTextBox);
            this.gbDetalle.Controls.Add(domicilio_lecLabel);
            this.gbDetalle.Controls.Add(this.domicilio_lecTextBox);
            this.gbDetalle.Controls.Add(provincia_lecLabel);
            this.gbDetalle.Controls.Add(this.provincia_lecTextBox);
            this.gbDetalle.Controls.Add(email_lecLabel);
            this.gbDetalle.Controls.Add(this.email_lecTextBox);
            this.gbDetalle.Controls.Add(fecha_nacimiento_lecLabel);
            this.gbDetalle.Controls.Add(this.fecha_nacimiento_lecDateTimePicker);
            this.gbDetalle.Controls.Add(fecha_penalizacion_lecLabel);
            this.gbDetalle.Controls.Add(this.fecha_penalizacion_lecDateTimePicker);
            this.gbDetalle.Controls.Add(this.bAceptarLector);
            this.gbDetalle.Controls.Add(this.bCancelarLector);
            this.gbDetalle.Location = new System.Drawing.Point(535, 29);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(420, 294);
            this.gbDetalle.TabIndex = 3;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "DetalleLector";
            // 
            // bProvincias
            // 
            this.bProvincias.Location = new System.Drawing.Point(354, 97);
            this.bProvincias.Name = "bProvincias";
            this.bProvincias.Size = new System.Drawing.Size(30, 23);
            this.bProvincias.TabIndex = 5;
            this.bProvincias.Text = "...";
            this.bProvincias.UseVisualStyleBackColor = true;
            this.bProvincias.Click += new System.EventHandler(this.bProvincias_Click);
            // 
            // id_lecTextBox
            // 
            this.id_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "id_lec", true));
            this.id_lecTextBox.Location = new System.Drawing.Point(148, 22);
            this.id_lecTextBox.Name = "id_lecTextBox";
            this.id_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_lecTextBox.TabIndex = 9;
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataMember = "lectores";
            this.lectoresBindingSource.DataSource = this.dS_Lectores;
            // 
            // dS_Lectores
            // 
            this.dS_Lectores.DataSetName = "DS_Lectores";
            this.dS_Lectores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombre_lecTextBox
            // 
            this.nombre_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "nombre_lec", true));
            this.nombre_lecTextBox.Location = new System.Drawing.Point(148, 48);
            this.nombre_lecTextBox.Name = "nombre_lecTextBox";
            this.nombre_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombre_lecTextBox.TabIndex = 11;
            // 
            // domicilio_lecTextBox
            // 
            this.domicilio_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "domicilio_lec", true));
            this.domicilio_lecTextBox.Location = new System.Drawing.Point(148, 74);
            this.domicilio_lecTextBox.Name = "domicilio_lecTextBox";
            this.domicilio_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.domicilio_lecTextBox.TabIndex = 13;
            // 
            // provincia_lecTextBox
            // 
            this.provincia_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "provincia_lec", true));
            this.provincia_lecTextBox.Location = new System.Drawing.Point(148, 100);
            this.provincia_lecTextBox.Name = "provincia_lecTextBox";
            this.provincia_lecTextBox.Size = new System.Drawing.Size(34, 20);
            this.provincia_lecTextBox.TabIndex = 15;
            // 
            // email_lecTextBox
            // 
            this.email_lecTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "email_lec", true));
            this.email_lecTextBox.Location = new System.Drawing.Point(148, 126);
            this.email_lecTextBox.Name = "email_lecTextBox";
            this.email_lecTextBox.Size = new System.Drawing.Size(200, 20);
            this.email_lecTextBox.TabIndex = 17;
            // 
            // fecha_nacimiento_lecDateTimePicker
            // 
            this.fecha_nacimiento_lecDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lectoresBindingSource, "fecha_nacimiento_lec", true));
            this.fecha_nacimiento_lecDateTimePicker.Location = new System.Drawing.Point(148, 152);
            this.fecha_nacimiento_lecDateTimePicker.Name = "fecha_nacimiento_lecDateTimePicker";
            this.fecha_nacimiento_lecDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_nacimiento_lecDateTimePicker.TabIndex = 19;
            // 
            // fecha_penalizacion_lecDateTimePicker
            // 
            this.fecha_penalizacion_lecDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.lectoresBindingSource, "fecha_penalizacion_lec", true));
            this.fecha_penalizacion_lecDateTimePicker.Location = new System.Drawing.Point(148, 178);
            this.fecha_penalizacion_lecDateTimePicker.Name = "fecha_penalizacion_lecDateTimePicker";
            this.fecha_penalizacion_lecDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_penalizacion_lecDateTimePicker.TabIndex = 21;
            // 
            // bAceptarLector
            // 
            this.bAceptarLector.Location = new System.Drawing.Point(229, 250);
            this.bAceptarLector.Name = "bAceptarLector";
            this.bAceptarLector.Size = new System.Drawing.Size(75, 23);
            this.bAceptarLector.TabIndex = 8;
            this.bAceptarLector.Text = "Aceptar";
            this.bAceptarLector.UseVisualStyleBackColor = true;
            this.bAceptarLector.Click += new System.EventHandler(this.bAceptarLector_Click);
            // 
            // bCancelarLector
            // 
            this.bCancelarLector.Location = new System.Drawing.Point(96, 250);
            this.bCancelarLector.Name = "bCancelarLector";
            this.bCancelarLector.Size = new System.Drawing.Size(75, 23);
            this.bCancelarLector.TabIndex = 8;
            this.bCancelarLector.Text = "Cancelar";
            this.bCancelarLector.UseVisualStyleBackColor = true;
            this.bCancelarLector.Click += new System.EventHandler(this.bCancelarLector_Click);
            // 
            // gbBuscarLector
            // 
            this.gbBuscarLector.Controls.Add(this.lectoresDataGridView);
            this.gbBuscarLector.Controls.Add(this.bEliminarLector);
            this.gbBuscarLector.Controls.Add(this.bModificarLector);
            this.gbBuscarLector.Controls.Add(this.bNuevoLector);
            this.gbBuscarLector.Controls.Add(this.lNombre);
            this.gbBuscarLector.Controls.Add(this.lid);
            this.gbBuscarLector.Controls.Add(this.bBuscarNombreLector);
            this.gbBuscarLector.Controls.Add(this.bBuscarIdLector);
            this.gbBuscarLector.Controls.Add(this.tbBuscarNombre);
            this.gbBuscarLector.Controls.Add(this.tbBuscarId);
            this.gbBuscarLector.Location = new System.Drawing.Point(17, 29);
            this.gbBuscarLector.Name = "gbBuscarLector";
            this.gbBuscarLector.Size = new System.Drawing.Size(498, 560);
            this.gbBuscarLector.TabIndex = 4;
            this.gbBuscarLector.TabStop = false;
            this.gbBuscarLector.Text = "BuscarLector";
            // 
            // lectoresDataGridView
            // 
            this.lectoresDataGridView.AutoGenerateColumns = false;
            this.lectoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.lectoresDataGridView.DataSource = this.lectoresBindingSource;
            this.lectoresDataGridView.Location = new System.Drawing.Point(16, 122);
            this.lectoresDataGridView.Name = "lectoresDataGridView";
            this.lectoresDataGridView.Size = new System.Drawing.Size(458, 271);
            this.lectoresDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lec";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_lec";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_lec";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre_lec";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "domicilio_lec";
            this.dataGridViewTextBoxColumn3.HeaderText = "domicilio_lec";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "provincia_lec";
            this.dataGridViewTextBoxColumn4.HeaderText = "provincia_lec";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "email_lec";
            this.dataGridViewTextBoxColumn5.HeaderText = "email_lec";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fecha_nacimiento_lec";
            this.dataGridViewTextBoxColumn6.HeaderText = "fecha_nacimiento_lec";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fecha_penalizacion_lec";
            this.dataGridViewTextBoxColumn7.HeaderText = "fecha_penalizacion_lec";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // bEliminarLector
            // 
            this.bEliminarLector.Location = new System.Drawing.Point(378, 485);
            this.bEliminarLector.Name = "bEliminarLector";
            this.bEliminarLector.Size = new System.Drawing.Size(100, 23);
            this.bEliminarLector.TabIndex = 5;
            this.bEliminarLector.Text = "Eliminar";
            this.bEliminarLector.UseVisualStyleBackColor = true;
            this.bEliminarLector.Click += new System.EventHandler(this.bEliminarLector_Click);
            // 
            // bModificarLector
            // 
            this.bModificarLector.Location = new System.Drawing.Point(200, 485);
            this.bModificarLector.Name = "bModificarLector";
            this.bModificarLector.Size = new System.Drawing.Size(100, 23);
            this.bModificarLector.TabIndex = 5;
            this.bModificarLector.Text = "Modificar";
            this.bModificarLector.UseVisualStyleBackColor = true;
            this.bModificarLector.Click += new System.EventHandler(this.bModificarLector_Click);
            // 
            // bNuevoLector
            // 
            this.bNuevoLector.Location = new System.Drawing.Point(25, 485);
            this.bNuevoLector.Name = "bNuevoLector";
            this.bNuevoLector.Size = new System.Drawing.Size(100, 23);
            this.bNuevoLector.TabIndex = 5;
            this.bNuevoLector.Text = "Nuevo";
            this.bNuevoLector.UseVisualStyleBackColor = true;
            this.bNuevoLector.Click += new System.EventHandler(this.bNuevoLector_Click);
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(32, 57);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 4;
            this.lNombre.Text = "Nombre";
            // 
            // lid
            // 
            this.lid.AutoSize = true;
            this.lid.Location = new System.Drawing.Point(32, 20);
            this.lid.Name = "lid";
            this.lid.Size = new System.Drawing.Size(18, 13);
            this.lid.TabIndex = 4;
            this.lid.Text = "ID";
            // 
            // bBuscarNombreLector
            // 
            this.bBuscarNombreLector.Location = new System.Drawing.Point(223, 53);
            this.bBuscarNombreLector.Name = "bBuscarNombreLector";
            this.bBuscarNombreLector.Size = new System.Drawing.Size(75, 23);
            this.bBuscarNombreLector.TabIndex = 3;
            this.bBuscarNombreLector.Text = "Buscar";
            this.bBuscarNombreLector.UseVisualStyleBackColor = true;
            // 
            // bBuscarIdLector
            // 
            this.bBuscarIdLector.Location = new System.Drawing.Point(223, 15);
            this.bBuscarIdLector.Name = "bBuscarIdLector";
            this.bBuscarIdLector.Size = new System.Drawing.Size(75, 23);
            this.bBuscarIdLector.TabIndex = 3;
            this.bBuscarIdLector.Text = "Buscar";
            this.bBuscarIdLector.UseVisualStyleBackColor = true;
            // 
            // tbBuscarNombre
            // 
            this.tbBuscarNombre.Location = new System.Drawing.Point(82, 55);
            this.tbBuscarNombre.Name = "tbBuscarNombre";
            this.tbBuscarNombre.Size = new System.Drawing.Size(135, 20);
            this.tbBuscarNombre.TabIndex = 2;
            // 
            // tbBuscarId
            // 
            this.tbBuscarId.Location = new System.Drawing.Point(72, 17);
            this.tbBuscarId.Name = "tbBuscarId";
            this.tbBuscarId.Size = new System.Drawing.Size(145, 20);
            this.tbBuscarId.TabIndex = 1;
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
            // tbNombreProvincia
            // 
            this.tbNombreProvincia.Location = new System.Drawing.Point(188, 100);
            this.tbNombreProvincia.Name = "tbNombreProvincia";
            this.tbNombreProvincia.Size = new System.Drawing.Size(160, 20);
            this.tbNombreProvincia.TabIndex = 22;
            // 
            // FM_Lectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(962, 608);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.gbBuscarLector);
            this.Name = "FM_Lectores";
            this.Load += new System.EventHandler(this.FM_Lectores_Load);
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Lectores)).EndInit();
            this.gbBuscarLector.ResumeLayout(false);
            this.gbBuscarLector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Button bAceptarLector;
        private System.Windows.Forms.Button bCancelarLector;
        private System.Windows.Forms.GroupBox gbBuscarLector;
        private System.Windows.Forms.Button bEliminarLector;
        private System.Windows.Forms.Button bModificarLector;
        private System.Windows.Forms.Button bNuevoLector;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lid;
        private System.Windows.Forms.Button bBuscarNombreLector;
        private System.Windows.Forms.Button bBuscarIdLector;
        private System.Windows.Forms.TextBox tbBuscarNombre;
        private System.Windows.Forms.TextBox tbBuscarId;
        private DS_Lectores dS_Lectores;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private DS_LectoresTableAdapters.lectoresTableAdapter lectoresTableAdapter;
        private System.Windows.Forms.DataGridView lectoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox id_lecTextBox;
        private System.Windows.Forms.TextBox nombre_lecTextBox;
        private System.Windows.Forms.TextBox domicilio_lecTextBox;
        private System.Windows.Forms.TextBox provincia_lecTextBox;
        private System.Windows.Forms.TextBox email_lecTextBox;
        private System.Windows.Forms.DateTimePicker fecha_nacimiento_lecDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_penalizacion_lecDateTimePicker;
        private DS_LectoresTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button bProvincias;
        private System.Windows.Forms.TextBox tbNombreProvincia;
    }
}
