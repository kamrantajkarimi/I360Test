using Microsoft.VisualStudio.TestTools.UnitTesting;
using I360;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToSafeInt11()
        {
            Test.ToSafeInt("33636");
        }

        public void TestToSafeInt12()
        {
            Test.ToSafeInt("336BB");
        }

        public void TestToSafeInt13()
        {
            Test.ToSafeInt("-336");
        }

        public void TestToSafeInt21()
        {
            "33636".ToSafeInt(99999);
        }

        public void TestToSafeInt22()
        {
            "336BB".ToSafeInt(99999);
        }

        public void TestToSafeInt23()
        {
            "-336".ToSafeInt(99999);
        }
    }
}