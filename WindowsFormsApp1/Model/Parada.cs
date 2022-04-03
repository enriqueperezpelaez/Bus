using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedTransporte.Model
{
    class Parada
    {
        [JsonProperty("IdParada")]
        public int IdParada { get; set; }

        [JsonProperty("Codigo")]
        public string Codigo { get; set; }

        [JsonProperty("Descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty("Latitud")]
        public int Latitud { get; set; }

        [JsonProperty("Longitud")]
        public int Longitud { get; set; }
    }
}
