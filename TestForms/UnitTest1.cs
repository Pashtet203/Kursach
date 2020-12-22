using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExampleSQLApp;


namespace TestForms
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RegisterForm register = new RegisterForm();
            Assert.AreEqual(register.IsdigitOrSymbol("12345"), false);
        }
        [TestMethod]
        public void TestMethod2()
        {
            RegisterForm register = new RegisterForm();
            Assert.AreEqual(register.ConfrimSymbol("Stroka="),false);
        }

        [TestMethod]
        public void TestMethod3()
        {
            RegisterForm register = new RegisterForm();
            Assert.AreEqual(register.IsdigitOrSymbol("stroka"), true);
        }

        [TestMethod]
        public void TestMethod4()
        {
            RegisterForm register = new RegisterForm();
            Assert.AreEqual(register.ConfrimSymbol("Stroka-=--==--=-"), false);
        }
    }
}
