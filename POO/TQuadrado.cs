using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class TQuadrado : TFigura
    {
        private int lado;

        public int Lado { get => lado; 
            protected set => lado = value; 
        
        
        }

        public TQuadrado(int lado, Color cor) 
        
        {
            this.lado = lado;
            this.Cor = cor;
            Calcular();
          
        }

        public override void Calcular()
        {
            Area = lado * lado;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"#### Informações de {GetType().Name} ");
            Console.WriteLine("Lado:" + lado);
            Console.WriteLine("Cor:" + Cor.ToString());
            Console.WriteLine("Area:" + Area);
            Console.WriteLine(" ");
        }
    }
}
