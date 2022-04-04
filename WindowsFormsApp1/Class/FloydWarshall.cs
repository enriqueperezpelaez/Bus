using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedTransporte.Class
{
    public class FloydWarshall
    {
        Grafo grafo { get; }
        float?[,] distancias { get; }
        int?[,] antecesores;
        int nNodos { get; }

        public FloydWarshall(Grafo grafo)
        {
            this.grafo = grafo;
            this.nNodos = grafo.nNodos;
            distancias = new float?[nNodos, nNodos];
            antecesores = new int?[nNodos, nNodos];

            float? distancia;
            for (int f = 0; f < nNodos; f++)
                for (int c = 0; c < nNodos; c++)
                {
                    distancia = grafo.getDistancia(f, c);
                    distancias[f, c] = distancia;
                        if (distancia.HasValue) antecesores[f, c] = f;
                }

            calcFloydWarshall();
        }

        private void calcFloydWarshall()
        {
            float d1, d2;
            for (int k = 0; k < nNodos; k++)
                for (int i = 0; i < nNodos; i++)
                    for (int j = 0; j < nNodos; j++)
                    {
                        if (distancias[i, k].HasValue && distancias[k, j].HasValue)
                        {
                            d1 = distancias[i, j] ?? float.MaxValue;
                            d2 = distancias[i, k].Value + distancias[k, j].Value;
                            if (d2 < d1)
                            {
                                distancias[i, j] = d2;
                                antecesores[i, j] = antecesores[k, j];
                            }
                        }
                    }
        }

        public List<int> getRuta(int inicio, int fin)
        {
            List<int> ruta = new List<int>() { fin };
            int? antecesor = antecesores[inicio, fin];
            while (antecesor != inicio && antecesor.HasValue)
            {
                ruta.Add(antecesor.Value);
                antecesor = antecesores[inicio, antecesor.Value];
            }

            if (antecesor.HasValue)
            {
                ruta.Add(inicio);
                ruta.Reverse();
            }
            else
                ruta = null;

            return ruta;
        }

        public float? getDistanciaMenor(int inicio, int fin)
        {
            if (inicio < nNodos && fin < nNodos)
                return distancias[inicio, fin];
            else
                return null;
        }
    }
}
