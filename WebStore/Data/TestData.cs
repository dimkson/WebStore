using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Data
{
    public class TestData
    {
        public static List<Employee> Employees { get; } = new()
        {
            new Employee(1, "Иван", "Иванов", "Иванович", 30),
            new Employee(2, "Петр", "Петров", "Петрович", 40),
            new Employee(3, "Сидр", "Сидоров", "Сидорович", 25)
        };
    }
}
