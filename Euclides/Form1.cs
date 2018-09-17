using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euclides
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            invertibles();
        }

        private void invertibles()
        {
            if (txtbModulo.Text != "") {

                dgvNumeros.Rows.Clear();

                BigInteger modulo = ToBigInteger(txtbModulo.Text);
                int j = 0;

                for (BigInteger i = 0; i < modulo; i++)
                {

                    Boolean esInverible = Euclides.moduloInverso(modulo, i);

                    if (esInverible)
                        dgvNumeros.Rows.Insert(j, i, Euclides.inv);
                    else
                        dgvNumeros.Rows.Insert(j, i, 0);

                    j++;
                }

            }
            else
                MessageBox.Show("Introduce el modulo");
            
        }

        public BigInteger ToBigInteger(string value)
        {
            BigInteger result = 0;
            for (int i = 0; i < value.Length; i++)
            {
                result = result * 10 + (value[i] - '0');
            }
            return result;
        }

        private void txtbModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                invertibles();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calculadora();
        }

        private void txtbNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                calculadora();
        }

        private void calculadora()
        {
            if (txtbNumero1.Text != "" && txtbNumero2.Text != "")
            {

                BigInteger n1 = ToBigInteger(txtbNumero1.Text);
                BigInteger n2 = ToBigInteger(txtbNumero2.Text);

                txtbResultado.Text = Convert.ToString(n1 % n2);

            }
            else
                MessageBox.Show("Llene los dos valores");
        }
    }
}
