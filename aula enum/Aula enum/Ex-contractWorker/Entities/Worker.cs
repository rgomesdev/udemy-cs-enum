using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex_contractWorker.Entities.Enums;

namespace Ex_contractWorker.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel level { get; set; }
        public double BaseSalary { get; set; }
        public Departament departament { get; set; }
        public List<HourContract> contracts { get; set; }
    }
}
