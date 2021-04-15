using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelApp
{
    public partial class Video : Form
    {
        Form formulario = null;
        public Video()
        {
            InitializeComponent();
            addFrame(new Menu());
     
        }

        private void addFrame(Form ventana)
        {
            if (formulario != null)
            {
                formulario.Close();
                this.Controls.Clear();
            }

            ventana.TopLevel = false;
            formulario = ventana;
            this.Controls.Add(ventana);
            ventana.Dock = DockStyle.Fill;
            this.Tag = ventana;

            ventana.BringToFront();
            ventana.Show();
        }
    }
}
