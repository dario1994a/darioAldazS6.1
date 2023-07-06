using System;
using System.Collections.Generic;
using System.Text;

namespace darioAldazS6
{
    public class Datos
    {
        public int codigo { set; get; }
        public string nombre { set; get; }
        public string apellido { set; get; }
        public string edad { set; get; }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Edad { get => edad; set => edad = value; }
    }
}
