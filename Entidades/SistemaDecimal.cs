using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        public SistemaDecimal(string valor) : base(valor)
        {
        }

        internal override double ValorNumerico
        {
            get
            {
                if (EsNumeracionValida(Valor))
                {
                    double resultado;
                    if (double.TryParse(Valor, out resultado))
                    {
                        return resultado;
                    }
                }

                return 0;
            }
        }
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return this; // Ya estamos en sistema decimal, no es necesario convertir.
            }
            else // es binario
            {
                SistemaBinario valorBinario = DecimalABinario();
                return valorBinario;
            }
        }

        private SistemaBinario DecimalABinario()
        {
            if (EsNumeracionValida(Valor))
            {
                double valorDecimal;
                double.TryParse(Valor, out valorDecimal);

                if (valorDecimal == 0)
                {
                    return new SistemaBinario("0");
                }
                else if (valorDecimal > 0) // Conversion Matematica 
                {
                    int parteEntera = (int)valorDecimal;
                    string valorBinario = "";

                    while (parteEntera > 0)
                    {
                        int resto = parteEntera % 2;
                        valorBinario = resto + valorBinario;
                        parteEntera /= 2;
                    }

                    return new SistemaBinario(valorBinario);
                }
            }

            return new SistemaBinario(msgError);
        }

        protected override bool EsNumeracionValida(string valor) 
        {
            if (base.EsNumeracionValida(valor))
            {
                if (EsSistemaDecimalValido(valor))
                {
                    return true;
                }
            }

            return false;
            
        }

        private bool EsSistemaDecimalValido(string valor)
        {
            double resultado;
            if (double.TryParse(valor, out resultado))
            {
                return true;
            }

            return false;
        }


        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }


    }

}