using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Lectores : BibliotecaJM.FM_Modelo
    {
        private UsuarioActual usuarioActual;

        public FM_Lectores()
        {
            InitializeComponent();
        }

        public FM_Lectores(UsuarioActual usuarioActual)
        {
            this.usuarioActual = usuarioActual;
            InitializeComponent();
        }

       public void ModoEdicion()
        {
            gbBuscarLector.Enabled = false;
            gbBuscarLector.Enabled = true;
        }

        public void ModoBusqueda()
        {
            gbBuscarLector.Enabled = true;
            gbBuscarLector.Enabled = false;
        }
        private void FM_Lectores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Lectores.lectores' Puede moverla o quitarla según sea necesario.
            this.lectoresTableAdapter.Fill(this.dS_Lectores.lectores);

        }

        private void bNuevoLector_Click(object sender, EventArgs e)
        {
            this.lectoresBindingSource.AddNew();
            ModoEdicion();
            this.nombre_lecTextBox.Focus();
        }

        private void bModificarLector_Click(object sender, EventArgs e)
        {
            ModoEdicion();
        }

        private void bAceptarLector_Click(object sender, EventArgs e)
        {
            try
            {
                lectoresBindingSource.EndEdit();
                this.lectoresTableAdapter.Update(this.dS_Lectores.lectores);
                ModoBusqueda();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"No se ha podido actualizar");
            }
        }

        private void bCancelarLector_Click(object sender, EventArgs e)
        {

        }

        private void bEliminarLector_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea eliminar registro",
                "confirmacion", MessageBoxButtons.YesNo))
                try
                {
                    this.lectoresBindingSource.RemoveCurrent();
                    this.lectoresTableAdapter.Update(this.dS_Lectores.lectores);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message,"No se ha eliminado correctamente");
                }
        }

        private void bProvincias_Click(object sender, EventArgs e)
        {
            FM_Provincias provi = new FM_Provincias();
            provi.ShowDialog();
            provincia_lecTextBox.Text = provi.IDProvincia.ToString();
            tbNombreProvincia.Text = provi.nombreProvincia.ToString();

        }
    }
}
