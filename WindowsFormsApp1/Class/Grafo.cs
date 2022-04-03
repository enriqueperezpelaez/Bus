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

        public bool addArco(int inicio,int fin,float? distancia)
        {
            if (inicio < nNodos && fin < nNodos)
                grafo[inicio, fin] = distancia;
            else
                return false;

            return true;
        }

        public bool getDistancia(int inicio,int fin, out float? distancia)
        {
            distancia = null;
            if (inicio < nNodos && fin < nNodos)
                distancia=grafo[inicio, fin];
            else
                return false;

            return true;
        }
    }
}
