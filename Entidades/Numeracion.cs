using System;

namespace Entidades
{
    public enum ESistema
    {
        Binario,
        Decimal
    }

    public abstract class Numeracion
    {
        protected string msgError = "Numero Invalido";
        protected string valor;

        //
        public string Valor
        {
            get { return valor; }
        }

        //
        internal abstract double ValorNumerico
        {
            get;
        }

        //
        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        //
        protected virtual bool EsNumeracionValida(string valor)
        {
            if (valor == null)
            {
                return false;
            }
            else
            {
                foreach (char c in valor)
                {
                    if (c != ' ')
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void InicializaValor(string valor)
        {
            if (EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = msgError;
            }
        }

        //
        protected Numeracion()
        {
            InicializaValor("");
        }

        protected Numeracion(string valor)
        {
            InicializaValor(valor);
        }

        // Conversión explicita de Numeración a double. Esta devolverá el valor de la Numeración.
        public static explicit operator double(Numeracion numeracion)
        {
            return numeracion.ValorNumerico;
        }


        // Sobrecarga de operadores de comparación
        public static bool operator ==(Numeracion numeroUno, Numeracion numeroDos)
        {
            if (numeroUno is null && numeroDos is null)
            {
                return true; // Ambos son nulos, considerados iguales
            }
            if (numeroUno is null || numeroDos is null)
            {
                return false; // Uno de ellos es nulo, considerados diferentes
            }

            return numeroUno.ValorNumerico == numeroDos.ValorNumerico;
        }

        public static bool operator !=(Numeracion numeroUno, Numeracion numeroDos)
        {
            return !(numeroUno == numeroDos);
        }

        // Aritmetica 
        public static double operator +(Numeracion n1, Numeracion n2)
        {
            if (n1.GetType() != n2.GetType())
            {
                throw new InvalidOperationException("Operación inválida entre diferentes tipos de Numeración.");
            }

            double resultadoNumerico = n1.ValorNumerico + n2.ValorNumerico;
            return resultadoNumerico;
        }

        public static double operator -(Numeracion n1, Numeracion n2)
        {
            if (n1.GetType() != n2.GetType())
            {
                throw new InvalidOperationException("Operación inválida entre diferentes tipos de Numeración.");
            }

            double resultadoNumerico = n1.ValorNumerico - n2.ValorNumerico;
            return resultadoNumerico;
        }

        public static double operator *(Numeracion n1, Numeracion n2)
        {
            if (n1.GetType() != n2.GetType())
            {
                throw new InvalidOperationException("Operación inválida entre diferentes tipos de Numeración.");
            }

            double resultadoNumerico = n1.ValorNumerico * n2.ValorNumerico;
            return resultadoNumerico;
        }

        public static double operator /(Numeracion n1, Numeracion n2)
        {
            if (n1.GetType() != n2.GetType())
            {
                throw new InvalidOperationException("Operación inválida entre diferentes tipos de Numeración.");
            }

            if (n2.ValorNumerico == 0)
            {
                throw new InvalidOperationException("Número inválido - División por cero");
            }

            double resultadoNumerico = n1.ValorNumerico / n2.ValorNumerico;
            return resultadoNumerico;
        }

    }

}
