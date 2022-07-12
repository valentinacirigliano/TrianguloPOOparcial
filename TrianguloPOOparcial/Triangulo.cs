using System;
using System.Runtime.CompilerServices;

namespace TrianguloPOOparcial
{
    public  class Triangulo
    {
        private  int LadoA { get; set; }
        private  int LadoB { get; set; }
        private  int LadoC { get; set; }
        public  Triangulo(int ladoA, int ladoB,int ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public Triangulo() : this(1, 1, 1)
        {

        }

        public int GetLadoA() => this.LadoA;
        public  int GetLadoB() => this.LadoB;
        public  int GetLadoC() => this.LadoC;

        public bool EsTriangulo()
        {
            return (((LadoA + LadoB) > LadoC) && ((LadoA + LadoC) > LadoB) && ((LadoB + LadoC) > LadoA));
        }

        public string GetTipoTriangulo()
        {
            if (Math.Pow(LadoA, 2) == LadoB + LadoC)
            {
                return "Rectángulo";
            }else if (Math.Pow(LadoA, 2) > (LadoB + LadoC))
            {
                return "Obtusángulo";
            }
            else
            {
                return "Acutángulo";
            }
        }
        public double GetSuperficie()
        {
            double p = (LadoA + LadoB + LadoC) / 2;
            return Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));

        }

        public double GetPerimetro()
        {
            return LadoA + LadoB + LadoC;
        }
    }
}
