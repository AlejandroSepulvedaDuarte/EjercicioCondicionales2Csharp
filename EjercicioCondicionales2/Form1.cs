using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioCondicionales2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Se requiere calcular  el salario de un empleado basados en las horas trabajadas
         y el valor de cada hora. tenga en cuenta que si el salario base calculado es superior
         al 1000000 deberá descontar  el 4% de la salud. De lo contrario deberá incrementarle 
         al salario base el 2%; mostrar el salario base, descuentos salud, incremento y salario final*/

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double horasTrabajadas;
            double valorHora;
            double salarioBase;
            double salud;
            double incremento;
            double salarioApagar;

            horasTrabajadas = double.Parse(txtHorasTrabajadas.Text);
            valorHora = double.Parse(txtValorHora.Text);

            salarioBase = horasTrabajadas * valorHora;

            switch (cmbEmpleadoAdmin.SelectedItem)
            {
                case "No":
                    if (salarioBase > 1000000)
                    {
                        salud = salarioBase * 0.04;
                        incremento = 0;

                    }
                    else
                    {
                        salud = salarioBase * 0;
                        incremento = salarioBase * 0.02;
                    }
                    salarioApagar = salarioBase - salud + incremento;
                    lblSalariobase.Text = Convert.ToString("$" + String.Format("{0:n0}", salarioBase));
                    lblSalud.Text = Convert.ToString("$" + String.Format("{0:n0}", salud));
                    lbl_incremento.Text = Convert.ToString("$" + String.Format("{0:n0}", incremento));
                    lblSalarioNeto.Text = Convert.ToString("$" + String.Format("{0:n0}", salarioApagar));
                    break;

                case "Si":
                    if (salarioBase > 1000000)
                    {
                        salud = salarioBase * 0.08;
                        incremento = 0;

                    }
                    else
                    {
                        salud = salarioBase * 0;
                        incremento = salarioBase * 0.01;
                    }
                    salarioApagar = salarioBase - salud + incremento;
                    lblSalariobase.Text = Convert.ToString("$" + String.Format("{0:n0}", salarioBase));
                    lblSalud.Text = Convert.ToString("$" + String.Format("{0:n0}", salud));
                    lbl_incremento.Text = Convert.ToString("$" + String.Format("{0:n0}", incremento));
                    lblSalarioNeto.Text = Convert.ToString("$" + String.Format("{0:n0}", salarioApagar));
                    break;
            }

           
            

            
            gbResumenPago.Visible = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtHorasTrabajadas.Text = String.Empty;
            txtValorHora.Text = String.Empty;   
            gbResumenPago.Visible= false; 
            txtHorasTrabajadas.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEmpleadoAdmin.SelectedIndex = 0;
        }
    }
}
