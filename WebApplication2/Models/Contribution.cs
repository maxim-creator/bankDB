using System;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;

namespace WebDBLybrary.Models
{
    public class Contribution
    {
        [Display (Name = "Код вклада")]
        public long ID { get; set; }
        [Display(Name = "Название вклада")]
        public string ContributionName { get; set; }
        [Display(Name = "Минимальное время вклада")]
        public int minTime { get; set; }
        [Display(Name = "Максимальное время вклада")]
        public int maxTime { get; set; }
        [Display(Name = "Процентная ставка")]
        public double InterestRate { get; set; }
        [Display(Name = "дополнительные условия")]
        public String AdditionalConditions { get; set; }

        [Display(Name = "Курс")]
        public long? CurrencyID { get; set; }
        [Display(Name = "Курс")]
        public virtual Currency currerncy { get; set; }


        [Display(Name = "Сотрудник")]
        public long? EmployeeID { get; set; }
        [Display(Name = "Работник")]
        public virtual Employee employee { get; set; }


        [Display(Name = "Вкладчик")]
        public long? DepositorID { get; set; }
        [Display(Name = "Вкладчик")]
        public virtual Depositor depositor { get; set; }



    }
}
