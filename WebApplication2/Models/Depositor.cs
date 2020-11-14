using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDBLybrary.Models
{
    public class Depositor
    {
        public long ID { get; set; }

        [Display(Name = "Паспортные данные")] 
        public string pasportData { get; set; }

        [Display(Name = "Дата вклада")]
        public DateTime conDate { get; set; }

        [Display(Name = "дата возврата")]
        public DateTime retDate { get; set; }

        [Display(Name = "Сумма вклада")]
        public double amount { get; set; }

        [Display(Name = "Сумма возврата")]
        public double amountOfTheRefund { get; set; }

        [Display(Name = "Отметка о возврате")]
        public bool mark { get; set; }


        [Display(Name = "Имя")]
        public string name { get; set; }
        [Display(Name = "Адрес")]
        public string adress { get; set; }
        [Display(Name = "Телфон")]
        public string phone { get; set; }

        public virtual ICollection<Contribution> contributions { get; set; }

        [Display(Name = "Сотрудник")]
        public long? EmployeeID { get; set; }
        [Display(Name = "Сотрудник")]
        public virtual Employee employee { get; set; }

    }
}
