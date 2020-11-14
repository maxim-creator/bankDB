using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDBLybrary.Models
{
    public class Employee
    {
        public long ID { get; set; }
        [Display(Name = "Возраст")] 
        public int age { get; set; }
        [Display(Name = "Пол")] 
        public string sex{ get; set; }

        [Display(Name = "Имя")]
        public string name { get; set; }
        [Display(Name = "Адрес")]
        public string adress { get; set; }
        [Display(Name = "Телфон")]
        public string phone { get; set; }
        [Display(Name = "Паспортные данные")]
        public string pasportData { get; set; }
        [Display(Name = "Вклад")]
        public long? contributionID { get; set; }


        [Display(Name = "Должность")]
        public long? positionId { get; set; }
        [Display(Name = "Должность")]
        public virtual Position position { get; set; }




        [Display(Name = "Вклад")] 
        public virtual ICollection<Contribution> contributions { get; set; }

        public virtual ICollection<Depositor> depositors { get; set; }
    }
}
