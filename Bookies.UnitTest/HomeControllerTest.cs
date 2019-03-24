using System;
using Bookies.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Bookies.UnitTest
{

    public class HomeControllerTest
    {
        [Fact]
        public void AboutTest()
        {
            HomeController controllerUnderTest = new HomeController();
            var result = controllerUnderTest.About() as ViewResult;
            Assert.Equal("Your application description page.", result.ViewData["Message"]);
        }
        [Fact]
        public void ContactTest()
        {
            HomeController controllerUnderTest = new HomeController();
            var result = controllerUnderTest.Contact() as ViewResult;
            Assert.Equal("Your contact page.", result.ViewData["Message"]);
        }
        
    }
}
