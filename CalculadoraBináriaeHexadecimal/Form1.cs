using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBináriaeHexadecimal
{
    public partial class Form1 : Form
    {
        int x, y, resposta;

        bool telinha;
        string operate;
        string operate2;

        public Form1()
        {
            InitializeComponent();
        }

        private void zero_Button(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                numero.Text = numero.Text + "0";

                telinha = false;
            }
            else if (telinha == false)
            {
                numero.Text = numero.Text + "0";

            }
        }

        private void um_Button(object sender, EventArgs e)
        {
            if (telinha == true)
            {

                numero.Text = numero.Text + "1";

                telinha = false;
            }
            else if (telinha == false)
            {
                numero.Text = numero.Text + "1";

            }
        }

        private void toDecimal(object sender, EventArgs e)
        {
            caixaresultado.Text = Convert.ToInt64(numero.Text, 2).ToString();
        }

        private void toHexa(object sender, EventArgs e)
        {
            string foda = Convert.ToInt64(numero.Text, 2).ToString();
            int decValue = Convert.ToInt32(foda);
            string HexValue = decValue.ToString("X");
            caixaresultado.Text = HexValue;
        }

        private void soma(object sender, EventArgs e)
        {
            operate = "+";
            x = Convert.ToInt32(numero.Text, 2);
            numero.Clear();
        }

        private void subtracao(object sender, EventArgs e)
        {
            operate = "-";
            x = Convert.ToInt32(numero.Text, 2);
            numero.Clear();
        }

        private void multiplicacao(object sender, EventArgs e)
        {
            operate = "*";
            x = Convert.ToInt32(numero.Text, 2);
            numero.Clear();
        }

        private void divisao(object sender, EventArgs e)
        {
            operate = "/";
            x = Convert.ToInt32(numero.Text, 2);
            numero.Clear();
        }

        private void igual(object sender, EventArgs e)
        {
            y = Convert.ToInt32(numero.Text, 2);
            switch (operate)
            {
                case "+":
                    resposta = x + y;

                    break;

                case "-":
                    resposta = x - y;
                    break;

                case "*":
                    resposta = x * y;
                    break;

                case "/":
                    resposta = x / 2;
                    break;
            }


            int decimalNumber = int.Parse(resposta.ToString());
            int remainder;
            string resposta2 = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                resposta2 = remainder.ToString() + resposta2;
            }
            nadanada.Text = resposta2;
        }

        private void delete(object sender, EventArgs e)
        {
            int tamanho = numero.Text.Length - 1;
            if (tamanho >= 0)
            {
                numero.Text = numero.Text.Substring(0, tamanho);
            }
            caixaresultado.Text = "";
        }

        private void c_Button(object sender, EventArgs e)
        {
            numero.Text = "";
            caixaresultado.Text = "";
            x = 0;
            y = 0;
        }
    }
}
