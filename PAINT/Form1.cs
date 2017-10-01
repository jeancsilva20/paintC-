using PAINT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PAINT
{
    public partial class Form1 : Form
    {
        private ListaSimples<Ponto> figuras = new ListaSimples<Ponto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
                if (dlgAbrir.ShowDialog() == DialogResult.OK)
                {
                    figuras.AbrirArquivo(dlgAbrir.FileName);              
                }         
        }

        private void pbAreaDesenho_Click(object sender, EventArgs e)
        {

        }

        private void pbAreaDesenho_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;    // acessa contexto gráfico
            //Ponto p = new Ponto(45, 45, Color.Red);

            //p.Desenhar(Color.Red, g);
      

            figuras.percorrer();
            while (figuras.EstaVazia)
            {
                Ponto figuraAtual = figuras.Atual.Info;
                figuraAtual.Desenhar(figuraAtual.Cor, g);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pbAreaDesenho.BackColor = colorDialog1.Color;
            }
        }
    }
}
