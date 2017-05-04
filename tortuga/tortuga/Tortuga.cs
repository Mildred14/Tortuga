using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tortuga
{
    class Tortuga
    {
        //Se declara las variables necesarias y la matriz
        private string vCadena;
        private int[,] _matriz1;
        // "i" y "j" serán las variables de la matriz
        private int i,j;
        private int k;
        //IMPORTANTE! presta atención a tus principales atributos
        private bool derecha = false, izquiera = false, arriba = false, abajo = false;
        //Vamos a inicializar nuestra matriz
        public Tortuga()
        {
            _matriz1 = new int[20, 20];
        }
        //Iniciamos con la primer función, AVANZAR
        public void avanzar(int aux)
        {
           //Si la pluma está abajo vamos a empezar a llenar los vectores que va recorriendo
            if (abajo == true)
            {
                for (k = 0; k < aux; k++)
                {
                    _matriz1[i, j] = 1;
                    i++;
                }
            }
            //Si la pluma está arriba vamos a empezar a llenar los vectores que va recorriendo
            if (arriba == true)
            {
                for (k = 0; k < aux; k++)
                {
                    _matriz1[i, j] = 1;

                    i--;
                }
            }
            //Si la tortuga va hacia la derecha vamos a empezar a llenar los vectores que va recorriendo
            if (derecha == true)
            {
                for (k = 0; k < aux; k++)
                {


                    _matriz1[i-1, j+1] = 1;
                    j++;
                }
            }
            //Si la tortuga se dirge a la izquiera vamos a empezar a llenar los vectores que va recorriendo
            if (izquiera == true)
            {
                for (k = 0; k < aux; k++)
                {
                    _matriz1[i-1, j-1] = 1;
                    j--;
                }
            }
        }
        //Se va a girar a la izquiera cuando esté activado solo el de la izquierda
        public void girarIzquierda()
        {
            izquiera = true;
            derecha = false;
            abajo = false;
            arriba = false;

        }
        //Se va a girar a la derecha cuando esté activado solo el de la derecha
        public void girarDerecha()
        {
            izquiera = false;
            derecha = true;
            abajo = false;
            arriba = false;
        }
        //Se va a poner la pluma arriba cuando esté activado solo el de arriba
        public void plumaArriba()
        {
            izquiera = false;
            derecha = false;
            abajo = false;
            arriba = true;
        }
        //Se va a poner la pluma abajo cuando esté activado solo el de abajo
        public void plumaAbajo()
        {
            izquiera = false;
            derecha = false;
            abajo = true;
            arriba = false;

        }
        //Para mostrar los vectores que se encuentran dentro de la matriz, se va a imprimir en cada uno un "*"
        public string tablero() { 
        vCadena = "";
           for (int i = 0; i<20; i++)
                {
             
                for (int j = 0; j<20; j++)
                    {

                    vCadena += "*"+ " ";
                    }
      vCadena += Environment.NewLine;
                }
      vCadena += "\n\n";
            return vCadena;
        }
        //Aquí se va a mostrar el camino que lleve la tortuga :D!
        public string mostrar()
        {
            vCadena = "l";
            for (int i = 0; i < 20; i++)
            {

                for (int j = 0; j < 20; j++)
                {

                    vCadena += _matriz1[i, j].ToString() + " ";
                }
                vCadena += Environment.NewLine;
            }
            vCadena += "\n\n";
            return vCadena;
        }
    }
}
