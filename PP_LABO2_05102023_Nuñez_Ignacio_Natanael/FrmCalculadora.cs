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
        private Calculadora calculadora; // Campo de tipo Calculadora


        public FrmCalculadora()
        {
            InitializeComponent();
            // Crear una instancia de Calculadora y asignarle un nombre y apellido
            calculadora = new Calculadora("Ignacio Natanael y Nuñez");
        }
        private void FrmCalculadora_Load_1(object sender, EventArgs e)
        {
            // Código a ejecutar cuando el formulario se carga.
            cmbOperacion.DataSource = new char[] { '+', '-', '*', '/' };
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancelar el cierre del formulario
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.calculadora.EliminarHistorialDeOperaciones();
            this.txtPrimerOperando.Text = string.Empty;
            this.txtSegundoOperando.Text = string.Empty;
            this.lblResultado.Text = $"Resultado:";
            this.MostrarHistorial();
        }
        private void MostrarHistorial()
        {
            // Establecer el DataSource del ListBox lstHistorial
            lstHistorial.DataSource = null; // Limpia el DataSource existente
            lstHistorial.DataSource = calculadora.Operaciones; // Asigna las operaciones de la calculadora
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;
            calculadora.PrimerOperando = this.GetOperando(this.txtPrimerOperando.Text);
            calculadora.SegundoOperando = this.GetOperando(this.txtSegundoOperando.Text);

            operador = (char)this.cmbOperacion.SelectedItem;
            this.calculadora.Calcular(operador);
            this.calculadora.ActualizarHistorialDeOperaciones(operador);
            // Actualizar el resultado en la etiqueta
            this.lblResultado.Text = $"Resultado: {calculadora.Resultado.Valor}";

            // Mostrar el historial
            this.MostrarHistorial();
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDecimal.Checked)
            {
                rdbDecimal.Checked = true;
                rdbBinario.Checked = false;
            }

            Calculadora.Sistema = ESistema.Binario;
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBinario.Checked)
            {
                rdbBinario.Checked = true;
                rdbDecimal.Checked = false;
            }

            Calculadora.Sistema = ESistema.Decimal;
        }
        private Numeracion GetOperando(string value)
        {
            if (Calculadora.Sistema == ESistema.Binario)
            {
                return new SistemaBinario(value);
            }
            return new SistemaDecimal(value);
        }


        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void lstHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpSistema_Enter(object sender, EventArgs e)
        {

        }

        private void grpSistema_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
