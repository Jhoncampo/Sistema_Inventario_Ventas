using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Inventario_Ventas.Clases;

namespace Sistema_Inventario_Ventas.Vistas
{
    public partial class FormUsuarios : Form
    {

        MetodosUsuarios metodosUsuarios;
        DataTable datos;
        int idUsuario = 0;
        public FormUsuarios()
        {
            InitializeComponent();
        }

       

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            this.MostrarUsuarios();
            this.MostrarPermisos(cbPermisos);
            this.MostrarPermisos(cbActPermisos);
            this.MostrarEstados(cbEstados);
            this.MostrarEstados(cbActEstados);

        }

        private void MostrarPermisos(ComboBox cbPermisos)
        {
            List<Permiso> datos = metodosUsuarios.ObtenerPermisos();
            cbPermisos.Items.Add("Selecciona una opción");
            foreach(Permiso dato in datos)
            {
                cbPermisos.Items.Add(dato.permiso);
            }
            cbPermisos.SelectedIndex = 0;
        }
        private void MostrarEstados(ComboBox cbEstados)
        {
            List<Estado> datos = metodosUsuarios.ObtenerEstados();
            cbEstados.Items.Add("Selecciona una opción");
            foreach (Estado dato in datos)
            {
                cbEstados.Items.Add(dato.estado +1 + "- "+ dato.descripcion);
            }
            cbEstados.SelectedIndex = 0;
        }
        public void MostrarUsuarios()
        {
            metodosUsuarios = new MetodosUsuarios();
            datos = metodosUsuarios.ObtenerUsuarios();
            FormatoTablaUsuarios(datos);
        }
        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            this.limpiarCampos();
            this.datos.Reset();
            this.MostrarUsuarios();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nomUsuario = tbNombre.
        }
    }
}
