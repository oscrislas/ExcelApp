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
    public partial class CargaPantalla : Form
    {
        public CargaPantalla()
        {
            InitializeComponent();
        }

        private void cerrar(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
