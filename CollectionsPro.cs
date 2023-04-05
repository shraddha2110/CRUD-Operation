using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    //public class Employee : IComparable
    //{
    //    private string name;
    //    private int salary;
    //    public Employee(string name, int salary)
    //    {
    //        this.name = name;
    //        this.salary = salary;
    //    }

    //    public int CompareTo(object obj)
    //    {
           
    //        Employee shraddha = (Employee)obj;
    //        if (this.salary > shraddha.salary)
    //        {
    //            return 1;
    //        }
    //        else if (this.salary < shraddha.salary)
    //        {
    //            return -1;
    //        }
    //        else
    //        {
    //            return 0;
    //        }
    //    }
    //}

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee shraddha = new Employee("shraddha", 50000);
    //        Employee tejal = new Employee("tejal", 40000);

    //        int result = tejal.CompareTo(shraddha);
    //        if (result == 1)
    //        {
    //            Console.WriteLine("tejal's salary is more than shraddha");
    //        }
    //        else if (result == -1)
    //        {
    //            Console.WriteLine("shraddha's salary is more than tejal");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Both employees salary is same");
    //        }
    //    }
    //}

    //Working with IComparer & IComparer <T>
    public class Employee : IComparable
    {
        private string name;
        private int Salary;
        public int Salary
        {
            get { return Salary; }
        }
        public Employee(string name, int salary)
        {
            this.name = name;
            this.Salary = salary;
        }

        public int CompareTo(object obj)
        {
            Employee hp = (Employee)obj;
            if (this.Salary > shraddha.salary)
            {
                return 1;
            }
            else if (this.Salary < shraddha.salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }
    public class Emp
    {
        public string Name { get; set; }
        public double Salary { get; set; }
    }


    public class Test : IComparer
    {
        public int Compare(object x, object y)// x-> dell , y=hp
        {
            if (typeof(Emp) == x.GetType())// Emp == Emp
            {
                Emp e1 = (Emp)x;
                Emp e2 = (Emp)y;
                if (e1.Salary > e2.Salary)
                    return 1;
                else if (e1.Salary < e2.Salary)
                    return -1;
                else
                    return 0;
            }
            else if (typeof(Salary) == x.GetType()) // Product==Product
            {
                Employee s1 = (Employee)x;
                Employee s2 = (Employee)y;
                if (s1.Salary > s2.Salary)
                    return 1;
                else if (s1.Salary < s2.Salary)
                    return -1;
                else
                    return 0;
            }
            else
            {
                return -2;
            }
        }
    }
    public class ComparePrice : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.Salary > y.Salary)
                return 1;
            else if (x.Salary < y.Salary)
                return -1;
            else
                return 0;
        }
    }
    public class CompareSalary : IComparer<Emp>
    {
        public int Compare(Emp x, Emp y)
        {
            if (x.Salary > y.Salary)
                return 1;
            else if (x.Salary < y.Salary)
                return -1;
            else
                return 0;
        }
    }
    public class Program1
    {
        static void Main(string[] args)
        {
            Employee shraddha = new Employee("shraddha", 30000);
            Employee tejal = new Employee("tejal", 40000);

            Emp e1 = new Emp { Name = "Kishor", Salary = 67000 };
            Emp e2 = new Emp { Name = "Amol", Salary = 75000 };

            Test t1 = new Test();
            t1.Compare(tejal, shraddha);

            t1.Compare(e1, e2);
            

            CompareSalary cs = new CompareSalary();
            cs.Compare(e1, e2);

            ComparePrice cp = new ComparePrice();
            int result = cp.Compare(tejal, shraddha);
            //  int result= dell.CompareTo(hp);
            if (result == 1)
            {
                Console.WriteLine("tejal's salary is more than shraddha");
            }
            else if (result == -1)
            {
                Console.WriteLine("shraddha's salary is more than tejal");
            }
            else
            {
                Console.WriteLine("Both employees salary is same");
            }
        }
    }

}
