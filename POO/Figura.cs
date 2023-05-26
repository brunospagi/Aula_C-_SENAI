
using System.Drawing;

namespace POO
{
    public abstract class TFigura
    {
        private Color cor;
        private double area;

        public Color Cor { get => cor; set => cor = value; }
        public double Area { get => area; set => area = value; }

        public abstract void Calcular();

        public abstract void Imprimir();
    }
}
