using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using Dapper_Exercise;
//^^^^MUST HAVE USING DIRECTIVES^^^^

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
string connString = config.GetConnectionString("DefaultConnection");
IDbConnection conn = new MySqlConnection(connString);

var repo = new DapperDeptRepo(conn);

Console.WriteLine("Type a new department name: ");

var newDepartment = Console.ReadLine();

repo.InsertDepartment(newDepartment);

var departments = repo.GetAllDepartments();

foreach(var department in departments)
{
    Console.WriteLine($"{department.Name} | {department.DepartmentID}");
}

var repo2 = new DapperProductRepo(conn);

Console.WriteLine("Type a new product name: ");

var newProduct = Console.ReadLine();


var products = repo2.GetAllProducts();

foreach (var product in products)
{
    Console.WriteLine($"{product.Name} | {product.ProductID}");
}