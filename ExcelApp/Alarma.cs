using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelApp
{

    public class Alarma
    {
        int value;
        string hora;

        public Alarma(int value, string hora)
        {
            this.Value = value;
            this.Hora = hora;
        }

        public Alarma()
        {

        }
        public int Value { get => value; set => this.value = value; }
        public string Hora { get => hora; set => hora = value; }
    }
}
