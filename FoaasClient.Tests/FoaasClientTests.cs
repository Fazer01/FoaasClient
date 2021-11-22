using FluentAssertions;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace FoaasClient.Tests
{
    public class FoaasClientTests
    {
        private readonly IFoaasClient _foaasClient;
       
        public FoaasClientTests()
        {
            _foaasClient = new FoaasClient(new HttpClient());
        }
            
        [Fact]
        public async Task AbsoluteleyTest()
        {
            var response = await _foaasClient.Absolutely("Microsoft", "Apple");

           
        }

        [Fact]
        public async Task AnyWayTest()
        {
            var company = "Microsoft";
            var from = "Apple";

            var response = await _foaasClient.Anyway("Microsoft", "Apple");
            response.Message.Should().Be($"Who the fuck are you anyway, {company}, why are you stirring up so much trouble, and, who pays you?");
            response.Subtitle.Should().Be($"- {from}");
        }
    }
}