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
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            buttonPath.StartFigure();
            buttonPath.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            buttonPath.AddArc(new Rectangle(btnRegistrar.Width - radius, 0, radius, radius), 270, 90);
            buttonPath.AddArc(new Rectangle(btnRegistrar.Width - radius, btnRegistrar.Height - radius, radius, radius), 0, 90);
            buttonPath.AddArc(new Rectangle(0, btnRegistrar.Height - radius, radius, radius), 90, 90);
            buttonPath.CloseAllFigures();
            btnRegistrar.Region = new Region(buttonPath);
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
    }
}
