using Newtonsoft.Json;

namespace HttpCore
{
    public class CurrencyApiModel
    {
        [JsonProperty("Cur_ID")]
        public int CurrencyId { get; set; }

        [JsonProperty("Cur_Code")]
        public int Code { get; set; }

        [JsonProperty("Cur_Name_Eng")]
        public int NameEng { get; set; }

        [JsonProperty("Cur_Abbreviation")]
        public int Abbreviation { get; set; }
    }
}
