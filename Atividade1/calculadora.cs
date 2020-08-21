using System;

namespace Calc {
    class CalculadoraTeste{
         static void Main(string[] args) {
            Calculadora p = new Calculadora(5,6);
            Console.WriteLine(p.soma());
            Console.WriteLine(p.subtrai());
            Console.WriteLine(p.multiplica());
            Console.WriteLine(p.dividi());
        }
    }
    class Calculadora {
        private int x;
        private int y;

        public Calculadora(int x,int y) {
            this.x = x;
            this.y = y;
        }
        public void setValores(int x,int y){
            this.x = x;
            this.y = y;
        }
        public int soma() {
            return x + y;
        }

        public int subtrai() {
            return x - y;
        }

        public int multiplica() {
            return x * y;
        }
        public int dividi() {
            return x / y;
        }


    }

   

}