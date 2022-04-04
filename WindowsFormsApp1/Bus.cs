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

        public Bus()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void btnCaminoMinimo_Click(object sender, EventArgs e)
        {
            lstRuta.Items.Clear(); 
            dgvCaminoMinimo.Columns.Clear();

            //Crea Multigrafo a partir de los tramos
            int nNodos = lstParadas.Count();
            multigrafo = new Multigrafo(nNodos,chkBucle.Checked);

            foreach (Tramo tramo in lstTramos)
            {
                int iOrigen = lstParadas.IndexOf(lstParadas.FirstOrDefault(p => p.IdParada == tramo.IdOrigen));
                int iDestino = lstParadas.IndexOf(lstParadas.FirstOrDefault(p => p.IdParada == tramo.IdDestino));
                multigrafo.addArco(iOrigen, iDestino,tramo.Longitud);
            }

            //calcula el camino mínimo sobre el grafo óptimo
            caminoMinimo = new FloydWarshall(multigrafo.getGrafo(true));

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
