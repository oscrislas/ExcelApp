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
    public partial class Relog : Form
    {
        int hora;
        int minuto;
        String fecha;
        int dia;
        string mes;
        int ano;
        List<string> alarma = new List<string>();
        bool AlarmaActidada;
        Menu m = new Menu();
        public Relog()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Reloje()
        {
            try
            {
                if (InvokeRequired)
                {
                    this.Invoke(new Action(Reloje));
                }
                
                if ((reloj.Text.Equals("7:00 am") && (AlarmaActidada == false)) || (fecha.Equals("7:00 AM") && (AlarmaActidada == false)) || (fecha.Equals("2:00 PM") && (AlarmaActidada == false)))
                {
                    minuto = 0;
                  //  m.AbrirExcel();
                    AlarmaActidada = true;
                    Console.WriteLine("alarma");
                }
                if ((reloj.Text.Equals("2:00 pm") && (AlarmaActidada == false)) || (fecha.Equals("7:00 AM") && (AlarmaActidada == false)) || (fecha.Equals("2:00 PM") && (AlarmaActidada == false)))
                {
                    minuto = 0;
                 //   m.AbrirExcel();
                    AlarmaActidada = true;
                    Console.WriteLine("alarma");
                }

                if (minuto >= 60 && (AlarmaActidada == true))
                {
                    Console.WriteLine("cansela");
                    AlarmaActidada = false;
                    minuto = 0;
                }

            }
            catch
            {
                Console.WriteLine("error");
            }
            minuto++;
            Console.WriteLine(minuto);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reloj.Text = DateTime.Now.ToShortTimeString();
            this.miFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void dataGridView1_EditModeChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void dataGridView1_CellErrorTextChanged(object sender, DataGridViewCellEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
