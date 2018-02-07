using NUnit.Framework;
using System.Linq;
using EffortTesting;

namespace TestingWithEffort
{
    [TestFixture]
    public class TestClass
    {
        [SetUp]
        public void Setup()
        {
            PFactory.ResetDb();
            using (var context = new MiTestContext())
            {
                context.Contactos.Add(new Contacto
                {
                    Nombre = "Juan Lopez",
                    Correo = "juan@test.com"
                });
                context.SaveChanges();
            }
        }
        [Test]
        public void TestMethod()
        {
            using (var c = new MiTestContext())
            {
                Assert.IsTrue(c.Contactos.Any());
            }
        }
        [Test]
        public void IsJuanLopezTest()
        {
            using (var c = new MiTestContext())
            {
                Assert.AreEqual("Juanjo Lopez",c.Contactos.First().Nombre);
            }
        }
    }
}