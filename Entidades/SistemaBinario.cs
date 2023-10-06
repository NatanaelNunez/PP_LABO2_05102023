using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor)
        {
        }

        // Constructor adicional que acepta un valor en formato binario.
        public SistemaBinario(long valorBinario) : base(Convert.ToString(valorBinario, 2))
        {
        }

        internal override double ValorNumerico
        {
            get
            {
                SistemaDecimal valorDecimal = BinarioADecimal();
                return valorDecimal.ValorNumerico;
            }
        }

        private SistemaDecimal BinarioADecimal()
        {
            if (EsNumeracionValida(valor))
            {
                double resultado = 0;
                int longitudDelValor = valor.Length;

                for (int i = 0; i < longitudDelValor; i++) // Reuso de integrador
                {
                    int digito = valor[i] - '0';
                    resultado += digito * Math.Pow(2, longitudDelValor - i - 1);
                }
                return new SistemaDecimal(resultado.ToString());
            }
            else
            {
                return new SistemaDecimal(msgError);
            }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Binario)
            {
                return this; // Ya estamos en sistema binario, no es necesario convertir.
            }
            else // es sistema decimal
            {
                SistemaDecimal valorDecimal = BinarioADecimal();
                return valorDecimal;
            }
        }

        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }

        protected override bool EsNumeracionValida(string valor)
        {
            // Metodo de la clase base 
            bool valido = true;

            valido = base.EsNumeracionValida(valor);

            if (!valido)
            {
                return false;
            }

            valido = EsSistemaBinarioValido(valor);

            if (!valido)
            {
                return false;
            }

            return true;
        }

        private bool EsSistemaBinarioValido(string valor)
        {
            foreach (char c in valor)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

    }
}
