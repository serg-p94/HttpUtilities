using Newtonsoft.Json;
using System;

namespace Finance.Console
{
    public class CurrencyRateApiModel : CurrencyApiModel
    {
        [JsonProperty("Date")]
        public DateTime Date { get; set; }

        [JsonProperty("Cur_OfficialRate")]
        public float Rate { get; set; }
    }
}
