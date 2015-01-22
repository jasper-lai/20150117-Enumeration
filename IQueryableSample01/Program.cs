using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq08_6_IQueryable
{
    class Program
    {
        
        private static void TestIEnumerable()
        {
            using (NorthwindEntities ctx = new NorthwindEntities())
            {
                IEnumerable<Employee> emps = ctx.Employees;
                int count = emps.Where(x => x.EmployeeID == 2).Count();

                Console.WriteLine("Count={0}", count);
            }
        }

        private static void TestIQueryable()
        {
            using (NorthwindEntities ctx = new NorthwindEntities())
            {
                IQueryable<Employee> emps = ctx.Employees;
                int count = emps.Where(x => x.EmployeeID == 2).Count();

                Console.WriteLine("Count={0}", count);
            }
        }

        static void Main(string[] args)
        {
            TestIEnumerable();
            TestIQueryable();

            Console.ReadLine();
        }
    }
}
