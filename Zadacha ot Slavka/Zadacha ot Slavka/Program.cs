using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_ot_Slavka
{
    //sort workers by salary
    internal class Program
    {
        class Worker
        {
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private string email;

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            private int salary;

            public int Salary
            {
                get { return salary; }
                set { salary = value; }
            }

            public Worker(string name, string email, int salary)
            {
                this.Name = name;
                this.Email = email;
                this.Salary = salary;
            }

            public void showinfo()
            {
                Console.Write($"{name} {email} {salary}");
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Number of workers:");
            int n = int.Parse(Console.ReadLine());

            List<string> workerName = new List<string>();
            List<string> workerEmail = new List<string>();
            List<int> workerSalary = new List<int>();
            List<int> fds = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Name {i+1}: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Email {i+1}: ");
                string email = Console.ReadLine();
                Console.WriteLine($"Salary {i+1}: ");
                int salaty = int.Parse(Console.ReadLine());

                workerName.Add(name);
                workerEmail.Add(email);
                workerSalary.Add(salaty);
                fds.Add(salaty);
            }

            workerSalary.Sort();
            workerSalary.Reverse();

            List<string> newWorkerName = new List<string>();
            List<string> newWorkerEmail = new List<string>();

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    if (workerSalary[i] == fds[k])
                    {
                        newWorkerName.Add(workerName[k]);
                        newWorkerEmail.Add(workerEmail[k]);
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Worker worker = new Worker(newWorkerName[i], newWorkerEmail[i], workerSalary[i]);
                worker.showinfo();
            }
        }
    }
}
