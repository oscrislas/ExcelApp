using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using c=ExcelApp.WindowsInt;

namespace ExcelApp
{
    public partial class Video : Form
    {
        Form formulario = null;
        Form cargando = null;
        Menu menuconf = null;
        
        int progreso = 0;
        public Video()
        {
            InitializeComponent();
            menuconf = new Menu();
            
            addFrame(menuconf);
           // this.Size = new System.Drawing.Size(3990, 2200);
            marco.Region = System.Drawing.Region.FromHrgn(c.CreateRoundRectRgn(0, 0, marco.Width, marco.Height, 30, 30));
            menu.Region = System.Drawing.Region.FromHrgn(c.CreateRoundRectRgn(0, 0, marco.Width, marco.Height, 30, 30));

            PingApp();
            this.ClientSize = new Size(3990,2200);
            playlist();
            menuconf.cerrarExcel();

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


        private async void axWindowsMediaPlayer1_KeyDownEvent_1(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
            if (e.nKeyCode == 's' || e.nKeyCode == 'S')
            {
                if (this.marco.Visible)
                {
                    this.marco.Visible = false;

                }
                else
                {
                    this.marco.Visible = true;

                }

            }
            if (e.nKeyCode == 'c' || e.nKeyCode == 'C')
            {
                menuconf.cerrarExcel();
            }
            if (e.nKeyCode == 'a' || e.nKeyCode == 'A')
            {
                menuconf.AbrirExcel();
            }
            if (e.nKeyCode == 'o' || e.nKeyCode == 'O')
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    menuconf.cerrarExcel();
                    menuconf.AbrirExcel();
                    this.Cursor = Cursors.Arrow;

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }

            if (e.nKeyCode == 'r' || e.nKeyCode == 'R')
            {
                this.Cursor = Cursors.WaitCursor;
                try
                {
                    if (menuconf.estanAbiertos == false)
                    {
                        menuconf.AbrirExcel();
                    }
                    else
                    {
                        this.Cursor = Cursors.WaitCursor;
                        menuconf.ActulizaExceles();
                        this.Cursor = Cursors.Arrow;
                    }

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
                this.Cursor = Cursors.Arrow;

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

        private void button2_Click(object sender, EventArgs e)
        {
            playlist();
        }

        private void axWindowsMediaPlayer1_KeyPressEvent(object sender, AxWMPLib._WMPOCXEvents_KeyPressEvent e)
        {
            if (e.nKeyAscii == (short)62)
            {
                axWindowsMediaPlayer1.Ctlcontrols.next();

            }
            if (e.nKeyAscii == (short)60)
            {
                axWindowsMediaPlayer1.Ctlcontrols.previous();

            }
        }

        private void Video_SizeChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Size = this.Size;
        }

        private void PingApp()
        {
            this.TopMost = true;

           // VirtualDesktop.Desktop.PinApplication(this.Handle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.addFrame(new Relog());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                VirtualDesktop.Desktop.FromIndex(0).MakeVisible();
                if (this.menuconf.Lista.Count > 0)
                {
                    
                    if (this.menuconf.estanAbiertos)
                    {
                        menuconf.ActulizaExceles();
                    }
                    
                
                }
                
            }
            catch (Exception err)
            {
                
            }
            this.Cursor = Cursors.Arrow;
        }
    }
}
