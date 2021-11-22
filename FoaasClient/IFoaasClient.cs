
namespace FoaasClient
{
    public interface IFoaasClient
    {
        Task<FoaasResponse> Absolutely(string company, string from);
        Task<FoaasResponse> Anyway(string company, string from);
        Task<FoaasResponse> Asshole(string from);
        Task<FoaasResponse> Awesome(string from);
        Task<FoaasResponse> Back(string name, string from);
        Task<FoaasResponse> Bag(string from);
        Task<FoaasResponse> Ballmer(string name, string company, string from);
        Task<FoaasResponse> Bday(string name, string from);
        Task<FoaasResponse> Because(string from);
        Task<FoaasResponse> Blackadder(string name, string from);
        Task<FoaasResponse> Bm(string name, string from);
        Task<FoaasResponse> Bucket(string from);
        Task<FoaasResponse> Bus(string name, string from);
        Task<FoaasResponse> Bye(string from);
        Task<FoaasResponse> Caniuse(string tool, string from);
        Task<FoaasResponse> Chainsaw(string name, string from);
        Task<FoaasResponse> Cocksplat(string name, string from);
        Task<FoaasResponse> Cool(string from);
        Task<FoaasResponse> Cup(string from);
        Task<FoaasResponse> Dalton(string name, string from);
        Task<FoaasResponse> Dense(string from);
        Task<FoaasResponse> Deraadt(string name, string from);
        Task<FoaasResponse> Diabetes(string from);
        Task<FoaasResponse> Donut(string name, string from);
        Task<FoaasResponse> Dosomething(string dO, string something, string from);
        Task<FoaasResponse> Dumbledore(string from);
        Task<FoaasResponse> Equity(string name, string from);
        Task<FoaasResponse> Even(string from);
        Task<FoaasResponse> Everyone(string from);
        Task<FoaasResponse> Everything(string from);
        Task<FoaasResponse> Family(string from);
        Task<FoaasResponse> Fascinating(string from);
        Task<FoaasResponse> Fewer(string name, string from);
        Task<FoaasResponse> Field(string name, string from, string reference);
        Task<FoaasResponse> Flying(string from);
        Task<FoaasResponse> Ftfy(string from);
        Task<FoaasResponse> Fts(string name, string from);
        Task<FoaasResponse> Fyyff(string from);
        Task<FoaasResponse> Gfy(string name, string from);
        Task<FoaasResponse> Give(string from);
        Task<FoaasResponse> Greed(string noun, string from);
        Task<FoaasResponse> Holygrail(string from);
        Task<FoaasResponse> Horse(string from);
    }
}