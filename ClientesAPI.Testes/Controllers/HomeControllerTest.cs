using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientesAPI;
using ClientesAPI.Controllers;

namespace ClientesAPI.Testes.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Organizar
            HomeController controller = new HomeController();

            // Agir
            ViewResult result = controller.Index() as ViewResult;

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
