using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedTransporte.Class
{
    public class Grafo
    {
        float?[,] grafo { get; }
        public int nNodos { get; private set; }

        public Grafo (int nNodos)
        {
            this.nNodos = nNodos;
            this.grafo = new float?[nNodos, nNodos];
        }

        public Grafo (float?[,] grafo)
        {
            this.nNodos = grafo.GetLength(0);
            this.grafo = new float?[nNodos, nNodos];

            for (int f = 0; f < nNodos; f++)
                for (int c = 0; c < nNodos; c++)
                    this.grafo[f, c] = grafo[f, c];
        }

        public void addArco(int inicio,int fin,float? distancia)
        {
            if (inicio < nNodos && fin < nNodos)
                grafo[inicio, fin] = distancia;
            else
                throw new ArgumentOutOfRangeException("Indice fuera de rango");
        }

        public void deleteArco(int inicio, int fin)
        {
            if (inicio < nNodos && fin < nNodos)
                grafo[inicio, fin] = null;
            else
                throw new ArgumentOutOfRangeException("Indice fuera de rango");
        }

        public float? getDistancia(int inicio,int fin)
        {
            if (inicio < nNodos && fin < nNodos)
                return grafo[inicio, fin];
            else
                throw new ArgumentOutOfRangeException("Indice fuera de rango");
        }
    }
}
