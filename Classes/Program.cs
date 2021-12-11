using Classes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(); // obje
            person.Run();

            CustomerService cs = new CustomerService();
            cs.Add();
            cs.Update();
            cs.Delete();
            cs.List();

            Person insan; // declaration
            insan = new Person(); // initialization , instance, obje, nesne, object... 
            insan.Run();

            EmployeeService employeeService = new EmployeeService();
            employeeService.Add();

            ProductService productService = new ProductService();
            productService.List();
            
            Customer customer1 = new Customer();
            customer1.Setname("Yağız");
            customer1.Setsurname("Yılmaz");
            Console.WriteLine(customer1.GetName() + " " + customer1.GetSurname());

            customer1.CreditCardNo = "1234 5678 9012 3456";
            customer1.ErkekMi = true;
            Console.WriteLine(customer1.CreditCardNo + " - " + customer1.Cinsiyet);
            Console.WriteLine(customer1.TitleNameSurname);

            Console.ReadLine();
        }
    }
    #region
    class Person
    {
        public void Run() // behavior: davranış
        {
            Console.WriteLine("Running.");
        }
    }
    class CustomerService // CRUD: Create, Read, Update, Delete
    {
        public void Add()
        {
            Console.WriteLine("Customer added.");
        }
        public void Update()
        {
            Console.WriteLine("Customer updated.");
        }
        public void Delete()
        {
            Console.WriteLine("Customer deleted.");
        }
        public void List()
        {
            Console.WriteLine("Customers Listed.");
        }
    }
}
#endregion
