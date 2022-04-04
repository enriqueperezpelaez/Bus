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
            public void setPrioritario(bool prioritario = true) { this.prioritario = prioritario; }
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

        public void addArco (int inicio, int fin, float distancia, bool prioritario = false)
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
            }
            else
                throw new ArgumentOutOfRangeException("Indice fuera de rango");
        }
        public void deleteArco (int inicio, int fin, float distancia)
        {
            if (inicio < nNodos && fin < nNodos)
            {
                Arco arco = multigrafo[inicio, fin].FirstOrDefault(a => a.distancia == distancia);
                if (arco != null)
                {
                    multigrafo[inicio, fin].Remove(arco);
                    if (multigrafo[inicio, fin].Count == 0) multigrafo[inicio, fin] = null;
                }
            }
            else
                throw new ArgumentOutOfRangeException("Indice fuera de rango");
        }
        public void setArcoPrioritario(int inicio, int fin, float distancia, bool prioritario = true)
        {
            if (inicio < nNodos && fin < nNodos)
            {
                Arco arco = multigrafo[inicio, fin]?.FirstOrDefault(a => a.distancia == distancia);
                if (arco != null)
                {
                    if (prioritario) multigrafo[inicio, fin].ForEach(a => a.setPrioritario(false));
                    arco.setPrioritario(prioritario);
                }
                else
                    throw new ArgumentException(string.Format("No existe el arco ({0},{1}) con distancia {2}",inicio,fin,distancia));
            }
            else
                throw new ArgumentOutOfRangeException("Indice fuera de rango");
        }

        public float? getDistancia(int inicio,int fin, bool optimo=false)
        {
            Arco arco = getArco(inicio, fin, optimo);
            return arco?.distancia;
        }

        private Arco getArco(int inicio, int fin,bool optimo=false)
        {
            if (inicio < nNodos && fin < nNodos)
            {
                Arco arco=null;
                if (!optimo)
                    arco = multigrafo[inicio, fin]?.FirstOrDefault(a => a.prioritario == true);

                if (arco != null)
                    return arco;
                else
                    return multigrafo[inicio, fin]?.OrderBy(a => a.distancia).First();
            }
            else
                throw new ArgumentOutOfRangeException("Indice fuera de rango");
        }

        public Grafo getGrafo(bool optimo = false)
        {
            Grafo g = new Grafo(nNodos);

            for (int f = 0; f < nNodos; f++)
                for (int c = 0; c < nNodos; c++)
                        g.addArco(f, c, getArco(f, c,optimo)?.distancia);

            return g;
        }

    }
}
