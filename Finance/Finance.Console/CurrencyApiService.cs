using HttpCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Finance.Console
{
    public class CurrencyApiService
    {
        public async Task<List<CurrencyApiModel>> GetAllCurrencies()
        {
            var url = Urls.GetCurrenciesUrl();
            return await WebHelper.GetDataAsync<List<CurrencyApiModel>>(url);
        }

        public async Task<CurrencyApiModel> GetCurrency(int currencyId = 0)
        {
            var url = Urls.GetCurrenciesUrl(currencyId);
            return await WebHelper.GetDataAsync<CurrencyApiModel>(url);
        }

        public async Task<CurrencyRateApiModel> GetCurrencyRate(int currencyId = 0)
        {
            var url = Urls.GetRatesUrl(currencyId);
            return await WebHelper.GetDataAsync<CurrencyRateApiModel>(url);
        }


        private static class Urls
        {
            public static string GetCurrenciesUrl(int currencyId = 0)
            {
                return currencyId > 0 ? $"http://www.nbrb.by/API/ExRates/Currencies/{currencyId}" :
                    "http://www.nbrb.by/API/ExRates/Currencies";
            }

            public static string GetRatesUrl(int currencyId)
                => $"http://www.nbrb.by/API/ExRates/Rates/{currencyId}";
        }
    }
}
