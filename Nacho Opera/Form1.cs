using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nacho_Opera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(Numero.Text);
            int hasta = int.Parse(Hasta.Text);
            

            Form2 formulario = new Form2();
            formulario.Show();

            RESULTADO.Items.Clear();
            int resultado;

            for (int i = 1; i <= hasta; i++)
            {
                resultado = numero * i;
                RESULTADO.Items.Add(numero + "x" + i + "=" + resultado);
            }
        }
    }

 }

