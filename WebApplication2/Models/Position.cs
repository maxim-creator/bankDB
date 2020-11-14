using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDBLybrary.Models
{
    public class Position
    {
        public long ID { get; set; }
        [Display(Name = "Название должности")] 
        public string name { get; set; }
        [Display(Name = "Зарплата должности")] 
        public long salary { get; set; }
        [Display(Name = "Обязанности должности")] 
        public string duties { get; set; }
        [Display(Name = "Требования должности")] 
        public string requirements { get; set; }

        [Display(Name = "Рабочии этой должности")] 
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
