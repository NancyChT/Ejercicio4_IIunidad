using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        UsuarioDatos UserDatos = new UsuarioDatos();
        private async void LlenarDataGrid()
        {
            UsuariosdataGridView.DataSource = await UserDatos.DevolverListaAsync();

        }
    }
}
