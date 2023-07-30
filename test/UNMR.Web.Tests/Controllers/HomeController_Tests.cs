using System.Threading.Tasks;
using UNMR.Models.TokenAuth;
using UNMR.Web.Controllers;
using Shouldly;
using Xunit;

namespace UNMR.Web.Tests.Controllers
{
    public class HomeController_Tests: UNMRWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}