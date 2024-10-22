using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioRedes
{
    public partial class VentanaModificar : Form
    {
        public VentanaModificar()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAgrander_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           AgregarInventario agregarInventarioWTF = new AgregarInventario();
            agregarInventarioWTF.Show();
            this.Hide();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio inicioWTF = new Inicio();
            inicioWTF.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            VentanaEliminar ventanaEliminarWFT = new VentanaEliminar();
            ventanaEliminarWFT.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarUsuario registrarUsuarioWFT = new RegistrarUsuario();
            registrarUsuarioWFT.Show();
            this.Hide();
        }
    }
}
