using Sistematico.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistematico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validar que los TextBoxes no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor, ingrese ambos números.");
                return;
            }

            // Intentar convertir los valores a números
            if (double.TryParse(txtNumero1.Text, out double numero1) && double.TryParse(txtNumero2.Text, out double numero2))
            {
                // Obtener la operación seleccionada
                string operacion = cmbOperacion.SelectedItem?.ToString();

                try
                {
                    // Crear una instancia de la clase Calculo
                    Calculo calculo = new Calculo(numero1, numero2);

                    // Realizar la operación y obtener el resultado
                    double resultado = calculo.RealizarOperacion(operacion);

                    // Mostrar el resultado en el Label
                    lblResultado.Text = "Resultado: " + resultado.ToString();
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese números válidos.");
            }
        }

       
    }
}
