using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class TCirculo : TFigura
    {
        private int raio;

        public int Raio { get => raio;}

        public TCirculo(int raio, Color cor) 
        {
            this.raio = raio;
            Cor = Cor;
            Calcular();
        }

        public override void Calcular()
        {
            Area = Math.PI * Math.Pow(raio, 2);

        }

        public override void Imprimir()
        {
            Console.WriteLine($"#### Informações de {GetType().Name} ");
            Console.WriteLine("Raio:" + raio);
            Console.WriteLine("Cor:" + Cor.ToString());
            Console.WriteLine("Area:" + Area);
            Console.WriteLine(" ");
        }
    }
}

