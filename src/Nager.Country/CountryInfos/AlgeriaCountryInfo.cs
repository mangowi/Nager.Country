using Nager.Country.Currencies;

namespace Nager.Country.CountryInfos
{
    /// <summary>
    /// Algeria
    /// </summary>
    public class AlgeriaCountryInfo : ICountryInfo
    {
        public string CommonName => "Algeria";
        public string OfficialName => "People's Democratic Republic of Algeria";
        public Alpha2Code Alpha2Code => Alpha2Code.DZ;
        public Alpha3Code Alpha3Code => Alpha3Code.DZA;
        public int NumericCode => 012;
        public string[] TLD => new [] { ".dz", "الجزائر." };

        public Region Region => Region.Africa;
        public SubRegion SubRegion => SubRegion.NorthernAfrica;

        public Alpha2Code[] BorderCountries => new Alpha2Code[]
        {
            Alpha2Code.TN,
            Alpha2Code.LY,
            Alpha2Code.NE,
            Alpha2Code.EH,
            Alpha2Code.MR,
            Alpha2Code.ML,
            Alpha2Code.MA,
        };

        public ICurrency[] Currencies => new [] { new DzdCurrency() };
        public string[] CallingCodes => new [] { "213" };
    }
}