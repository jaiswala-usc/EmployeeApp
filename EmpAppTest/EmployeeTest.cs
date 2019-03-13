using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using EmployeeApp;

namespace EmpAppTest
{
    public class EmployeeTest
    {
        Program p = new Program();
        List<EmployeeDetails> li;

        [Fact]
        public void checkDetails()
        {
            //Program p = new Program();
            li = p.AllUsers();
            foreach (var x in li)
            {
                Assert.NotNull(x.id);
                Assert.NotNull(x.name);
                Assert.NotNull(x.salary);
                Assert.NotNull(x.gender);

            }
        }

        [Theory]
        [InlineData("admin", "admin")]
        [InlineData("aj", "123")]
        [InlineData("", "")]
        public void TestLogin(string userID, string password)
        {
            //Program p = new Program();
            string loginResult = p.Login(userID, password);

            Assert.Matches("Welcome admin!", loginResult);
            //Assert.Matches("Invalid userid or password", loginResult);
            //Assert.Matches("Username or password cannot be empty", loginResult);

        }

        [Theory]
        [InlineData(1)]

        public void testDetails(int id)
        {
            var det = p.getDetails(id);

            foreach (var x in det)
            {
                Assert.Equal(1, x.id);
            }
        }
    }
}
