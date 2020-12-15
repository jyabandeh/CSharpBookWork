using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10PP01_EmployeeWorkerClasses
{
    class ProductionWorker : Employee
    {
        public string WorkShift { get; set; }
        public decimal HourlyPayRate { get; set; }

        public ProductionWorker() : base() { }
    }
}
