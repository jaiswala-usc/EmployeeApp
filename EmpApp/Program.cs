using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApp
{
    public class Program
    {

        public string Login(string userId, string password)
        {
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password))
            {
                return "Username or password cannot be empty";
            }
            else if (userId == "admin" && password == "admin")
            {
                return "Welcome admin!";
            }
            else
            {
                return "Invalid userid or password";
            }
        }

        public List<EmpDetails> AllUsers()
        {
            List<EmpDetails> li = new List<EmpDetails>();

            li.Add(new EmpDetails { id = 1, name = "Abhishek", gender = "M", salary = 25 });
            li.Add(new EmpDetails { id = 2, name = "Mohsen", gender = "M", salary = 80 });
            li.Add(new EmpDetails { id = 3, name = "Wyatt", gender = "M", salary = 70 });
            li.Add(new EmpDetails { id = 4, name = "Bob", gender = "M", salary = 120 });
            li.Add(new EmpDetails { id = 5, name = "Megan", gender = "F", salary = 75 });

            return li;
        }

        public List<EmpDetails> getDetails(int userId)
        {
            List<EmpDetails> li1 = new List<EmpDetails>();
            Program p = new Program();
            List<EmpDetails> li = p.AllUsers();
            foreach (var x in li)
            {
                if (x.id == userId)
                {
                    li1.Add(x);
                }
            }
            return li1;

        }
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");
            //Console.ReadKey(); 

            //Program p = new Program();
            //var x = p.AllUsers();

            //foreach (var i in x)
            //{
            //  Console.WriteLine(i.id);
            // Console.WriteLine(i.name);
            //}
        }
    }
}
