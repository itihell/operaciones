﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Operaciones:Utilidades
    {
        int numeroUno;
        int numeroDos;
        int resultado;

        public int NumeroUno {
            get => numeroUno;
            set => numeroUno = value;
        } 
        
        public int NumeroDos {
            get => numeroDos;
            set => numeroDos = value;
        } 
        public int Resultado {
            get => resultado;
            set => resultado = value;
        }

        public void Init(string mensaje)
        {
            Console.WriteLine(mensaje);
            NumeroUno = leerNumeroYAsignar("Entre el primer número");
            NumeroDos = leerNumeroYAsignar("Entre el segundo número");           
        }


        public void darSalida(int suma)
        {
            Console.WriteLine("El resultado es: " + suma);
            Console.ReadKey();
        }


        public int operacion(int a, int b)
        {
            return 0;
        }

    }
}
