using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaDeCompras
{
    public partial class Form1 : Form
    {
        public class produto 
        {
            public String nome;
            public double preco;
        }

        List<produto> LISTA_PRODUTOS;
        List<produto> LISTA_COMPRAS;


        public Form1()
        {
            InitializeComponent();
            IniciarCompras();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LISTA_PRODUTOS = new List<produto>() {
            new produto() { nome = "Laranja", preco = 1.99 },
            new produto() { nome = "Banana", preco = 3.99 },
            new produto() { nome = "Pêssego", preco = 5.99 },
            new produto() { nome = "Melancia", preco = 6.99 },
            new produto() { nome = "Morango", preco = 4.99 }
            };

            foreach ( produto p in LISTA_PRODUTOS)
            {
                lista_produtos.Items.Add(Construir(p));
            }
            
        }
        public String Construir(produto p)
        {
            String preco = p.preco.ToString("0.00 " + "$");
            return p.nome + new string('-', 10 - p.nome.Length + preco.Length) + preco;
        }
        private void IniciarCompras()
        {
            LISTA_COMPRAS = new List<produto>();
            lista_compras.Items.Clear();
            label_total.Text = "0.00$";
        }

        private void lista_produtos_DoubleClick(object sender, EventArgs e)
        {
            if (lista_produtos.SelectedIndex == -1) return;
            produto p = LISTA_PRODUTOS[lista_produtos.SelectedIndex];
            AdicionarProduto(p);
        }
        private void AdicionarProduto(produto p)
        {
            LISTA_COMPRAS.Add(p);
            lista_compras.Items.Add(Construir(p));

            var total = LISTA_COMPRAS.Sum(i => i.preco);
            label_total.Text = total.ToString("0.00") + "$";
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra Finalizada!!!");
            IniciarCompras();
           
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            IniciarCompras();
        }
    }
}
