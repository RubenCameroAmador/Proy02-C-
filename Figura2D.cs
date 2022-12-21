using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geometria
{
    public abstract class Figura2D : Figura
    {
        private float _perimetro;
        public Figura2D() { }
        public Figura2D(string nombre) : base(nombre) { }
        public Figura2D(string nombre, string tipo, string colorLinea, string colorRelleno) : base(nombre, tipo, colorLinea, colorRelleno)
        {
        }
        public abstract float getPerimetro();
    }
}