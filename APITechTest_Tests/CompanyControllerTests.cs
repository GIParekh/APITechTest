using APITechTest.Controllers;
using APITechTest.DataModel;
using APITechTest.Repositories;
using Castle.Core.Resource;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Moq;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Security.Claims;

namespace APITechTest_Tests
{
    public class CompanyControllerTests
    {     
        public CompanyControllerTests()
        {   
        }

        [Fact]
        public void GetClaimsByCompanyId_WhenCalled_ReturnsOkResult()
        {
            // Arrange
            int comapnyid = 1;
            var claims = new List<ClaimDataModel>
                {
                    new ClaimDataModel
                    {
                        UCR = "UCR 1",
                        CompanyId =1,
                        ClaimDate = DateTime.Now.AddDays(-30),
                        LossDate = DateTime.Now,
                        AssuredName ="Assured Name 1",
                        IncurredLoss =Convert.ToDecimal("100.89"),
                        Closed = true,
                    },
                };

            var repositoryMock = new Mock<ICompanyRepository>();
            repositoryMock
                .Setup(r => r.GetClaimsByCompanyId(comapnyid))
                .Returns(claims);

            var controller = new CompanyController(repositoryMock.Object);

            // Act
            var okResult = controller.GetClaimsByCompanyId(comapnyid);

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }
    }
}