using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Login
{
    [TestFixture]
    public class SignIn
    {
        [Test]
        public void SignInTest()
        {
            string empResult = "userName and password should not null and Empty";
            string invaildResult = "invalid Details";
            string passResult = "Login Succesfully";
            Assert.AreEqual(empResult, Program.SignIn(null,null));
            Assert.AreEqual(empResult, Program.SignIn("", ""));
            Assert.AreEqual(invaildResult, Program.SignIn("Ram", "Ram@13"));
            Assert.AreEqual(passResult, Program.SignIn("venkatesh", "venkat@123"));
        }
    }
}
