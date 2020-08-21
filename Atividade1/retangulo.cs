using System;

namespace ret {
    class Program {
        static void Main(string[] args) {
            Retangulo novoRetangulo = new Retangulo(10, 5);
            Console.WriteLine(novoRetangulo.calculaArea());
            Console.WriteLine(novoRetangulo.calcularPerimetro());
            novoRetangulo.novosLados(10,7);
            Console.WriteLine(novoRetangulo.calculaArea());
            Console.WriteLine(novoRetangulo.calcularPerimetro());
            
        }
    }

    class Retangulo{
        private double lado1;
        private double lado2;

        private double area;
        private double perimetro;

        public Retangulo(double x, double y) {
            lado1 = x;
            lado2 = y;
        }

        public void novosLados(double l1,double l2){
            lado1= l1;
            lado2 = l2;
        }
        public double calculaArea() {
            area = lado1 * lado2;
            return area;
        }
        public double calcularPerimetro() {
            perimetro = (lado1 * 2) + (lado2 * 2);
            return perimetro;
        }

    }
}