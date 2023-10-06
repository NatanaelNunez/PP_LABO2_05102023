using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones = new List<string>();
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        private static ESistema sistema = ESistema.Decimal; // Decimal base por defecto

        public string NombreAlumno
        {
            get { return nombreAlumno; }
            set { nombreAlumno = value; }
        }

        public List<string> Operaciones
        {
            get { return operaciones; }
        }

        public Numeracion PrimerOperando
        {
            get { return primerOperando; }
            set { primerOperando = value; }
        }

        public Numeracion Resultado
        {
            get { return resultado; }
        }

        public Numeracion SegundoOperando
        {
            get { return segundoOperando; }
            set { segundoOperando = value; }
        }

        public static ESistema Sistema
        {
            get { return Calculadora.sistema; }
            set { Calculadora.sistema = value; }
        }

        public void ActualizarHistorialDeOperaciones(char operador)
        {
            string historial = $"{Sistema}: {primerOperando.Valor} {operador} {segundoOperando.Valor}";
            operaciones.Add(historial);
        }

        static Calculadora()
        {
            Calculadora.Sistema = ESistema.Decimal;
        }

        public Calculadora()
        {
            operaciones = new List<string>();
        }

        public Calculadora(string nombreAlumno)
        {
            this.nombreAlumno = nombreAlumno;
        }

        public void Calcular()
        {
            Calcular('+'); // Por defecto, realiza una suma
        }
        public void Calcular(char operador)
        {
            if (primerOperando != null && segundoOperando != null)
            {
                if (primerOperando.GetType() == segundoOperando.GetType())
                {
                    switch (operador)
                    {
                        case '+':
                            resultado = primerOperando + segundoOperando;
                            break;
                        case '-':
                            resultado = primerOperando - segundoOperando;
                            break;
                        case '*':
                            resultado = primerOperando * segundoOperando;
                            break;
                        case '/':
                            resultado = primerOperando / segundoOperando;
                            break;
                        default:
                            throw new InvalidOperationException("Operador no valido");
                            break;
                    }
                }
                else
                {
                    throw new InvalidOperationException("Operación inválida entre diferentes tipos de Numeración.");
                }
            }
            else
            {
                throw new InvalidOperationException("Faltan operandos para realizar la operación.");
            }

            // Mapear el resultado al sistema actual de la calculadora
            resultado = MapeaResultado(resultado.ValorNumerico);
        }


        public void EliminarHistorialDeOperaciones()
        {
            operaciones.Clear();
        }

        public Numeracion MapeaResultado(double valor)
        {
            switch (sistema)
            {
                case ESistema.Binario:
                    return new SistemaBinario(valor.ToString());
                case ESistema.Decimal:
                    return new SistemaDecimal(valor.ToString());
                default:
                    return new SistemaDecimal("Sistema no válido");
            }
        }
    }
}