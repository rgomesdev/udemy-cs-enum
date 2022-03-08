using Ex_contractWorker.Entities.Enums;
using System;
using System.Globalization;
using Ex_contractWorker.Entities;

namespace Ex_contractWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome do departamento:");
            string depName = Console.ReadLine();
            Console.WriteLine("Informe os dados do trabalhador:");
            Console.Write("Nome:");
            string name = Console.ReadLine();
            Console.Write("Nível(Junior/MidLever/Senior):");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário Base:");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dep = new Departament(depName);
            Worker worker = new Worker(name, level, baseSalary, dep);

            Console.WriteLine("Quantos contratos?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //interpolação de string com variável
                Console.WriteLine($"Entre com os dados do contrato {i}:");
                Console.Write("Data (dd/mm/aaaa):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hoa:");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duração em horas:");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, value, hours);
                worker.AddContract(contract);

            }
            Console.WriteLine("Entre com o mês e ano para calcular o ganho(mm/aaaa):");
            string monthAndYear = Console.ReadLine();
            int year = int.Parse(monthAndYear.Substring(0, 2));
            int month = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Nome do trabalhador: {worker.Name}");
            Console.WriteLine($"Departamento: {worker.Departament.Name}");
            Console.WriteLine($"Ganho em {monthAndYear}: {worker.TotalIncome(year,month)}");


        }
    }
}
