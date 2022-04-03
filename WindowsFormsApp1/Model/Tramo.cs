using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedTransporte.Model
{
    class Tramo
    {
        [JsonProperty("IdTramo")]
        public int IdTramo { get; set; }

        [JsonProperty("Codigo")]
        public string Codigo { get; set; }

        [JsonProperty("IdOrigen")]
        public int IdOrigen { get; set; }

        [JsonProperty("IdDestino")]
        public int IdDestino { get; set; }

        [JsonProperty("Longitud")]
        public int Longitud { get; set; }

        [JsonProperty("Duracion")]
        public int Duracion { get; set; }
    }
}
