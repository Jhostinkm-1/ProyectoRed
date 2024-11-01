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

        private void VentanaModificar_Load(object sender, EventArgs e)
        {
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            buttonPath.StartFigure();
            buttonPath.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            buttonPath.AddArc(new Rectangle(btnModificar.Width - radius, 0, radius, radius), 270, 90);
            buttonPath.AddArc(new Rectangle(btnModificar.Width - radius, btnModificar.Height - radius, radius, radius), 0, 90);
            buttonPath.AddArc(new Rectangle(0, btnModificar.Height - radius, radius, radius), 90, 90);
            buttonPath.CloseAllFigures();
            btnModificar.Region = new Region(buttonPath);
        }
    }
}
