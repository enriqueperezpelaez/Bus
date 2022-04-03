using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RedTransporte.Class;
using RedTransporte.Model;

namespace RedTransporte
{
    public partial class Bus : Form
    {
        List<Parada> lstParadas;
        List<Tramo> lstTramos;
        List<Ruta> lstRutas;
        List<RutaTramo> lstRutasTramos;
        Multigrafo multigrafo;
        FloydWarshall caminoMinimo;

        //public class FloydWarshall
        //{
        //    float?[,] grafo { get; } 
        //    float?[,] distancias { get; }
        //    int?[,] antecesores;
        //    int nNodos { get; }

        //    public FloydWarshall(float?[,] grafo)
        //    {
        //        this.grafo = grafo;
        //        this.nNodos = grafo.GetLength(0);
        //        distancias = new float?[nNodos, nNodos];
        //        antecesores = new int?[nNodos, nNodos];

        //        for (int f = 0; f < nNodos; f++)
        //            for (int c = 0; c < nNodos; c++)
        //            {
        //                distancias[f, c] = grafo[f, c];
        //                if (grafo[f, c].HasValue) antecesores[f, c] = f;
        //            }

        //        calcFloydWarshall();
        //    } 

        //    private void calcFloydWarshall()
        //    {
        //        float d1, d2;
        //        for (int k = 0; k < nNodos; k++)
        //            for (int i = 0; i < nNodos; i++)
        //                for (int j = 0; j < nNodos; j++)
        //                {
        //                    if (distancias[i, k].HasValue && distancias[k, j].HasValue)
        //                    {
        //                        d1 = distancias[i, j]?? float.MaxValue;
        //                        d2 = distancias[i, k].Value + distancias[k, j].Value;
        //                        if (d2 < d1)
        //                        {
        //                            distancias[i, j] = d2;
        //                            antecesores[i, j] = antecesores[k, j];
        //                        }
        //                    }
        //                }
        //    }

        //    public List<int> getRuta(int inicio,int fin)
        //    {
        //        List<int> ruta = new List<int>() {fin};
        //        int? antecesor = antecesores[inicio, fin];
        //        while (antecesor != inicio && antecesor.HasValue)
        //        {
        //            ruta.Add(antecesor.Value);
        //            antecesor = antecesores[inicio, antecesor.Value];
        //        }

        //        if (antecesor.HasValue)
        //        {
        //            ruta.Add(inicio);
        //            ruta.Reverse();
        //        }
        //        else
        //            ruta=null;

        //        return ruta;
        //    }

        //    public float? getDistanciaMenor(int inicio, int fin)
        //    {
        //        if (inicio < nNodos && fin < nNodos)
        //            return distancias[inicio, fin];
        //        else
        //            return null;
        //    }
        //}

        public Bus()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //float?[,] d = {  { 0,700,200, null , null, null},
            //                {700,0,300,200,null,400},
            //                {200,300,0,700,600,null},
            //                {null,200,700,0,300,100 },
            //                {null,null,600,300,0,500},
            //                {null,400, null,100,500,0 }
            //};
            //FloydWarshall f = new FloydWarshall(d);
            //List<int> l = f.getRuta(0, 5);
            //f.getDistanciaMenor(0, 5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Multigrafo m = new Multigrafo(6);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstRuta.Items.Clear(); 
            //Crea Multigrafo a partir de los tramos
            dgvCaminoMinimo.Columns.Clear();
            int nNodos = lstParadas.Count();
            multigrafo = new Multigrafo(nNodos,chkBucle.Checked);

            foreach (Tramo tramo in lstTramos)
            {
                int iOrigen = lstParadas.IndexOf(lstParadas.FirstOrDefault(p => p.IdParada == tramo.IdOrigen));
                int iDestino = lstParadas.IndexOf(lstParadas.FirstOrDefault(p => p.IdParada == tramo.IdDestino));
                multigrafo.addArco(iOrigen, iDestino,tramo.Longitud);
            }

            //calcula el camino mínimo
            caminoMinimo = new FloydWarshall(multigrafo.getGrafoOptimo());

            //rellena grid con los datos cálculados de camino mínimo
            dgvCaminoMinimo.ColumnCount = nNodos + 1;
            dgvCaminoMinimo.RowHeadersDefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;
            dgvCaminoMinimo.Columns[0].DefaultCellStyle = dgvCaminoMinimo.ColumnHeadersDefaultCellStyle;
            dgvCaminoMinimo.Columns[0].Width = 60;
            dgvCaminoMinimo.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCaminoMinimo.Columns[0].HeaderText = "Paradas";

            for (int f = 0; f < nNodos; f++)
            {
                dgvCaminoMinimo.Columns[f + 1].HeaderText = lstParadas.ElementAt(f).IdParada.ToString();
                dgvCaminoMinimo.Columns[f + 1].Width=50;
                dgvCaminoMinimo.Columns[f + 1].SortMode = DataGridViewColumnSortMode.NotSortable;
                object[] fila=new object[nNodos+1];
                fila[0] = lstParadas.ElementAt(f).IdParada.ToString();
                for (int c = 0; c < nNodos; c++)
                {
                    fila[c+1]= caminoMinimo.getDistanciaMenor(f, c);
                }
                dgvCaminoMinimo.Rows.Add(fila);
                dgvCaminoMinimo.Rows[f].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            
        }

        private void cargarDatos()
        {
            lstParadas = JsonConvert.DeserializeObject<List<Parada>>(RedTransporte.Properties.Resources.Paradas);
            lstTramos = JsonConvert.DeserializeObject<List<Tramo>>(RedTransporte.Properties.Resources.Tramos);
            lstRutas = JsonConvert.DeserializeObject<List<Ruta>>(RedTransporte.Properties.Resources.Rutas);
            lstRutasTramos = JsonConvert.DeserializeObject<List<RutaTramo>>(RedTransporte.Properties.Resources.RutaTramo);
            dgvParadas.DataSource = lstParadas;
            dgvTramos.DataSource = lstTramos;
            dgvRutas.DataSource = lstRutas;
        }

        private void dgvRutas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Ruta ruta = lstRutas.ElementAt(e.RowIndex);

            var query =
                from rutaTramo in lstRutasTramos.Where(rt => rt.IdRuta == ruta.IdRuta)
                join tramo in lstTramos on rutaTramo.IdTramo equals tramo.IdTramo
                orderby(rutaTramo.Orden)
                select tramo;

            List<Tramo> lstTramosRuta= query.ToList();

            dgvTramosRuta.DataSource = lstTramosRuta;
        }

        private void dgvCaminoMinimo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<int> lstParadasRuta = caminoMinimo.getRuta(e.RowIndex, e.ColumnIndex - 1);
            lstRuta.Items.Clear();
            foreach (int p in lstParadasRuta)
            {
                Parada parada = lstParadas.ElementAt(p);
                lstRuta.Items.Add(parada.IdParada + " - " + parada.Descripcion);
            }
        }
    }
}
