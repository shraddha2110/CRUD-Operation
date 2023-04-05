//using System.Collections.Generic;
//namespace ConsoleCRUD
//{
//    public class EmployeeCRUD
//    {
//        private List<Product> products;
//        public EmployeeCRUD()
//        {
//            employees = new List<Employee>()
//            {
//                new Employee{Id=101,Name="shraddha",Salary=40000},
//                new Employee{Id=102,Name="tejal",Salary=50000},
//            };
//        }

//        public void AddEmployee(Employee emp)
//        {
//            employees.Add(emp);
//        }
//        public void UpdateEmployee(Employee emp)
//        {
//            for (int i = 0; i < employees.Count; i++)
//            {
//                if (employees[i].Id == emp.Id)
//                {
//                    employees[i].Name = emp.Name;
//                    employees[i].Price = emp.Price;
//                    break; // to break the loop
//                }
//            }
//        }
//        public void DeleteProduct(int id)
//        {
//            for (int i = 0; i < products.Count; i++)
//            {
//                if (products[i].Id == id)
//                {
//                    products.Remove(products[i]);
//                    break;
//                }
//            }
//        }
//        public List<Product> List()
//        {
//            return products;
//        }
//        public Product GetProductById(int id)
//        {
//            Product product = new Product();
//            for (int i = 0; i < products.Count; i++)
//            {
//                if (products[i].Id == id)
//                {
//                    product = products[i];
//                }
//            }
//            return product;
//        }

//    }
//}

