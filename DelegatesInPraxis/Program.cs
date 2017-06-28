using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesInPraxis
{
    public delegate bool MyDelegate(Employee e);
    // Action       -> void
    // Predicate    -> bool
    // Func

    class Program
    {
        static void Main(string[] args)
        {
            var employees = GetData();

            //MyDelegate del = new MyDelegate(Bedingung);
            //Func<Employee, bool> del = new Func<Employee, bool>(Bedingung);
            //var del = new Func<Employee, bool>(Bedingung);
            //Func<Employee, bool> del = Bedingung;
            //var query = Abfrage(employees, del);

            //var query = Abfrage(employees, Bedingung);

            //var query = Abfrage(employees, delegate(Employee e)
            //{
            //    return e.Experience == 5;
            //});

            //var query = Abfrage(employees, (Employee e) =>
            //{
            //    return e.Experience > 5;
            //});

            //var query = Abfrage(employees, (e) =>
            //{
            //    return e.Experience > 5;
            //});

            //var query = MyExtentions.Abfrage(employees, e => e.Experience > 5);
            var query = employees.Abfrage(e => e.Name.Contains("m"));
            var linqQuery = employees
                .Where(e => e.Experience > 5)
                .OrderBy(e => e.Name);

            var y = from e in employees
                    where e.Experience > 5
                    orderby e.Name
                    select e;

            var namen = new[] { "Sepp", "Lukas", "Klaus" };
            var x = MyExtentions.Abfrage(namen, n => n.StartsWith("L"));

            foreach (var e in query)
                Console.WriteLine($"Id: {e.Id} - {e.Name,10} - {e.Experience,2}");

            var i = 4;
            i.Dump();
            "Hy".Dump();
            8.Dump();
            true.Dump();
            false.Dump();
            employees.Dump();
            namen.Dump();

            Console.ReadKey();
        }

        private static bool Bedingung(Employee employee)
        {
            return employee.Name.Length > 4;
        }
        private static IEnumerable<Employee> GetData()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, Name = "Max", Experience = 6 },
                new Employee { Id = 2, Name = "Stanislaus", Experience = 4 },
                new Employee { Id = 3, Name = "Thomas", Experience = 8 },
                new Employee { Id = 4, Name = "Anna", Experience = 9 },
                new Employee { Id = 5, Name = "Luis", Experience = 12 },
                new Employee { Id = 6, Name = "Maria", Experience = 2 },
                new Employee { Id = 7, Name = "Lotte", Experience = 5 },
                new Employee { Id = 8, Name = "Isa", Experience = 8 },
                new Employee { Id = 9, Name = "Hans", Experience = 1 },
            };
        }
    }

    public static class MyExtentions
    {
        public static IEnumerable<T> Abfrage<T>(
            this IEnumerable<T> source,
            Func<T, bool> predicate)
        {
            foreach (var e in source)
                if (predicate(e))
                    yield return e;
        }

        public static void Dump(this object obj)
        {
            if (obj is IEnumerable objects && !(obj is string))
                foreach (var o in objects)
                    Dump(o);
            else
                Console.WriteLine(obj);
        }
    }
}
