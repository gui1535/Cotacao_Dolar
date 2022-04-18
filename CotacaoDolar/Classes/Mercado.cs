using Newtonsoft.Json;

namespace CotacaoDolar.Classes
{
    public class Mercado
    {

        // Construtor
        public Mercado()
        {
            Moeda = new Moeda();
        }

        // Propriedades / Atributos

        [JsonProperty(PropertyName = "currencies")]
        public Moeda Moeda { get; set; }


    }
}
