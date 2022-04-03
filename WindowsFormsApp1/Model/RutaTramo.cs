using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedTransporte.Model
{
    class RutaTramo
    {
        [JsonProperty("IdRuta")]
        public int IdRuta { get; set; }

        [JsonProperty("Orden")]
        public int Orden { get; set; }

        [JsonProperty("IdTramo")]
        public int IdTramo { get; set; }
    }
}
