using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Click.Click += MostrarMensaje;
            btn_Click.Click += (object sender1, EventArgs e1) =>
            {
                MessageBox.Show("Mensaje desde expresion lambda: me cliqueaste!");
            };
            button1.Click += MostrarMensajeConNombreDeBoton;
            button2.Click += MostrarMensajeConNombreDeBoton;
            button3.Click += MostrarMensajeConNombreDeBoton;
        }

        public void MostrarMensaje(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje desde Metodo: me cliqueaste!");
        }

        public void MostrarMensajeConNombreDeBoton(object sender, EventArgs e)
        {
            var button = sender as Button;
            MessageBox.Show("Cliqueaste el " + button.Text);
        }

    }
}
