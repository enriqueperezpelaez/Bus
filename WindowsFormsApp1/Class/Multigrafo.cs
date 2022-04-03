using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedTransporte.Class
{
    public class Multigrafo
    {
        public class Arco
        {
            public float? distancia { get; private set; }
            public bool prioritario { get; private set; }

            public Arco(float? distancia, bool prioritario = false)
            {
                this.distancia = distancia;
                this.prioritario = prioritario;
            }
            public void setDistancia(float? distancia) { this.distancia = distancia; }
            public void setPrioritario(bool pordefecto=true) { this.prioritario = prioritario; }
        }

        List<Arco>[,] multigrafo { get; }
        int nNodos { get; }

        public Multigrafo(int n,bool bucle=false)
        {
            nNodos = n;
            multigrafo = new List<Arco>[n, n];
            if (!bucle)
            {
                for (int i = 0; i < nNodos; i++)
                    this.addArco(i, i, 0);
            }
        }

        public bool addArco (int inicio, int fin, float distancia, bool prioritario = false)
        {
            if (inicio < nNodos && fin < nNodos)
            {
                Arco arco = new Arco(distancia, prioritario);
                if (multigrafo[inicio, fin] == null)
                    multigrafo[inicio, fin] = new List<Arco>() { arco };
                else
                {
                    if (prioritario) multigrafo[inicio, fin].ForEach(a => a.setPrioritario(false));
                    multigrafo[inicio, fin].Add(arco);
                }
                return true;
            }
            else
                return false;
        }
        public bool deleteArco (int inicio, int fin, float distancia)
        {
            if (inicio < nNodos && fin < nNodos)
            {
                Arco arco = multigrafo[inicio, fin].FirstOrDefault(a => a.distancia == distancia);
                if (arco != null)
                {
                    multigrafo[inicio, fin].Remove(arco);
                    if (multigrafo[inicio, fin].Count == 0) multigrafo[inicio, fin] = null;
                    return true;
                }
            }
            return false;
        }
        public bool setArcoPrioritario(int inicio, int fin, float distancia, bool prioritario = true)
        {
            if (inicio < nNodos && fin < nNodos)
            {
                if (prioritario) multigrafo[inicio, fin].ForEach(a => a.setPrioritario(false));

                Arco arco = multigrafo[inicio, fin].FirstOrDefault(a => a.distancia == distancia);
                if (arco != null)
                {
                    arco.setPrioritario(prioritario);
                    return true;
                }
            }
            return false;
        }

        private Arco getArcoPorDefecto(int inicio,int fin)
        {
            Arco arco;
            if (multigrafo[inicio, fin] == null)
                return null;
            else
            {
                arco=multigrafo[inicio, fin].FirstOrDefault(a => a.prioritario == true);
                if (arco != null)
                    return arco;
                else
                    return multigrafo[inicio, fin].OrderBy(a => a.distancia).First();
            }
        }
        private Arco getArcoOptimo(int inicio, int fin)
        {
            if (multigrafo[inicio, fin] == null)
                return null;
            else
                return multigrafo[inicio, fin].OrderBy(a => a.distancia).First();
        }

        public Grafo getGrafo()
        {
            Grafo g = new Grafo(nNodos);

            for (int f = 0; f < nNodos; f++)
                for (int c = 0; c < nNodos; c++)
                    g.addArco(f, c, getArcoPorDefecto(f,c)?.distancia);

            return g;
        }
        public Grafo getGrafoOptimo()
        {
            Grafo g = new Grafo(nNodos);

            for (int f = 0; f < nNodos; f++)
                for (int c = 0; c < nNodos; c++)
                    g.addArco(f, c, getArcoOptimo(f, c)?.distancia);

            return g;
        }

    }
}
