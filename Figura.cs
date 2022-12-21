using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Geometria
{
    public abstract class Figura
    {
        private string _nombre;
        private string _id;
        private string _tipo;
        private float _size;
        private string _lineColor;
        private string _fillColor;
        const string BLACK = "#000000";
        const string WHITE = "#FFFFFF";

        public Figura()
        {
            _id = Guid.NewGuid().ToString();
        }

        public Figura(string nombre)
        {
            _id = Guid.NewGuid().ToString();
            _nombre = nombre;
            _lineColor = BLACK;
            _fillColor = WHITE;
            _tipo = "";
        }

        public Figura(string nombre, string tipo, string lineColor, string fillColor)
        {
            _id = Guid.NewGuid().ToString();
            _nombre = nombre;
            _tipo = tipo;
            _lineColor = lineColor;
            _fillColor = fillColor;
        }

        public void Dibujar() { }

        public string Id { get { return _id; } }

        public abstract float getSize();

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public string LineColor

        {
            get
            {
                return _lineColor;
            }
            set
            {
                string pattern = "^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$";
                Match m = Regex.Match(value, pattern, RegexOptions.IgnoreCase);
                if (m.Success)
                    _lineColor = value;
                else
                    throw new ArgumentException("Color mal definido. Verifique");


            }
        }

        public float Size { get => _size; set => _size = value; }
    }
}