using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geometria
{
    public class Cuadrado : Figura2D
    {
        private float _lado;

        public Cuadrado() { }
        public Cuadrado(string nombre, float lado) : base(nombre)
        {
            _lado = lado;
        }

        public override float getPerimetro()
        {
            return 4 * _lado;
        }

        public float lado{
            get {return _lado;}
            set {_lado = value;}
        }

        public override float getSize(){
            float size = _lado*_lado;
            this.Size = size;
            return size;
        }
    }
}