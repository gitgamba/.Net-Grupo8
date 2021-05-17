using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AuthTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = AuthTestings1.Program.Something();
            Assert.AreEqual("Algo", result);
        }

        [TestMethod] //si no lo ponemos no nos evalua 
         public void TestLoginTrue()

        { bool result = AuthTestings1.Program.Login("rafael", "123456");
            Assert.AreEqual(true, result);

        }
    }
}
