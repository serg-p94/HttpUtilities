using Newtonsoft.Json;

namespace HttpCore
{
    public class CurrencyApiModel
    {
        [JsonProperty("Cur_ID")]
        public int CurrencyId { get; set; }

        [JsonProperty("Cur_Abbreviation")]
        public string Abbreviation { get; set; }
    }
}
