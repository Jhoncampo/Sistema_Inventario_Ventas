using Sistema_Inventario_Ventas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Inventario_Ventas.Vistas
{
    public partial class FormProveedores : Form
    {
        MetodosProveedores metodosProveedores;
        DataTable datos;
        int idProveedor =0;

        public FormProveedores()
        {
            InitializeComponent();
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            this.MostrarProveedores();
        }

        public void MostrarProveedores()
        {
            metodosProveedores = new MetodosProveedores();
            datos = metodosProveedores.ObtenerProveedores();
            FormatoTablaProveedores(datos);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nomProveedor = tbProveedor.Text;
            string numContacto = tbNumero.Text;
            string direccion = tbDireccion.Text;
            string email = tbEmail.Text;

            Proveedor nuevoProveedor = new Proveedor(nomProveedor, numContacto, direccion, email);  

        }
        private void FormatoTablaProveedores(DataTable datos)
        {

        }
    }
}
