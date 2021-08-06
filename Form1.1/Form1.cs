using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1._1
{
    public partial class Calculo : Form
    {
        Somando s = new Somando();
        public Calculo()
        {
            InitializeComponent();
        }

        private void bntcalcular_Click(object sender, EventArgs e)
        {
            s.Numero = int.Parse(textValor1.Text);
            s.Numero1 = int.Parse(textValor2.Text);
            textResultado.Text = s.Soma().ToString();
        }
    }
}
