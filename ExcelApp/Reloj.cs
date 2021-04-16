using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelApp
{
    class Reloj
    {
    }
    /*
    public void Reloje()
    {
        try
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(Reloj));
            }
            String fecha = DateTime.Now.ToShortTimeString();
            hora.Text = fecha;
            if ((fecha.Equals(horas.Text) && (AlarmaActidada == false)) || (fecha.Equals("7:00 AM") && (AlarmaActidada == false)) || (fecha.Equals("2:00 PM") && (AlarmaActidada == false)))
            {
                minuto = 0;
                clase.CierraExel();
                this.abreexel();
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

    */
}
