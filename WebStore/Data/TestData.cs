using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Data
{
    public class TestData
    {
        public static List<Employee> Employees { get; } = new()
        {
            new Employee { Id = 1, FirstName = "Иван", LastName = "Иванов", MiddleName = "Иванович", Age = 30 },
            new Employee { Id = 2, FirstName = "Петр", LastName = "Петров", MiddleName = "Петрович", Age = 40 },
            new Employee { Id = 3, FirstName = "Сидр", LastName = "Сидоров", MiddleName = "Сидорович", Age = 25 }
        };
    }
}
