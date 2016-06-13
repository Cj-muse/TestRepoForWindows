using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intern_Project.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void HomeControllerHasName()
        {
            HomeController home = new HomeController();
        }
    }
}
