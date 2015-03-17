using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace racionales.model
{
    class Racional
    {
        private int numerador;
        private int denominador;

        public Racional(int numerador, int denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;
        }

        public int getNumerador()
        {
            return this.numerador;
        }

        public void setNumerador(int numerador)
        {
            this.numerador = numerador;
        }

        public int getDenominador()
        {
            return this.denominador;
        }

        public Racional setDenominador(int denominador)
        {
            if (denominador == 0)
            {
                throw new Exception("Error: Prohibido poner 0");
            }
            this.numerador = numerador;
        }

        // multiplicar y dividir
        public Racional multiplicar(Racional r)
        {
            int numerador = this.numerador * r.getNumerador();
            int denominador = this.denominador * r.getDenominador();

            return new Racional(numerador, denominador);
        }

        public Racional dividir(Racional r)
        {
            int numerador = this.numerador / r.getNumerador;
            int denominador = this.denominador / r.getDenominador;

            return new Racional(numerador, denominador);
        }
    }
}



