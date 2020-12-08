using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_fracciones
{
    class fraccion
    {

        private int entero;

        public int Entero
        {
            get { return entero; }
            set { entero = value; }
        }

        private int numerador;

        public int Numerador
        {
            get { return numerador; }
            set { numerador = value; }
        }

        private int denominador;

        public int Denominador
        {
            get { return denominador; }
            set { denominador = value; }
        }
        public fraccion(int n, int d)
        {
            entero = 0;
            numerador = n;
          
            denominador = d;

        }
        public fraccion( int e, int n, int d)
        {
            entero = e;
            numerador = n;
            if (d==0)
            {
                d = 1;
            }
            denominador = d;

        }
     

        public fraccion Sumar(fraccion otra)
        {
            
            int denominadorComun = denominador * otra.denominador;
            int e1 = entero * denominadorComun;
            int n1 = (denominadorComun / denominador) * numerador;
            n1 += e1;
            int e2 = otra.entero * denominadorComun;
            int n2 = (denominadorComun / otra.denominador) * otra.numerador;
            n2 += e2;
            fraccion resultado = new fraccion(n1 + n2, denominadorComun);
            resultado = Simplifcar(resultado);
            return resultado;
        }
        public fraccion Restar(fraccion otra)
        {

            int denominadorComun = denominador * otra.denominador;
            int e1 = entero * denominadorComun;
            int n1 = (denominadorComun / denominador) * numerador;
            n1 += e1;
            int e2 = otra.entero * denominadorComun;
            int n2 = (denominadorComun / denominador) * otra.numerador;
            n2 += e2;
            fraccion resultado = new fraccion(n1-n2, denominadorComun);
            resultado = Simplifcar(resultado);
            return resultado;
        }
        public fraccion Multiplicar(fraccion otra)
        {
            int n1 = numerador + (entero * denominador);
            int n2 = otra.numerador + (otra.entero * otra.denominador);
            fraccion resultado = new fraccion(n1 * n2, denominador*otra.denominador);
            resultado = Simplifcar(resultado);
            return resultado;
        }
        public fraccion Dividir(fraccion otra)
        {
            int n1 = numerador + (entero * denominador);
            int n2 = otra.numerador + (otra.entero * otra.denominador);
            fraccion resultado = new fraccion(n1 *otra.denominador, n2* denominador);
            resultado = Simplifcar(resultado);
            return resultado;
        }


        
        public fraccion Simplifcar(fraccion f)
        {

            fraccion fraccionSimplificada;

            //Agregar la parte entera a la fraccion
            int n = (f.Entero * f.Denominador)+ f.Numerador;
            int d = f.Denominador;
            int e = 0;
            bool negativo = false;
            if (n<0)
            {
                negativo = true;
                n *= -1;
            }
            //reducir la fraccion
            //calcular el maximo comun divisor
            int mcd = MaximoComunDivisor(n, d);
            if (mcd!=0)
            {
            //Reducir la fraccion con base al MCD
            n = n / mcd;
            d = d / mcd;

            if (n>=d)
            {
                e = n / d;
                n = n % d;
            }
            }
            if (negativo&& e>0 )
            {
                e *= -1;
            }
            if (negativo && e == 0)
            {
                n *= -1;
            }


            fraccionSimplificada = new fraccion(e, n, d);
            //Regresar la fraccion reducida
            return fraccionSimplificada;
        }

        public int MaximoComunDivisor( int n,  int d)
        {
            while (d != 0)
            {
                int t = d;
                d = n % d;
                n = t;
            }
            return n;
        }

        public override string ToString()
        {
            if (entero == 0 && numerador==0)
            {
                return entero+"";
            }
            if (entero == 0)
            {
                return numerador + "/" + denominador;
            }
            if (numerador ==0)
            {
                return entero + "";
            }
            return entero + " " + numerador + "/" + denominador;
        }

    }
}
