    using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion2ColaEstaticaPrioridad
{
    class ColaPrioridad
    {
        public string[][] MatrizEscalonada = new string[3][];
        public int[] Tails = new int[3];

        public ColaPrioridad(int Maximo)
        {
            MatrizEscalonada[0] = new string[Maximo]; //Prioridad 0
            MatrizEscalonada[1] = new string[Maximo]; //Prioridad 1   
            MatrizEscalonada[2] = new string[Maximo]; //Prioridad 2
            Tails[0] = -1;
            Tails[1] = -1;
            Tails[2] = -1;
        }

        public void Encolar(int Prioridad, string dato)
        {
            if(dato == "")
            {
                return;
            }
            int tailActual = Tails[Prioridad];
           
                if(tailActual == MatrizEscalonada[Prioridad].Length - 1)
                {
                    return;
                }
                if (tailActual  == -1)
                { 
                    MatrizEscalonada[Prioridad][0] = dato;
                Tails[Prioridad] = Tails[Prioridad] + 1;
                    return;
                }
                else
                {
                tailActual++;
                Tails[Prioridad] = Tails[Prioridad] + 1;
                MatrizEscalonada[Prioridad][tailActual] = dato;
                return;
                }
        }
        public void Desencolar()
        {
            int tailActual = Tails[0];
            if (tailActual > -1)
            {
                Eliminar(0);
                return;
            }
            tailActual = Tails[1];
            if (tailActual > -1)
            {
                Eliminar(1);
                return;
            }
            tailActual = Tails[2];
            if (tailActual > -1)
            {
                Eliminar(2);
                return;
            }
        }
        public void Eliminar(int Prioridad)
        {
            int tailActual = Tails[Prioridad];
            if (tailActual == 0)
            {
                MatrizEscalonada[Prioridad][0] = null;
                Tails[Prioridad]--;
                return;
            }
            else
            {
                MatrizEscalonada[Prioridad][0] = null;
                for (int i = 0; i < tailActual; i++)
                {
                    MatrizEscalonada[Prioridad][i] = MatrizEscalonada[Prioridad][i + 1];
                }
                Tails[Prioridad]--;
            }
        }
        public void IncrementarPrioridad()
        {
            int FinalActual = Tails[2];
            if (FinalActual > -1)
            {
                string dato = MatrizEscalonada[2][0];
                Eliminar(2);
                Encolar(1, dato);
            }
            FinalActual = Tails[1];
            if (FinalActual > -1)
            {
                string dato = MatrizEscalonada[1][0];
                Eliminar(1);
                Encolar(0, dato);
            }
        }
        public string Imprimir(int prioridad)
        {
            int FinalActual = Tails[prioridad];
            if (FinalActual == -1)
            {
                return "La cola esta vacia";
            }
            else
            {
                string colaString = "";
                colaString += MatrizEscalonada[prioridad][0];
                for (int i = 0; i < FinalActual ; i++)
                {
                    colaString += "," + MatrizEscalonada[prioridad][i + 1];
                }
                return colaString;
            }
        }

        public int Uhh(int prioridad)
        {

            return Tails[prioridad];
        }
      
    }
}
