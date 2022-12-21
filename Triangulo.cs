using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geometria
{
    public class Triangulo : Figura2D
    {
        private float _lado1;
        private float _lado2;
        private float _lado3;
        private float _perimetro;
        public Triangulo() { }

        public Triangulo(string nombre, float lado1, float lado2, float lado3) : base(nombre)
        {
            _lado1 = lado1;
            _lado2 = lado2;
            _lado3 = lado3;
        }

        public float lado1 {get { return _lado1; }set { _lado1 = value; }}
        public float lado2 {get { return _lado2; }set { _lado2 = value; }}
        public float lado3 {get { return _lado3; }set { _lado3 = value; }}

        public override float getPerimetro()
        {
            _perimetro = _lado1 + _lado2 + _lado3;
            return _perimetro;
        }

        public override float getSize()
        {
            float s = _perimetro / 2;
            float temp = s * (s - _lado1) * (s - _lado2) * (s - _lado3);
            double area = Math.Sqrt(temp);
            this.Size = Convert.ToSingle(area);
            return this.Size;
        }
    }
}