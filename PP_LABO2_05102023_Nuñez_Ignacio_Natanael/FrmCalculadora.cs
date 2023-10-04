using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PP_LABO2_05102023_Nuñez_Ignacio_Natanael
{
    public partial class FrmCalculadora : Form
    {
        private Operacion calculadora;
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        private Numeracion.ESistema sistema;

        public FrmCalculadora()
        {
            InitializeComponent();
            // inicializar tambian calculadora 
            calculadora = new Operacion(null, null);
            resultado = null;


            // Agregar opciones al ComboBox - Espacios para centralizar texto
            string[] opciones = { "           +", "           -", "           *", "           /" };
            cmbOperacion.Items.AddRange(opciones);
        }
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            // Código a ejecutar cuando el formulario se carga.
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la calculadora?", "Confirmar cierre",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0); // Mi intentcion no era ser extremista 
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Llama al evento FrmCalculadora_FormClosing para confirmar el cierre.
            FrmCalculadora_FormClosing(this, new FormClosingEventArgs(CloseReason.UserClosing, false));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // txt
            txtPrimerOperando.Text = "";
            txtSegundoOperando.Text = "";
            // label
            lblResultado.Text = "Resultado: ";
            // Asigna null
            resultado = null; // Reemplaza "this.resultado" con el nombre real del atributo.
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            setResultado();
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDecimal.Checked)
            {
                rdbDecimal.Checked = true;
                rdbBinario.Checked = false;
            }
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBinario.Checked)
            {
                rdbBinario.Checked = true;
                rdbDecimal.Checked = false;
            }
        }

        private void setResultado()
        {
            if (EsDecimal(txtPrimerOperando.Text) && EsDecimal(txtSegundoOperando.Text))
            {

                primerOperando = new Numeracion(txtPrimerOperando.Text, Numeracion.ESistema.Decimal);
                segundoOperando = new Numeracion(txtSegundoOperando.Text, Numeracion.ESistema.Decimal);
            }
            else
            {
                lblResultado.Text = "Error: Uno o ambos operandos no son números decimales válidos";
                return;
            }


            // Verificar como quiere que se muestre el resultado
            if (rdbDecimal.Checked)
            {
                sistema = Numeracion.ESistema.Decimal;
            }
            else if (rdbBinario.Checked)
            {
                sistema = Numeracion.ESistema.Binario;
            }

            // Verifica que ambos operandos no sean nulos && tengo que verificar que sean ambos el mismo sistema capaz
            if (primerOperando.Valor != null && segundoOperando.Valor != null && primerOperando.Sistema == segundoOperando.Sistema)
            {

                // Saber el operador seleccionado
                char operador = cmbOperacion.Text.Trim()[0]; // Primer carácter del ComboBox

                calculadora.PrimerOperando = primerOperando;
                calculadora.SegundoOperando = segundoOperando;

                // Realiza la operación llamando al método Operar de la calculadora
                resultado = calculadora.Operar(operador);

                // Convierte el resultado al sistema seleccionado
                string resultadoConvertido = resultado.ConvertirA(sistema);

                // Verifica si el resultado no es nulo
                if (resultado.Valor != null)
                {
                    lblResultado.Text = "Resultado: " + resultadoConvertido; // mostrar resultado
                }
                else
                {
                    lblResultado.Text = "Error: Sin resultado"; // Error
                }
            }
            else
            {
                // Manejo del caso en que uno o ambos operandos son nulos
                lblResultado.Text = "Error: Uno o ambos operandos son nulos";
            }

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void txtPrimerOperando_TextChanged(object sender, EventArgs e)
        {
            /*
            if (rdbDecimal.Checked)
            {
                // El RadioButton Decimal está seleccionado, crea una instancia con sistema Decimal.
                if (EsDecimal(txtPrimerOperando.Text))
                {
                    primerOperando = new Numeracion(txtPrimerOperando.Text, Numeracion.ESistema.Decimal);
                }
                else
                {
                    // Manejo del caso en que el texto no es un número decimal válido.
                }
            }
            else if (rdbBinario.Checked)
            {
                // El RadioButton Binario está seleccionado, crea una instancia con sistema Binario.
                if (EsBinario(txtPrimerOperando.Text))
                {
                    primerOperando = new Numeracion(txtPrimerOperando.Text, Numeracion.ESistema.Binario);
                }
                else
                {
                    // Manejo del caso en que el texto no es un número binario válido.
                }
            }*/
        }

        private void txtSegundoOperando_TextChanged(object sender, EventArgs e)
        {

            /*
            if (rdbDecimal.Checked)
            {
                // El RadioButton Decimal está seleccionado, crea una instancia con sistema Decimal.
                if (EsDecimal(txtSegundoOperando.Text))
                {
                    segundoOperando = new Numeracion(txtSegundoOperando.Text, Numeracion.ESistema.Decimal);
                }
                else
                {
                    // Manejo del caso en que el texto no es un número decimal válido.
                }
            }
            else if (rdbBinario.Checked)
            {
                // El RadioButton Binario está seleccionado, crea una instancia con sistema Binario.
                if (EsBinario(txtSegundoOperando.Text))
                {
                    segundoOperando = new Numeracion(txtSegundoOperando.Text, Numeracion.ESistema.Binario);
                }
                else
                {
                    // Manejo del caso en que el texto no es un número binario válido.
                }
            }*/
        }

        private bool EsDecimal(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return false;
            }


            // Utiliza decimal.TryParse para intentar convertir la cadena en un número decimal.
            // Si la conversión es exitosa, es un número decimal válido.
            decimal resultado;
            if (decimal.TryParse(texto, out resultado))
            {
                return true;
            }
            else
            {
                // Si la conversión a decimal no funciona, prueba si lo puede pasar a entero
                int entero;
                if (int.TryParse(texto, out entero))
                {
                    return true;
                }
            }

            return false;
        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOperar.Enabled = true;
        }

        private void FrmCalculadora_Load_1(object sender, EventArgs e)
        {

        }
    }
}
