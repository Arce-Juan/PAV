using ExpresionesLambda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegadosYEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            int numeroA = 10, numeroB = 0;
            var controller = new Controlador();
            controller.MiDelegado = ReportarResultados;
            var resultado = controller.Dividir(numeroA, numeroB);
        }

        private void ReportarResultados(int numeroA, int numeroB)
        {
            MessageBox.Show($"No se puede realizar la division entre {numeroA} y {numeroB}");
        }

        private void Btn_Evento_Click(object sender, EventArgs e)
        {
            int numero1 = 10, numero2 = 2;
            var evento = new MisEventos();
            evento.EventoDivisionPorCero += Evento_EventoDivisionPorCero;
            decimal resultado = evento.Division(numero1, numero2);
            MessageBox.Show($"El resultado de la division entre {numero1} y {numero2} es: {resultado}");
        }

        private void Evento_EventoDivisionPorCero(object objeto, EventArgs e)
        {
            MessageBox.Show("Se disparo una excepcion por Division Por Cero!!..");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int numero1 = 10, numero2 = 0;
            var evento = new MisEventos();
            evento.EventoDivisionPorCeroConRetorno += Evento_EventoDivisionPorCeroConRetorno;
            decimal resultado = evento.DivisionConRetorno(numero1, numero2);
            MessageBox.Show($"El resultado de la division con retorno de parametros, entre {numero1} y {numero2} es: {resultado}");
        }

        private void Evento_EventoDivisionPorCeroConRetorno(object objeto, MisEventos.DivisionPorCeroConRetornoEventArg e)
        {
            MessageBox.Show($"Error: {e.mensaje} // Numeros: {e.numeroX} y {e.numeroY}");
        }
    }
}
