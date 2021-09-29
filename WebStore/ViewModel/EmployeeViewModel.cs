using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebStore.ViewModel
{
    public class EmployeeViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Имя"), Required(ErrorMessage = "Имя не указано")]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия"), Required(ErrorMessage = "Фамилия не указана")]
        public string LastName { get; set; }

        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }

        [Display(Name = "Возраст")]
        public int Age { get; set; }
    }
}
