﻿/* Copyright (C) 2011 rafael1193
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
using System.Windows.Forms;

namespace BuscaMinas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool facil = true;
            //facil=!facil;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (facil)
            {
                Application.Run(new Form1(9, 9, 10, "minesweeper by rafael1193"));
            }
            else 
            {
                Application.Run(new Form1(20, 20, 160,"Buscaminas (dificil) by rafael1193"));
            }
        }
    }
}
