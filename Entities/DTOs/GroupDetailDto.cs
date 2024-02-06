using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class GroupDetailDto:IDto
    {
        public string Name {  get; set; }
        public string Description { get; set; }
        public Expense Expense { get; set; }
        public int ExpenseCount { get; set; } 


        

    }
}
