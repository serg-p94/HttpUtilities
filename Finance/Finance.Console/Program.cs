using HttpCore;
using System.Threading.Tasks;

namespace Finance.Console
{
    class Program
    {
        private const int UsdId = 145;
        private static readonly string FinanceUrl = $"http://www.nbrb.by/API/ExRates/Currencies/{UsdId}";

        static void Main(string[] args)
        {
            Task.Run(async () =>
            {
                var data = await HtmlHelper.GetDataAsync<CurrencyApiModel>(FinanceUrl);
            }).Wait();
        }
    }
}
