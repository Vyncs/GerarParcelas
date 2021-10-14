using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerarParcelas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Parcela
        {
            public int numeroParcela { get; set; }
            public double Valor { get; set; }
        }

        private void CalculaParcelas(int qtdeParcela)
        {
            double valorTotal = Convert.ToDouble(txtValor.Text);
            int totalParcelas = qtdeParcela;
            int contador = 0;
            List<Parcela> lista = new List<Parcela>();
            for (int i = 0; i < totalParcelas; i++)
            {
                contador++;
                var parcela = new Parcela();
                double Valora = Math.Round(valorTotal / qtdeParcela);
                double valorDiferenca = valorTotal - Valora * qtdeParcela;
                string valorb = !(i + 1 == qtdeParcela) ? Valora.ToString() : (Valora + valorDiferenca).ToString();

                parcela.Valor = Convert.ToDouble(valorb);
                parcela.numeroParcela = contador;

                lista.Add(parcela);
            }
            dgvParcelas.AutoGenerateColumns = false;
            dgvParcelas.DataSource = null;
            dgvParcelas.DataSource = lista;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string escolha = cbbParcelas.SelectedItem.ToString();
            switch (escolha)
            {

                case "1x":
                    CalculaParcelas(1);
                    break;
                case "2x":
                    CalculaParcelas(2);
                    break;
                case "3x":
                    CalculaParcelas(3);
                    break;
                case "4x":
                    CalculaParcelas(4);
                    break;
                case "5x":
                    CalculaParcelas(5);
                    break;
                case "6x":
                    CalculaParcelas(6);
                    break;
                case "7x":
                    CalculaParcelas(7);
                    break;
                case "8x":
                    CalculaParcelas(8);
                    break;
                case "9x":
                    CalculaParcelas(9);
                    break;
                case "10x":
                    CalculaParcelas(10);
                    break;
                case "11x":
                    CalculaParcelas(11);
                    break;
                case "12x":
                    CalculaParcelas(12);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
