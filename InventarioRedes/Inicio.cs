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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Inicio_Load);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            int radius = 20;
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            buttonPath.StartFigure();
            buttonPath.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            buttonPath.AddArc(new Rectangle(btnInicio.Width - radius, 0, radius, radius), 270, 90);
            buttonPath.AddArc(new Rectangle(btnInicio.Width - radius, btnInicio.Height - radius, radius, radius), 0, 90);
            buttonPath.AddArc(new Rectangle(0, btnInicio.Height - radius, radius, radius), 90, 90);
            buttonPath.CloseAllFigures();
            btnInicio.Region = new Region(buttonPath);

            System.Drawing.Drawing2D.GraphicsPath buttonPath2 = new System.Drawing.Drawing2D.GraphicsPath();
            buttonPath2.StartFigure();
            buttonPath2.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            buttonPath2.AddArc(new Rectangle(btnCerrar.Width - radius, 0, radius, radius), 270, 90);
            buttonPath2.AddArc(new Rectangle(btnCerrar.Width - radius, btnCerrar.Height - radius, radius, radius), 0, 90);
            buttonPath2.AddArc(new Rectangle(0, btnCerrar.Height - radius, radius, radius), 90, 90);
            buttonPath2.CloseAllFigures();
            btnCerrar.Region = new Region(buttonPath2);
            btnCerrar.Region = new Region(buttonPath2);

            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 1; 
            btnCerrar.FlatAppearance.BorderColor = Color.Gray; 
            btnCerrar.BackColor = Color.White;

            // Configuración del botón btnMinimizar
            System.Drawing.Drawing2D.GraphicsPath pathMinimizar = new System.Drawing.Drawing2D.GraphicsPath();
            pathMinimizar.StartFigure();
            pathMinimizar.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            pathMinimizar.AddArc(new Rectangle(btnMinimizar.Width - radius, 0, radius, radius), 270, 90);
            pathMinimizar.AddArc(new Rectangle(btnMinimizar.Width - radius, btnMinimizar.Height - radius, radius, radius), 0, 90);
            pathMinimizar.AddArc(new Rectangle(0, btnMinimizar.Height - radius, radius, radius), 90, 90);
            pathMinimizar.CloseAllFigures();
            btnMinimizar.Region = new Region(pathMinimizar);
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.FlatAppearance.BorderSize = 1;
            btnMinimizar.FlatAppearance.BorderColor = Color.Gray;
            btnMinimizar.BackColor = Color.White;

            // Configuración del botón btnAgrandar
            System.Drawing.Drawing2D.GraphicsPath pathAgrandar = new System.Drawing.Drawing2D.GraphicsPath();
            pathAgrandar.StartFigure();
            pathAgrandar.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            pathAgrandar.AddArc(new Rectangle(btnAgrander.Width - radius, 0, radius, radius), 270, 90);
            pathAgrandar.AddArc(new Rectangle(btnAgrander.Width - radius, btnAgrander.Height - radius, radius, radius), 0, 90);
            pathAgrandar.AddArc(new Rectangle(0, btnAgrander.Height - radius, radius, radius), 90, 90);
            pathAgrandar.CloseAllFigures();
            btnAgrander.Region = new Region(pathAgrandar);
            btnAgrander.FlatStyle = FlatStyle.Flat;
            btnAgrander.FlatAppearance.BorderSize = 1;
            btnAgrander.FlatAppearance.BorderColor = Color.Gray;
            btnAgrander.BackColor = Color.White;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
