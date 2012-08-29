/* Copyright (C) 2011 rafael1193
*
* This file is part of Buscaminas
*
* Buscaminas is free software: you can redistribute it and/or modify
* it under the terms of the GNU Lesser General Public License as published by
* the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
*
* Buscaminas is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
* GNU Lesser General Public License for more details.
*
* You should have received a copy of the GNU Lesser General Public License
* along with this program. If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BuscaMinas
{
    public partial class Form1 : Form
    {
        MapaMinas mapa;
        bool muerte = false;
        bool ganado = false;

        int MINAS = 10;
        int TAMAÑOX = 15;
        int TAMAÑOY = 15;

        public Form1(int tamañoX, int tamañoY, int minas, string titulo)
        {
            TAMAÑOX = tamañoX;
            TAMAÑOY = tamañoY;
            MINAS = minas;
            Text = titulo;

            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            mapa.DibujarCuadricula(e.Graphics);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int celdaX, celdaY;

            celdaX = (e.X - (int)mapa.Posicion.X) / mapa.AnchoCelda;
            celdaY = (e.Y - (int)mapa.Posicion.Y) / mapa.AltoCelda;

            if (!mapa.Casillas[celdaY, celdaX].Visible)
            {
                muerte = mapa.DestaparCelda(celdaX, celdaY);
            }

            panel1.Invalidate();

            if (muerte)
            {
                mapa.HacerTodoVisible();
                Invalidate();
                MessageBox.Show("¡Has pulsado una mina! :(", "Buscaminas by rafael1193");
                OnLoad(new EventArgs());
            }
            if (TAMAÑOX * TAMAÑOY - MINAS <= mapa.CasillasVistas)
            {
                Invalidate();
                MessageBox.Show("¡Has ganado! :)", "Buscaminas by rafael1193");
                mapa = new MapaMinas(TAMAÑOX, TAMAÑOY, MINAS, new PointF(10, 10));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mapa = new MapaMinas(TAMAÑOX, TAMAÑOY, MINAS, new PointF(10, 10));
            //Width = (mapa.AnchoCelda) * mapa.Ancho + (int)(mapa.Ancho * 1.0) + 2 * (int)mapa.Posicion.X;
            //Height = (mapa.AltoCelda + 2) * mapa.Alto + (int)(mapa.Alto) + 2 * (int)mapa.Posicion.Y; 
            panel1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (minasNumericUpDown.Value < (altoNumericUpDown.Value * anchoNumericUpDown.Value)-1)
            {
                TAMAÑOX = (int)anchoNumericUpDown.Value;
                TAMAÑOY = (int)altoNumericUpDown.Value;
                MINAS = (int)minasNumericUpDown.Value;

                mapa = new MapaMinas(TAMAÑOX, TAMAÑOY, MINAS, new PointF(10, 10));

                panel1.Invalidate();
            }
            else
            {
                MessageBox.Show("¡Debe haber al menos una casilla sin minas!", "Buscaminas by rafael1193");
            }
        }
    }
}
