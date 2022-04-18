using Newtonsoft.Json;

namespace CotacaoDolar.Classes
{
    public class Moeda
    {
        // Propriedades / Atributos

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }


        [JsonProperty(PropertyName = "buy")]
        public decimal Compra { get; set; }


        [JsonProperty(PropertyName = "sell")]
        public decimal Venda { get; set; }


        [JsonProperty(PropertyName = "variation")]
        public decimal Variacao { get; set; }
    }
}
