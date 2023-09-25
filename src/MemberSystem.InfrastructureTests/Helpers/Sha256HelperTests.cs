using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MemberSystem.Infrastructure.Helpers.Tests
{
    [TestClass()]
    public class Sha256HelperTests
    {
        [TestMethod()]
        [DataRow("123456", "8D969EEF6ECAD3C29A3A629280E686CF0C3F5D5A86AFF3CA12020C923ADC6C92")]
        [DataRow("12345678", "EF797C8118F02DFB649607DD5D3F8C7623048C9C063D532CC95C5ED7A898A64F")]
        [DataRow("ABCedf!1234453567", "342655D386409B2961A4B0EBE708FDE05FD3E3DA37A649A6EA6246F0E04879F4")]

        public void ComputeSHA256Test(string password, string expected)
        {
            var actual = Sha256Helper.ComputeSHA256(password);
            Assert.AreEqual(expected, actual);
        }
    }
}