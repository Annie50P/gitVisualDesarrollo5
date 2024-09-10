using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//GRUPO 1GS122: ANA PATRICIA APARICIO, BRUNO FERREIRA, CÉSAR BAZÁN

namespace AnaPatriciaAparicio_Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void labelTítulo_Click(object sender, EventArgs e)
        {

        }

        private void labelSalario_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void textSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCédula_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCédula_Click(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSalario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textCédula_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textCédula_KeyPress(object sender, KeyPressEventArgs e)
        {

        }


        private void textSalario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void botonCalcular(object sender, EventArgs e)
        {
            // Cálculos
            double salarioBrutoMensual, cantidadPagoSeguroSocial, cantidadPagoSeguroEducativo, salarioMensualNeto;
            double porcentajeSeguroSocial = 9.75 / 100;
            double porcentajeSeguroEducativo = 1.25 / 100;
            double tarifaFija = 5850.00;
            double impuesto = 0;  
            double salarioBrutoAnual;
            double excedente = 0; 
            double isr = 80; 

            salarioBrutoMensual = Convert.ToDouble(textSalario.Text);

            cantidadPagoSeguroSocial = porcentajeSeguroSocial * salarioBrutoMensual;
            cantidadPagoSeguroEducativo = porcentajeSeguroEducativo * salarioBrutoMensual;
            salarioMensualNeto = salarioBrutoMensual - cantidadPagoSeguroEducativo - cantidadPagoSeguroSocial;
            salarioBrutoAnual = salarioBrutoMensual * 13;

            if (salarioBrutoAnual <= 11000)
            {
                impuesto = 0;
            }
            else if (salarioBrutoAnual > 11000 && salarioBrutoAnual <= 50000)
            {
                excedente = (salarioBrutoAnual - 11000);
                impuesto = excedente * 0.15;
                
            }
            else if (salarioBrutoAnual > 50000)
            {
                excedente = (salarioBrutoAnual - 50000);
                impuesto = 5850.00 + (excedente * 0.25);
                
            }
            

            isr = (impuesto / 13);
            salarioMensualNeto = salarioMensualNeto - isr;
           
            Form2 form2 = new Form2();
            AddOwnedForm(form2);
            
            form2.lbNombre.Text = this.textNombre.Text;
            form2.lbCédula.Text = this.textCédula.Text;
            form2.lbResultadoSeguroEducativo.Text = cantidadPagoSeguroEducativo.ToString("C2");
            form2.lbResultadoPagoSeguroSocial.Text = cantidadPagoSeguroSocial.ToString("C2");
            form2.lbResultadoSalarioNetoMensual.Text = salarioMensualNeto.ToString("C2");
            form2.lbISR.Text = isr.ToString("C2");
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //HOLA JAJAJAJA 
        }
    }
}
