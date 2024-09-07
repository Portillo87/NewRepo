using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double numero1, numero2, resultado;
        string operacionsSelecionada = "";

        private bool ValidarEntrada()
        {   //Verifica si los TexBox están vacios
            if (string.IsNullOrWhiteSpace(txtNum1.Text) || string.IsNullOrWhiteSpace(txtNum2.Text))
            {
                MessageBox.Show("Por favor, ingrese valores en ambos campos.");
                return false;
            }

            //Verifica si valores ingresados son números
            if (!double.TryParse(txtNum1.Text, out numero1) || !double.TryParse(txtNum2.Text, out numero2 ))
            {
                MessageBox.Show("Por favor, ingrese valores en ambos campos.");
                return false;
            }
            return true;
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            operacionsSelecionada = "Sumar";
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            operacionsSelecionada = "Restar";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operacionsSelecionada = "Multiplicar";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operacionsSelecionada = "Dividir";
        }

        

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (!ValidarEntrada()) return;


            switch (operacionsSelecionada)
            {
                case "Sumar":
                    resultado = numero1 + numero2;
                    break;

                case "Restar":
                    resultado = numero1 - numero2;
                    break;

                case "Multiplicar":
                    resultado = numero1 * numero2;
                    break;

                case "Dividir":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir entre cero.");
                        return;
                    }
                    break;

                default:
                    MessageBox.Show("Por favor, seleciona una opereación");    
                    return;
            }

            txtResultado.Text = resultado.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text  = "";
        }
    }
}
