﻿using System;
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
        public Relog()
        {
            InitializeComponent();
            fecha = DateTime.Now.ToShortTimeString();
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
                
                reloj.Text = fecha;
                if ((fecha.Equals(reloj.Text) && (AlarmaActidada == false)) || (fecha.Equals("7:00 AM") && (AlarmaActidada == false)) || (fecha.Equals("2:00 PM") && (AlarmaActidada == false)))
                {
                    minuto = 0;

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
    }
}
