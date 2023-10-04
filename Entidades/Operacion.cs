namespace Entidades
{
    public class Operacion
    {
        // Variables
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        // Acceder a los operandos
        public Numeracion PrimerOperando
        {
            get { return this.primerOperando; }
            set { this.primerOperando = value; }
        }

        public Numeracion SegundoOperando
        {
            get { return this.segundoOperando; }
            set { this.segundoOperando = value; }
        }

        // Constructor que recibe dos para colocar operandos
        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        // Ooperaciones aritméticas entre los operandos
        public Numeracion Operar(char operacion)
        {
            switch (operacion)
            {
                case '+':
                    return this.primerOperando + this.segundoOperando;
                case '-':
                    return this.primerOperando - this.segundoOperando;
                case '*':
                    return this.primerOperando * this.segundoOperando;
                case '/':
                    return this.primerOperando / this.segundoOperando;
                default:
                    return this.primerOperando + this.segundoOperando;
            }
        }
    }
}
