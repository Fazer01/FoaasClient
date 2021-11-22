using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FoaasClient
{
    public class FoaasClient : IFoaasClient
    {
        private readonly HttpClient _httpClient;

        public FoaasClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        private async Task<FoaasResponse> RequestAsync(string operation, params string[] parameters)
        {

            Flurl.Url url = new Flurl.Url("https://foaas.com");
            url.AppendPathSegment(operation);
            url.AppendPathSegments(parameters);

            var response = await _httpClient.GetStringAsync(url);

            if (string.IsNullOrEmpty(response)) return new FoaasResponse();

            return JsonSerializer.Deserialize<FoaasResponse>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true});
        }

        public async Task<FoaasResponse> Absolutely(string company, string from)
        {
            return await RequestAsync("absolutely", company, from);
        }

        public async Task<FoaasResponse> Anyway(string company, string from)
        {
            return await RequestAsync("anyway", company, from);
        }

        public async Task<FoaasResponse> Asshole(string from)
        {
            return await RequestAsync("asshole", from);
        }

        public async Task<FoaasResponse> Awesome(string from)
        {
            return await RequestAsync("awesome", from);
        }

        public async Task<FoaasResponse> Back(string name, string from)
        { 
            return await RequestAsync("back", name, from);
        }

        public async Task<FoaasResponse> Bag(string from)
        {
            return await RequestAsync("bag", from);
        }

        public async Task<FoaasResponse> Ballmer(string name, string company, string from)
        {
            return await RequestAsync("ballmer", name, company, from);
        }

        public async Task<FoaasResponse> Bday(string name, string from)
        {
            return await RequestAsync("bday", name, from);
        }

        public async Task<FoaasResponse> Because(string from)
        {
            return await RequestAsync("absolutely", from);
        }

        public async Task<FoaasResponse> Blackadder(string name, string from)
        {
            return await RequestAsync("blackadder", name, from);
        }

        public async Task<FoaasResponse> Bm(string name, string from)
        {
            return await RequestAsync("bm", name, from);
        }

        public async Task<FoaasResponse> Bucket(string from)
        {
            return await RequestAsync("bucket", from);
        }

        public async Task<FoaasResponse> Bus(string name, string from)
        {
            return await RequestAsync("bus", name, from);
        }

        public async Task<FoaasResponse> Bye(string from)
        {
            return await RequestAsync("bye", from);
        }

        public async Task<FoaasResponse> Caniuse(string tool, string from)
        {
            return await RequestAsync("caniuse", tool, from);
        }

        public async Task<FoaasResponse> Chainsaw(string name, string from)
        {
            return await RequestAsync("chainsaw", name, from);
        }

        public async Task<FoaasResponse> Cocksplat(string name, string from)
        {
            return await RequestAsync("cocksplat", name, from);
        }

        public async Task<FoaasResponse> Cool(string from)
        {
            return await RequestAsync("cool", from);
        }

        public async Task<FoaasResponse> Cup(string from)
        {
            return await RequestAsync("cup", from);
        }

        public async Task<FoaasResponse> Dalton(string name, string from)
        {
            return await RequestAsync("dalton", name, from);
        }

        public async Task<FoaasResponse> Dense(string from)
        {
            return await RequestAsync("dense", from);
        }

        public async Task<FoaasResponse> Deraadt(string name, string from)
        {
            return await RequestAsync("deraadt", name, from);
        }

        public async Task<FoaasResponse> Diabetes(string from)
        {
            return await RequestAsync("diabetes", from);
        }

        public async Task<FoaasResponse> Donut(string name, string from)
        {
            return await RequestAsync("donut", name, from);
        }

        public async Task<FoaasResponse> Dosomething(string dO, string something, string from)
        {
            return await RequestAsync("dosomething", dO, something, from);
        }

        public async Task<FoaasResponse> Dumbledore(string from)
        {
            return await RequestAsync("dumbledore", from);
        }

        public async Task<FoaasResponse> Equity(string name, string from)
        {
            return await RequestAsync("equity", name, from);
        }

        public async Task<FoaasResponse> Even(string from)
        {
            return await RequestAsync("even", from);
        }

        public async Task<FoaasResponse> Everyone(string from)
        {
            return await RequestAsync("everyone", from);
        }

        public async Task<FoaasResponse> Everything(string from)
        {
            return await RequestAsync("everything", from);
        }

        public async Task<FoaasResponse> Family(string from)
        {
            return await RequestAsync("family", from);
        }

        public async Task<FoaasResponse> Fascinating(string from)
        {
            return await RequestAsync("fascinating", from);
        }

        public async Task<FoaasResponse> Fewer(string name, string from)
        {
            return await RequestAsync("fewer", name, from);
        }

        public async Task<FoaasResponse> Field(string name, string from, string reference)
        {
            return await RequestAsync("donut", name, from, reference);
        }

        public async Task<FoaasResponse> Flying(string from)
        {
            return await RequestAsync("flying", from);
        }

        public async Task<FoaasResponse> Ftfy(string from)
        {
            return await RequestAsync("ftfy", from);
        }

        public async Task<FoaasResponse> Fts(string name, string from)
        {
            return await RequestAsync("fts", name, from);
        }

        public async Task<FoaasResponse> Fyyff(string from)
        {
            return await RequestAsync("fyyff", from);
        }

        public async Task<FoaasResponse> Gfy(string name, string from)
        {
            return await RequestAsync("gfy", name, from);
        }

        public async Task<FoaasResponse> Give(string from)
        {
            return await RequestAsync("give", from);
        }

        public async Task<FoaasResponse> Greed(string noun, string from)
        {
            return await RequestAsync("greed", noun, from);
        }

        public async Task<FoaasResponse> Holygrail(string from)
        {
            return await RequestAsync("holygrail", from);
        }

        public async Task<FoaasResponse> Horse(string from)
        {
            return await RequestAsync("horse", from);
        }
    }
}