using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationSample02
{
    class Program
    {
        static void Main(string[] args)
        {
            //建立測試資料
            List<Employee> emps = new List<Employee>() 
            {   new Employee { Id = "001", Name="Jasper" }
            ,   new Employee { Id = "002", Name="Judy" }
            ,   new Employee { Id = "003", Name="John" }
            ,   new Employee { Id = "004", Name="Anita"}
            ,   new Employee { Id = "005", Name="Belle"}
            };

            //說明:
            //1. List<Employee> 是採用 List<T> 這個泛型的 constructed type or closed type; 代表程式裡用到的真正資料型態
            //2. List<T> 實作 IEnumerable<T>
            //3. Enumerable 靜態類別提供 IEnumerable<T> 的擴充方法, 例如: Where, Average ... 等
            //4. 因為 Where 是擴充方法, 所以可以直接用  .Where(...) 的方式作處理
            //參考一下:
            //可以順便查一下 Where 對應的源碼, 可以發現, 它是由 Emumeratable 這個靜態類別所提供的擴充方法
            //http://referencesource.microsoft.com/#System.Core/System/Linq/Enumerable.cs,e73922753675387a

            //Lambda Expression
            Console.WriteLine("===== Lambda =====");
            var emps2 = emps.Where(o => o.Name.StartsWith("J"));
            foreach (var item in emps2)
            {
                Console.WriteLine("Id:{0}, Name:{1}", item.Id, item.Name);
            }

            //LINQ Statement
            Console.WriteLine("===== LINQ =====");
            var query = from o in emps
                        where o.Name.StartsWith("J")
                        select o;
            foreach (var item in query)
            {
                Console.WriteLine("Id:{0}, Name:{1}", item.Id, item.Name );
            }

            Console.ReadLine();

            ////Output: 
            //===== Lambda =====
            //Id:001, Name:Jasper
            //Id:002, Name:Judy
            //Id:003, Name:John
            //===== LINQ =====
            //Id:001, Name:Jasper
            //Id:002, Name:Judy
            //Id:003, Name:John
        }
    }
}
