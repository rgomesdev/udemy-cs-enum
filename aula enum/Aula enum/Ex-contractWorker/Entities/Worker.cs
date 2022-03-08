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
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Worker()
        {

        }

        //lista não incluída no construtor para ser iniciada vazia
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void DeleteContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

    }
}
