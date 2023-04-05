//using System;
//using System.Collections.Generic;

//namespace ConsoleCRUD
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            ProductCRUD productCRUD = new ProductCRUD();
//            int c = 0;
//            do
//            {
//                Console.Clear(); // clear the previous output
//                Console.WriteLine("1. Product List");
//                Console.WriteLine("2. Add Product");
//                Console.WriteLine("3. Update Product");
//                Console.WriteLine("4. Delete Product");
//                Console.WriteLine("select above option");
//                int op = Convert.ToInt32(Console.ReadLine());
//                switch (op)
//                {
//                    case 1:
//                        List<Product> prods = productCRUD.List();
//                        Console.WriteLine("Id \t Name \t\t Price");
//                        foreach (Product p in prods)
//                        {
//                            Console.WriteLine($"{p.Id} \t {p.Name} \t\t {p.Price}");
//                        }
//                        break;
//                    case 2:
//                        Product p1 = new Product();
//                        Console.WriteLine("Enter Id");
//                        p1.Id = Convert.ToInt32(Console.ReadLine());
//                        Console.WriteLine("Enter product name");
//                        p1.Name = Console.ReadLine();
//                        Console.WriteLine("Enter Price");
//                        p1.Price = Convert.ToInt32(Console.ReadLine());
//                        productCRUD.AddProduct(p1);
//                        Console.WriteLine("Product added..");
//                        break;

//                    case 3:
//                        Product p2 = new Product();
//                        Console.WriteLine("Enter Id");
//                        p2.Id = Convert.ToInt32(Console.ReadLine());
//                        Console.WriteLine("Enter new product name");
//                        p2.Name = Console.ReadLine();
//                        Console.WriteLine("Enter new Price");
//                        p2.Price = Convert.ToInt32(Console.ReadLine());
//                        productCRUD.UpdateProduct(p2);
//                        Console.WriteLine("Product updated..");
//                        break;
//                    case 4:
//                        Console.WriteLine("Enter Id to delete");
//                        int id = Convert.ToInt32(Console.ReadLine());
//                        productCRUD.DeleteProduct(id);
//                        Console.WriteLine("Product deleted..");
//                        break;
                    
//                    case 5:
//                        Console.WriteLine("Enter product id to search");
//                        int id2 = Convert.ToInt32(Console.ReadLine());
//                        Product product = productCRUD.GetProductById(id2);
//                        if (product.Id > 0)
//                            Console.WriteLine($"Id = {product.Id} , Name ={product.Name}, Price= {product.Price}");
//                        else
//                            Console.WriteLine("Product not found..");
//                        break;

//                    default:
//                        Console.WriteLine("Wrong option selection..");
//                        break;

//                }
//                Console.WriteLine("Select 1 for continue");
//                c = Convert.ToInt32((Console.ReadLine()));
//            }
//            while (c == 1);
//        }
//    }
//     public class Program1
//    {
//        static void Main(string[] args)
//        {
//            EmployeeCRUD productCRUD = new EmployeeCRUD();
//            int c = 0;
//            do
//            {
//                Console.Clear(); // clear the previous output
//                Console.WriteLine("1. Employee List");
//                Console.WriteLine("2. Add Employee");
//                Console.WriteLine("3. Update Employee");
//                Console.WriteLine("4. Delete Employee");
//                Console.WriteLine("select above option");
//                int op = Convert.ToInt32(Console.ReadLine());
//                switch (op)
//                {
//                    case 1:
//                        List<Employee> emp = employeeCRUD.List();
//                        Console.WriteLine("Id \t Name \t\t Salary");
//                        foreach (Employee e in emp)
//                        {
//                            Console.WriteLine($"{p.Id} \t {p.Name} \t\t {p.Salary}");
//                        }
//                        break;
//                    case 2:
//                        Employee p1 = new Employee();
//                        Console.WriteLine("Enter Id");
//                        p1.Id = Convert.ToInt32(Console.ReadLine());
//                        Console.WriteLine("Enter employee name");
//                        p1.Name = Console.ReadLine();
//                        Console.WriteLine("Enter Salary");
//                        p1.Price = Convert.ToInt32(Console.ReadLine());
//                        employeeCRUD.AddEmployee(p1);
//                        Console.WriteLine("Employee added..");
//                        break;

//                    case 3:
//                        Product p2 = new Product();
//                        Console.WriteLine("Enter Id");
//                        p2.Id = Convert.ToInt32(Console.ReadLine());
//                        Console.WriteLine("Enter new employee name");
//                        p2.Name = Console.ReadLine();
//                        Console.WriteLine("Enter new Salary");
//                        p2.Price = Convert.ToInt32(Console.ReadLine());
//                        employeeCRUD.UpdateEmployee(p2);
//                        Console.WriteLine("Employee updated..");
//                        break;
//                    case 4:
//                        Console.WriteLine("Enter Id to delete");
//                        int id = Convert.ToInt32(Console.ReadLine());
//                        employeeCRUD.DeleteEmployee(id);
//                        Console.WriteLine("Employee deleted..");
//                        break;
                    
//                    case 5:
//                        Console.WriteLine("Enter employee id to search");
//                        int id2 = Convert.ToInt32(Console.ReadLine());
//                        Employee employee = employeeCRUD.GetEmployeeById(id2);
//                        if (employee.Id > 0)
//                            Console.WriteLine($"Id = {employee.Id} , Name ={employee.Name}, Price= {employee.Price}");
//                        else
//                            Console.WriteLine("Employee not found..");
//                        break;

//                    default:
//                        Console.WriteLine("Wrong option selection..");
//                        break;

//                }
//                Console.WriteLine("Select 1 for continue");
//                c = Convert.ToInt32((Console.ReadLine()));
//            }
//            while (c == 1);
//        }
//    }
//}
