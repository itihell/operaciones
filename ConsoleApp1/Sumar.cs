﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sumar:Operaciones
    {
        public void Iniciar()
        {
            Init("Vamos a sumar dos números");
            Resultado = operacion(NumeroUno, NumeroDos);
            darSalida(Resultado);
        }

        static int operacion(int a, int b)
        {

            return a+ b;
        }
    }
}
