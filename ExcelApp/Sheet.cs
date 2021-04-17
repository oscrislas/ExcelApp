using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelApp
{
    public class Sheet
    {
        string value;
        string nombre;

        public Sheet()
        {
        }

        public string Value { get => value; set => this.value = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
