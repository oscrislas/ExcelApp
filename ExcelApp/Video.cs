using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using c=ExcelApp.WindowsInt;

namespace ExcelApp
{
    public partial class Video : Form
    {
        Form formulario = null;
        Menu menuconf = null;
        public Video()
        {
            InitializeComponent();
            menuconf = new Menu();
            addFrame(menuconf);
            marco.Region = System.Drawing.Region.FromHrgn(c.CreateRoundRectRgn(0, 0, marco.Width, marco.Height, 30, 30));
        }

        private void addFrame(Form ventana)
        {
            if (formulario != null)
            {
                formulario.Close();
                this.menu.Controls.Clear();
            }

            ventana.TopLevel = false;
            formulario = ventana;
            this.menu.Controls.Add(ventana);
            ventana.Dock = DockStyle.Fill;
            this.menu.Tag = ventana;

            ventana.BringToFront();
            ventana.Show();
        }

        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
            c.ReleaseCapture();
            c.SendMessage(this.marco.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.marco.Visible = false;
        }

        private void playlist()
        {
            try
            {


                foreach (var item in Directory.GetFiles(menuconf.getDirText(), "*.MP4"))
                {
                    WMPLib.IWMPMedia nueva = axWindowsMediaPlayer1.newMedia(item);
                    axWindowsMediaPlayer1.currentPlaylist.appendItem(nueva);
                }
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
               // playlist();
            }


        }


        private void axWindowsMediaPlayer1_KeyDownEvent_1(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
            if (e.nKeyCode == 's' || e.nKeyCode == 'S')
            {
                if (marco.Visible)
                {
                    axWindowsMediaPlayer1.Visible = false;

                }
                else
                {
                    axWindowsMediaPlayer1.Visible = true;

                }

            }
            if (e.nKeyCode == 'c' || e.nKeyCode == 'C')
            {
                //   clase.CierraExel();
            }
            if (e.nKeyCode == 'a' || e.nKeyCode == 'A')
            {
                // this.abreexel();
            }
            if (e.nKeyCode == 'r' || e.nKeyCode == 'R')
            {
                /*
                if (Cargando == false)
                {
                    Cargando = true;
                    clase.CierraExel();
                    this.abreexel();
                }
                */

            }
            if (e.nKeyCode == 'p' || e.nKeyCode == 'P')
            {

                playlist();

            }
            if (e.nKeyCode == 'x' || e.nKeyCode == 'X')
            {

                this.Close();


            }
            if (e.nKeyCode == 'm' || e.nKeyCode == 'M')
            {
                int ancho = 3990;
                int largo = 2200;
                this.ClientSize = new System.Drawing.Size(ancho, largo);

            }
        }
    }
}
