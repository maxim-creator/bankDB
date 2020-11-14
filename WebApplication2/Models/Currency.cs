using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDBLybrary.Models
{
    public class Currency
    {
        public long ID { get; set; }
        [Display(Name = "название курса")]
        public string name { get; set; }
        [Display(Name = "Курс обмена")]
        public double exchangeRate { get; set; }
        [Display(Name = "c")]
        public ICollection<Contribution> contributions { get; set; }

    }
}
