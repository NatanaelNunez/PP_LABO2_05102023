using System;

namespace Entidades
{
    public class Numeracion
    {
        // Enumeración sistemas numéricos
        public enum ESistema
        {
            Binario,
            Decimal
        };

        // Atributos
        private ESistema sistema;
        private double valorNumerico;

        // Obtener el sistema numérico
        public ESistema Sistema
        {
            get { return this.sistema; }
        }

        // Obtener el valor como cadena - serResultado
        public string Valor
        {
            get { return this.valorNumerico.ToString(); }
        }

        // Recibe un valor numérico y un sistema - Decimal
        public Numeracion(double valor, ESistema sistema)
            : this(valor.ToString(), sistema)
        {
        }

        // Recibe una cadena y un sistema - Binario
        public Numeracion(string valor, ESistema sistema)
        {
            this.InicializarValores(valor, sistema);
        }

        
        private void InicializarValores(string valor, ESistema sistema)
        {

            this.sistema = sistema; // Me faltaba asignar el sistema

            if (sistema == ESistema.Decimal)
            {
                double.TryParse(valor, out this.valorNumerico);
            }
            else if (sistema == ESistema.Binario)
            {
                this.valorNumerico = this.BinarioDecimal(valor);
            }
            else
            {
                this.valorNumerico = double.MinValue;
            }
        }

        // Verificar si una cadena es binaria
        private bool EsBinario(string valor)
        {
            if (string.IsNullOrEmpty(valor))
            {
                return false;
            }

            for (int i = 0; i < valor.Length; i++)
            {
                if (valor[i] != '0' && valor[i] != '1')
                {
                    return false;
                }
            }

            return true;
        }

        // Convertir a un sistema numérico especificado - El ValorNumerico ya con su resultado
        public string ConvertirA(ESistema sistema)
        {
            if (sistema == ESistema.Binario)
            {
                if (this.valorNumerico == (int)this.valorNumerico)
                {
                    return DecimalBinario((int)this.valorNumerico);
                }
                else
                {
                    return DecimalBinario(this.valorNumerico.ToString());
                }
            }
            else if (sistema == ESistema.Decimal)
            {
                return this.valorNumerico.ToString();
            }
            else
            {
                return "Número inválido";
            }
        }

        // decimal a binario
        private string DecimalBinario(int valor)
        {
            if (valor == 0)
            {
                return "0";
            }
            else if (valor < 0)
            {
                return "Número inválido"; // numero binario negativo
            }

            string valorBinario = "";

            while (valor > 0)
            {
                int resto = valor % 2;
                valorBinario = resto + valorBinario;
                valor /= 2;
            }

            return valorBinario;
        }

        // decimal a binario (con sobrecarga)
        private string DecimalBinario(string valor)
        {
            double.TryParse(valor, out double resultadoDiv);
            double restoDiv;

            if (string.IsNullOrEmpty(valor))
            {
                do
                {
                    restoDiv = resultadoDiv % 2;
                    resultadoDiv /= 2;
                    valor = resultadoDiv.ToString() + valor;

                } while (resultadoDiv > 0);
            }
            else
            {
                return "Numero invalido";
            }

            return valor;
        }

        // binario a decimal
        private double BinarioDecimal(string valor)
        {
            if (this.EsBinario(valor))
            {
                double resultado = 0;
                int longitudDelValor = valor.Length;

                for (int i = 0; i < longitudDelValor; i++)
                {
                    int digito = valor[i] - '0';
                    resultado += digito * Math.Pow(2, longitudDelValor - i - 1);
                }
                return resultado;
            }
            else
            {
                return 0; // Número binario inválido
            }
        }


        // Sobrecarga de operadores de comparación
        public static bool operator ==(Numeracion numeroUno, Numeracion numeroDos)
        {
            if (numeroUno is null || numeroDos is null)
            {
                return false;
            }

            return numeroUno.valorNumerico == numeroDos.valorNumerico && numeroUno.Sistema == numeroDos.Sistema;
        }

        public static bool operator !=(Numeracion numeroUno, Numeracion numeroDos)
        {
            if (numeroUno is null || numeroDos is null)
            {
                return false;
            }

            return !(numeroUno == numeroDos);
        }

        public static bool operator ==(ESistema sistema, Numeracion numeracion)
        {
            return sistema == (ESistema)numeracion.valorNumerico;
        }

        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion);
        }

        // Sobrecarga de operaciones
        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            double resultado = n1.valorNumerico + n2.valorNumerico;
            return new Numeracion(resultado, n1.Sistema);
        }
        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            double resultado = n1.valorNumerico - n2.valorNumerico;
            return new Numeracion(resultado, n1.Sistema);
        }

        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            double resultado = n1.valorNumerico * n2.valorNumerico;
            return new Numeracion(resultado, n1.Sistema);
        }

        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            if (n2.valorNumerico == 0)
            {
                return new Numeracion("Número inválido - Division por cero", ESistema.Decimal);
            }

            double resultado = n1.valorNumerico / n2.valorNumerico;
            return new Numeracion(resultado, n1.Sistema);
        }
    }
}
