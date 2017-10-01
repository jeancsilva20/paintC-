using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PAINT
{
    class Circulo : Ponto
    {
        int raio;

        public int Raio
        {
            get { return raio; }

            set { raio = value; }
        }

        public Circulo(int xCentro, int yCentro, int novoRaio, Color novaCor) :
                base(xCentro, yCentro, novaCor) 
        {
            raio = novoRaio;
        }

        public void setRaio(int novoRaio)
        {
            raio = novoRaio;
        }

        public override void Desenhar(Color corDesenho, Graphics g)
        {
            Pen pen = new Pen(corDesenho);
            g.DrawEllipse(pen, base.X - raio, base.Y - raio,2 * raio, 2 * raio);            
        }

    }
}
