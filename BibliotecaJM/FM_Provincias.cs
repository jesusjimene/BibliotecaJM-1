using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaJM
{
    public partial class FM_Provincias : Form
    {

        public int IDProvincia { get; set; }
        public string nombreProvincia { get; set; }

        public FM_Provincias()
        {
            InitializeComponent();
        }

        

        private void FM_Provincias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dS_Provincias.provincias' Puede moverla o quitarla según sea necesario.
            this.provinciasTableAdapter.Fill(this.dS_Provincias.provincias);

        }

        private void provinciasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void provinciasDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = provinciasBindingSource.Position;
            IDProvincia = dS_Provincias.provincias[i].id_pro;

            nombreProvincia = dS_Provincias.provincias[i].provincia_pro;
            this.Close();
        }
    }
}
