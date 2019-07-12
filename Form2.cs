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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(String texto1, String texto2, String texto3, String texto4)
        {
            InitializeComponent();
            label1.Text = texto1;
            label2.Text = texto2;
            label3.Text = texto3;
            label4.Text = texto4;
        }
    }
}
