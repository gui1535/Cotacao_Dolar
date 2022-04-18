using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDolar.Classes
{
    public class Moeda
    {
        [JsonProperty(PropertyName = Cu)]
        // Propriedades / Atributos
        public string Name { get; set; }
        public decimal Compra { get; set; }
        public decimal Venda { get; set; }
        public decimal Variacao { get; set; }
    }
}
