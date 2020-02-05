namespace BibliotecaJM
{
    partial class FM_Libros
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
            System.Windows.Forms.Label id_libLabel;
            System.Windows.Forms.Label titulo_libLabel;
            System.Windows.Forms.Label autor_libLabel;
            System.Windows.Forms.Label seccion_libLabel;
            System.Windows.Forms.Label prestado_sn_libLabel;
            this.gbBuscarLibro = new System.Windows.Forms.GroupBox();
            this.librosDataGridView = new System.Windows.Forms.DataGridView();
            this.bEliminarLibro = new System.Windows.Forms.Button();
            this.bModificarLibro = new System.Windows.Forms.Button();
            this.bNuevoLibro = new System.Windows.Forms.Button();
            this.bBuscarIdLibro = new System.Windows.Forms.Button();
            this.bBuscarTituloLibro = new System.Windows.Forms.Button();
            this.tbBuscarTituloLibro = new System.Windows.Forms.TextBox();
            this.tbBuscarIdLibro = new System.Windows.Forms.TextBox();
            this.lTituloLibro = new System.Windows.Forms.Label();
            this.lIdLibro = new System.Windows.Forms.Label();
            this.gbDetalleLibro = new System.Windows.Forms.GroupBox();
            this.bAceptarLibro = new System.Windows.Forms.Button();
            this.bCancelarLibro = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Libros = new BibliotecaJM.DS_Libros();
            this.librosTableAdapter = new BibliotecaJM.DS_LibrosTableAdapters.librosTableAdapter();
            this.tableAdapterManager = new BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager();
            this.id_libTextBox = new System.Windows.Forms.TextBox();
            this.titulo_libTextBox = new System.Windows.Forms.TextBox();
            this.autor_libTextBox = new System.Windows.Forms.TextBox();
            this.seccion_libTextBox = new System.Windows.Forms.TextBox();
            this.prestado_sn_libTextBox = new System.Windows.Forms.TextBox();
            id_libLabel = new System.Windows.Forms.Label();
            titulo_libLabel = new System.Windows.Forms.Label();
            autor_libLabel = new System.Windows.Forms.Label();
            seccion_libLabel = new System.Windows.Forms.Label();
            prestado_sn_libLabel = new System.Windows.Forms.Label();
            this.gbBuscarLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).BeginInit();
            this.gbDetalleLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuscarLibro
            // 
            this.gbBuscarLibro.Controls.Add(this.librosDataGridView);
            this.gbBuscarLibro.Controls.Add(this.bEliminarLibro);
            this.gbBuscarLibro.Controls.Add(this.bModificarLibro);
            this.gbBuscarLibro.Controls.Add(this.bNuevoLibro);
            this.gbBuscarLibro.Controls.Add(this.bBuscarIdLibro);
            this.gbBuscarLibro.Controls.Add(this.bBuscarTituloLibro);
            this.gbBuscarLibro.Controls.Add(this.tbBuscarTituloLibro);
            this.gbBuscarLibro.Controls.Add(this.tbBuscarIdLibro);
            this.gbBuscarLibro.Controls.Add(this.lTituloLibro);
            this.gbBuscarLibro.Controls.Add(this.lIdLibro);
            this.gbBuscarLibro.Location = new System.Drawing.Point(12, 27);
            this.gbBuscarLibro.Name = "gbBuscarLibro";
            this.gbBuscarLibro.Size = new System.Drawing.Size(523, 492);
            this.gbBuscarLibro.TabIndex = 1;
            this.gbBuscarLibro.TabStop = false;
            this.gbBuscarLibro.Text = "BuscarLibro";
            // 
            // librosDataGridView
            // 
            this.librosDataGridView.AutoGenerateColumns = false;
            this.librosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.librosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.librosDataGridView.DataSource = this.librosBindingSource;
            this.librosDataGridView.Location = new System.Drawing.Point(18, 110);
            this.librosDataGridView.Name = "librosDataGridView";
            this.librosDataGridView.Size = new System.Drawing.Size(490, 291);
            this.librosDataGridView.TabIndex = 9;
            // 
            // bEliminarLibro
            // 
            this.bEliminarLibro.Location = new System.Drawing.Point(408, 444);
            this.bEliminarLibro.Name = "bEliminarLibro";
            this.bEliminarLibro.Size = new System.Drawing.Size(100, 23);
            this.bEliminarLibro.TabIndex = 4;
            this.bEliminarLibro.Text = "Eliminar";
            this.bEliminarLibro.UseVisualStyleBackColor = true;
            // 
            // bModificarLibro
            // 
            this.bModificarLibro.Location = new System.Drawing.Point(215, 444);
            this.bModificarLibro.Name = "bModificarLibro";
            this.bModificarLibro.Size = new System.Drawing.Size(100, 23);
            this.bModificarLibro.TabIndex = 4;
            this.bModificarLibro.Text = "Modificar";
            this.bModificarLibro.UseVisualStyleBackColor = true;
            // 
            // bNuevoLibro
            // 
            this.bNuevoLibro.Location = new System.Drawing.Point(18, 444);
            this.bNuevoLibro.Name = "bNuevoLibro";
            this.bNuevoLibro.Size = new System.Drawing.Size(100, 23);
            this.bNuevoLibro.TabIndex = 4;
            this.bNuevoLibro.Text = "Nuevo";
            this.bNuevoLibro.UseVisualStyleBackColor = true;
            // 
            // bBuscarIdLibro
            // 
            this.bBuscarIdLibro.Location = new System.Drawing.Point(283, 30);
            this.bBuscarIdLibro.Name = "bBuscarIdLibro";
            this.bBuscarIdLibro.Size = new System.Drawing.Size(105, 23);
            this.bBuscarIdLibro.TabIndex = 3;
            this.bBuscarIdLibro.Text = "Buscar";
            this.bBuscarIdLibro.UseVisualStyleBackColor = true;
            // 
            // bBuscarTituloLibro
            // 
            this.bBuscarTituloLibro.Location = new System.Drawing.Point(283, 77);
            this.bBuscarTituloLibro.Name = "bBuscarTituloLibro";
            this.bBuscarTituloLibro.Size = new System.Drawing.Size(105, 23);
            this.bBuscarTituloLibro.TabIndex = 3;
            this.bBuscarTituloLibro.Text = "Buscar";
            this.bBuscarTituloLibro.UseVisualStyleBackColor = true;
            // 
            // tbBuscarTituloLibro
            // 
            this.tbBuscarTituloLibro.Location = new System.Drawing.Point(74, 78);
            this.tbBuscarTituloLibro.Name = "tbBuscarTituloLibro";
            this.tbBuscarTituloLibro.Size = new System.Drawing.Size(155, 20);
            this.tbBuscarTituloLibro.TabIndex = 2;
            // 
            // tbBuscarIdLibro
            // 
            this.tbBuscarIdLibro.Location = new System.Drawing.Point(74, 32);
            this.tbBuscarIdLibro.Name = "tbBuscarIdLibro";
            this.tbBuscarIdLibro.Size = new System.Drawing.Size(155, 20);
            this.tbBuscarIdLibro.TabIndex = 2;
            // 
            // lTituloLibro
            // 
            this.lTituloLibro.AutoSize = true;
            this.lTituloLibro.Location = new System.Drawing.Point(24, 78);
            this.lTituloLibro.Name = "lTituloLibro";
            this.lTituloLibro.Size = new System.Drawing.Size(33, 13);
            this.lTituloLibro.TabIndex = 1;
            this.lTituloLibro.Text = "Titulo";
            // 
            // lIdLibro
            // 
            this.lIdLibro.AutoSize = true;
            this.lIdLibro.Location = new System.Drawing.Point(24, 35);
            this.lIdLibro.Name = "lIdLibro";
            this.lIdLibro.Size = new System.Drawing.Size(18, 13);
            this.lIdLibro.TabIndex = 1;
            this.lIdLibro.Text = "ID";
            // 
            // gbDetalleLibro
            // 
            this.gbDetalleLibro.Controls.Add(id_libLabel);
            this.gbDetalleLibro.Controls.Add(this.id_libTextBox);
            this.gbDetalleLibro.Controls.Add(titulo_libLabel);
            this.gbDetalleLibro.Controls.Add(this.titulo_libTextBox);
            this.gbDetalleLibro.Controls.Add(autor_libLabel);
            this.gbDetalleLibro.Controls.Add(this.autor_libTextBox);
            this.gbDetalleLibro.Controls.Add(seccion_libLabel);
            this.gbDetalleLibro.Controls.Add(this.seccion_libTextBox);
            this.gbDetalleLibro.Controls.Add(prestado_sn_libLabel);
            this.gbDetalleLibro.Controls.Add(this.prestado_sn_libTextBox);
            this.gbDetalleLibro.Controls.Add(this.bAceptarLibro);
            this.gbDetalleLibro.Controls.Add(this.bCancelarLibro);
            this.gbDetalleLibro.Location = new System.Drawing.Point(541, 27);
            this.gbDetalleLibro.Name = "gbDetalleLibro";
            this.gbDetalleLibro.Size = new System.Drawing.Size(402, 227);
            this.gbDetalleLibro.TabIndex = 2;
            this.gbDetalleLibro.TabStop = false;
            this.gbDetalleLibro.Text = "DetallesLibro";
            // 
            // bAceptarLibro
            // 
            this.bAceptarLibro.Location = new System.Drawing.Point(196, 168);
            this.bAceptarLibro.Name = "bAceptarLibro";
            this.bAceptarLibro.Size = new System.Drawing.Size(75, 23);
            this.bAceptarLibro.TabIndex = 8;
            this.bAceptarLibro.Text = "Aceptar";
            this.bAceptarLibro.UseVisualStyleBackColor = true;
            // 
            // bCancelarLibro
            // 
            this.bCancelarLibro.Location = new System.Drawing.Point(57, 168);
            this.bCancelarLibro.Name = "bCancelarLibro";
            this.bCancelarLibro.Size = new System.Drawing.Size(75, 23);
            this.bCancelarLibro.TabIndex = 8;
            this.bCancelarLibro.Text = "Cancelar";
            this.bCancelarLibro.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_lib";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_lib";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "titulo_lib";
            this.dataGridViewTextBoxColumn2.HeaderText = "titulo_lib";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "autor_lib";
            this.dataGridViewTextBoxColumn3.HeaderText = "autor_lib";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "seccion_lib";
            this.dataGridViewTextBoxColumn4.HeaderText = "seccion_lib";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn5.HeaderText = "prestado_sn_lib";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataMember = "libros";
            this.librosBindingSource.DataSource = this.dS_Libros;
            // 
            // dS_Libros
            // 
            this.dS_Libros.DataSetName = "DS_Libros";
            this.dS_Libros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // librosTableAdapter
            // 
            this.librosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.librosTableAdapter = this.librosTableAdapter;
            this.tableAdapterManager.UpdateOrder = BibliotecaJM.DS_LibrosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // id_libLabel
            // 
            id_libLabel.AutoSize = true;
            id_libLabel.Location = new System.Drawing.Point(30, 30);
            id_libLabel.Name = "id_libLabel";
            id_libLabel.Size = new System.Drawing.Size(31, 13);
            id_libLabel.TabIndex = 8;
            id_libLabel.Text = "id lib:";
            // 
            // id_libTextBox
            // 
            this.id_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "id_lib", true));
            this.id_libTextBox.Location = new System.Drawing.Point(114, 27);
            this.id_libTextBox.Name = "id_libTextBox";
            this.id_libTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_libTextBox.TabIndex = 9;
            // 
            // titulo_libLabel
            // 
            titulo_libLabel.AutoSize = true;
            titulo_libLabel.Location = new System.Drawing.Point(30, 56);
            titulo_libLabel.Name = "titulo_libLabel";
            titulo_libLabel.Size = new System.Drawing.Size(45, 13);
            titulo_libLabel.TabIndex = 10;
            titulo_libLabel.Text = "titulo lib:";
            // 
            // titulo_libTextBox
            // 
            this.titulo_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "titulo_lib", true));
            this.titulo_libTextBox.Location = new System.Drawing.Point(114, 53);
            this.titulo_libTextBox.Name = "titulo_libTextBox";
            this.titulo_libTextBox.Size = new System.Drawing.Size(100, 20);
            this.titulo_libTextBox.TabIndex = 11;
            // 
            // autor_libLabel
            // 
            autor_libLabel.AutoSize = true;
            autor_libLabel.Location = new System.Drawing.Point(30, 82);
            autor_libLabel.Name = "autor_libLabel";
            autor_libLabel.Size = new System.Drawing.Size(47, 13);
            autor_libLabel.TabIndex = 12;
            autor_libLabel.Text = "autor lib:";
            // 
            // autor_libTextBox
            // 
            this.autor_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "autor_lib", true));
            this.autor_libTextBox.Location = new System.Drawing.Point(114, 79);
            this.autor_libTextBox.Name = "autor_libTextBox";
            this.autor_libTextBox.Size = new System.Drawing.Size(100, 20);
            this.autor_libTextBox.TabIndex = 13;
            // 
            // seccion_libLabel
            // 
            seccion_libLabel.AutoSize = true;
            seccion_libLabel.Location = new System.Drawing.Point(30, 108);
            seccion_libLabel.Name = "seccion_libLabel";
            seccion_libLabel.Size = new System.Drawing.Size(60, 13);
            seccion_libLabel.TabIndex = 14;
            seccion_libLabel.Text = "seccion lib:";
            // 
            // seccion_libTextBox
            // 
            this.seccion_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "seccion_lib", true));
            this.seccion_libTextBox.Location = new System.Drawing.Point(114, 105);
            this.seccion_libTextBox.Name = "seccion_libTextBox";
            this.seccion_libTextBox.Size = new System.Drawing.Size(100, 20);
            this.seccion_libTextBox.TabIndex = 15;
            // 
            // prestado_sn_libLabel
            // 
            prestado_sn_libLabel.AutoSize = true;
            prestado_sn_libLabel.Location = new System.Drawing.Point(30, 134);
            prestado_sn_libLabel.Name = "prestado_sn_libLabel";
            prestado_sn_libLabel.Size = new System.Drawing.Size(78, 13);
            prestado_sn_libLabel.TabIndex = 16;
            prestado_sn_libLabel.Text = "prestado sn lib:";
            // 
            // prestado_sn_libTextBox
            // 
            this.prestado_sn_libTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "prestado_sn_lib", true));
            this.prestado_sn_libTextBox.Location = new System.Drawing.Point(114, 131);
            this.prestado_sn_libTextBox.Name = "prestado_sn_libTextBox";
            this.prestado_sn_libTextBox.Size = new System.Drawing.Size(100, 20);
            this.prestado_sn_libTextBox.TabIndex = 17;
            // 
            // FM_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(955, 558);
            this.Controls.Add(this.gbBuscarLibro);
            this.Controls.Add(this.gbDetalleLibro);
            this.Name = "FM_Libros";
            this.Load += new System.EventHandler(this.FM_Libros_Load);
            this.gbBuscarLibro.ResumeLayout(false);
            this.gbBuscarLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosDataGridView)).EndInit();
            this.gbDetalleLibro.ResumeLayout(false);
            this.gbDetalleLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Libros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBuscarLibro;
        private System.Windows.Forms.Button bEliminarLibro;
        private System.Windows.Forms.Button bModificarLibro;
        private System.Windows.Forms.Button bNuevoLibro;
        private System.Windows.Forms.Button bBuscarIdLibro;
        private System.Windows.Forms.Button bBuscarTituloLibro;
        private System.Windows.Forms.TextBox tbBuscarTituloLibro;
        private System.Windows.Forms.TextBox tbBuscarIdLibro;
        private System.Windows.Forms.Label lTituloLibro;
        private System.Windows.Forms.Label lIdLibro;
        private System.Windows.Forms.GroupBox gbDetalleLibro;
        private System.Windows.Forms.Button bAceptarLibro;
        private System.Windows.Forms.Button bCancelarLibro;
        private DS_Libros dS_Libros;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private DS_LibrosTableAdapters.librosTableAdapter librosTableAdapter;
        private System.Windows.Forms.DataGridView librosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox id_libTextBox;
        private System.Windows.Forms.TextBox titulo_libTextBox;
        private System.Windows.Forms.TextBox autor_libTextBox;
        private System.Windows.Forms.TextBox seccion_libTextBox;
        private System.Windows.Forms.TextBox prestado_sn_libTextBox;
        private DS_LibrosTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
