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
using System.Text;

namespace BuscaMinas
{
    struct Celda
    {
        int valor;
        bool visible;

        public Celda(int val, bool vis)
        {
            valor = val;
            visible = vis;
        }

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public bool Visible
        {
            get { return visible; }
            set { visible = value; }
        }


    }
}
