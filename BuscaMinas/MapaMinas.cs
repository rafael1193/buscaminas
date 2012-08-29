using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace BuscaMinas
{
    class MapaMinas
    {
        Celda[,] mapa;
        //9 >= mina. 1,2,3,4,5,6,7,8 = minas adyacentes. 0 = casilla vacía y sin minas adyacentes.
        int nMinas;

        int casillasVistas = 0;

        int ancho;
        int alto;

        bool primerclick = true;

        PointF posicion;
        int anchoCelda = 20;
        int altoCelda = 20;

        internal MapaMinas(int ancho, int alto, int numeroMinas, PointF posicion)
        {
            mapa = new Celda[alto, ancho];
            nMinas = numeroMinas;
            if (nMinas >= mapa.Length)
                throw new ArgumentOutOfRangeException("Debe haber al menos una casilla libre de minas");
            this.posicion = posicion;

            this.ancho = mapa.GetLength(1);
            this.alto = mapa.GetLength(0);
        }

        internal void DibujarCuadricula(System.Drawing.Graphics g)
        {
            Pen lapizRojo = new Pen(Color.Red, 1.0f);
            Pen lapizAzul = new Pen(Color.Blue, 1.0f);
            Pen lapizNegro = new Pen(Color.Black, 1.0f);
            Pen lapiz = lapizNegro;

            Brush brushMina = Brushes.Red;
            Brush brush = Brushes.DarkGray;
            Brush brushTexto = Brushes.Black;

            //Casillas
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    if (mapa[i, j].Visible == true)
                    {
                        int valor = mapa[i, j].Valor;

                        lapiz = lapizAzul;
                        switch (valor)
                        {
                            case 0:
                                break;
                            case 9:
                                g.FillRectangle(brushMina, j * anchoCelda + posicion.X, i * altoCelda + posicion.Y, anchoCelda, altoCelda);
                                break;
                            default:
                                g.DrawString(valor.ToString(), new Font("Arial", 13), brushTexto, j * anchoCelda + posicion.X, i * altoCelda + posicion.Y);
                                break;
                        }
                    }
                    else
                    {
                        g.FillRectangle(brush, j * anchoCelda + posicion.X, i * altoCelda + posicion.Y, anchoCelda, altoCelda);
                    }
                }
            }

            //lineas horizontales
            for (int i = 0; i <= alto; i++)
            {
                g.DrawLine(lapizNegro, posicion.X, altoCelda * i + posicion.Y, anchoCelda * ancho + posicion.X, altoCelda * i + posicion.Y);
            }

            //lineas verticales
            for (int i = 0; i <= ancho; i++)
            {
                g.DrawLine(lapizNegro, anchoCelda * i + posicion.X, posicion.Y, anchoCelda * i + posicion.X, altoCelda * alto + posicion.Y);
            }
        }

        private void ColocarMinas(int xInicial, int yInicial)
        {
            //Obtener aleatoriamente un conjunto de minas
            Point[] puntosMinas = new Point[nMinas];
            Random r = new Random();

            Point puntoIn = new Point(xInicial, yInicial);

            for (int i = 0; i < nMinas; i++)
            {
                Point p = new Point();

                do
                {
                    p.X = r.Next(0, mapa.GetLength(1));
                    p.Y = r.Next(0, mapa.GetLength(0));
                } while (Contiene(puntosMinas, p) ^ p == puntoIn);

                puntosMinas[i] = p;
            }


            //Colocar los valores en el mapa
            for (int i = 0; i < puntosMinas.Length; i++)
            {
                mapa[puntosMinas[i].Y, puntosMinas[i].X].Valor = 9; //9 = ID mina

                if (puntosMinas[i].Y + 1 < alto)//abajo
                    if (mapa[puntosMinas[i].Y + 1, puntosMinas[i].X].Valor < 9)
                        mapa[puntosMinas[i].Y + 1, puntosMinas[i].X].Valor++;

                if (puntosMinas[i].X + 1 < ancho)//derecha
                    if (mapa[puntosMinas[i].Y, puntosMinas[i].X + 1].Valor < 9)
                        mapa[puntosMinas[i].Y, puntosMinas[i].X + 1].Valor++;

                if (puntosMinas[i].Y - 1 >= 0)//arriba
                    if (mapa[puntosMinas[i].Y - 1, puntosMinas[i].X].Valor < 9)
                        mapa[puntosMinas[i].Y - 1, puntosMinas[i].X].Valor++;

                if (puntosMinas[i].X - 1 >= 0)//izquierda
                    if (mapa[puntosMinas[i].Y, puntosMinas[i].X - 1].Valor < 9)
                        mapa[puntosMinas[i].Y, puntosMinas[i].X - 1].Valor++;

                if (puntosMinas[i].Y + 1 < alto && puntosMinas[i].X + 1 < ancho)//abajo-derecha
                    if (mapa[puntosMinas[i].Y + 1, puntosMinas[i].X + 1].Valor < 9)
                        mapa[puntosMinas[i].Y + 1, puntosMinas[i].X + 1].Valor++;

                if (puntosMinas[i].Y + 1 < alto && puntosMinas[i].X - 1 >= 0)//abajo-izquierda
                    if (mapa[puntosMinas[i].Y + 1, puntosMinas[i].X - 1].Valor < 9)
                        mapa[puntosMinas[i].Y + 1, puntosMinas[i].X - 1].Valor++;

                if (puntosMinas[i].Y - 1 >= 0 && puntosMinas[i].X - 1 >= 0)//arriba-izquierda
                    if (mapa[puntosMinas[i].Y - 1, puntosMinas[i].X - 1].Valor < 9)
                        mapa[puntosMinas[i].Y - 1, puntosMinas[i].X - 1].Valor++;

                if (puntosMinas[i].Y - 1 >= 0 && puntosMinas[i].X + 1 < ancho)//arriba-derecha
                    if (mapa[puntosMinas[i].Y - 1, puntosMinas[i].X + 1].Valor < 9)
                        mapa[puntosMinas[i].Y - 1, puntosMinas[i].X + 1].Valor++;
            }

            //Ya está listo el tablero :)

        }

        private bool Contiene(Point[] conjunto, Point elemento)
        {
            for (int i = 0; i < conjunto.Length; i++)
            {
                if (conjunto[i].X == elemento.X && conjunto[i].Y == elemento.Y)
                    return true;
            }

            return false;
        }

        internal bool DestaparCelda(int x, int y)
        {
            if (primerclick)
            {
                ColocarMinas(x, y);
                primerclick = false;
            }

            if (x < ancho && y < alto && x >= 0 && y >= 0 && mapa[y, x].Visible == false)
            {
                if (mapa[y, x].Valor >= 9)
                {
                    casillasVistas++;
                    return true;
                }

                DescubrirArea(x, y);

                casillasVistas=0;

                for (int i = 0; i < alto; i++)
                {
                    for (int j = 0; j < ancho; j++)
                    {
                        if (mapa[i, j].Visible == true)
                        {
                            casillasVistas++;
                        }
                    }
                }
                //mapa[y, x].Visible = true;

            }
            return false;
        }

        private void DescubrirArea(int x, int y)
        {
            //Si la casilla esta tapada
            if (mapa[y, x].Visible == false)
            {
                //Descubre la casilla
                mapa[y, x].Visible = true;
                //casillasVistas++;

                //Si no hay minas cercanas
                if (mapa[y, x].Valor == 0)
                {
                    //Recorre las casillas cercanas y tambien las ejecuta
                    for (int f2 = Math.Max(0, x - 1); f2 < Math.Min(ancho, x + 2); f2++)
                    {
                        for (int c2 = Math.Max(0, y - 1); c2 < Math.Min(alto, y + 2); c2++)
                        {
                            DescubrirArea(f2, c2);
                        }
                    }
                }
            }
        }

        internal void HacerTodoVisible()
        {
            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    mapa[i, j].Visible = true;
                }
            }
        }

        internal Celda[,] Casillas
        {
            get { return mapa; }
        }

        internal PointF Posicion
        {
            get { return posicion; }
        }

        internal int AnchoCelda
        {
            get { return anchoCelda; }
        }

        internal int AltoCelda
        {
            get { return altoCelda; }
        }

        internal int Ancho
        {
            get { return ancho; }
        }

        internal int Alto
        {
            get { return alto; }
        }

        internal int CasillasVistas
        {
            get { return casillasVistas; }
        }
    }
}
