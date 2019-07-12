using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaVetores
{
    public partial class VetorInteiro : Form
    {
        public object TextBox1 { get; private set; }

        public VetorInteiro()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Declarar
            String[] vetor2;

            // Instanciar
            vetor2 = new string[4];
            
            // Armazenar
            vetor2[1] = txt1.Text;
            vetor2[2] = txt2.Text;
            vetor2[3] = txt3.Text;
            vetor2[0] = txt4.Text;

            // Instanciar form2 para mostrar os valores
            var Formulario = new Form2(txt1.Text, txt2.Text, txt3.Text, txt4.Text);

            // mostrar o Form2 com os valores
            Formulario.Show();


        }

    }

}