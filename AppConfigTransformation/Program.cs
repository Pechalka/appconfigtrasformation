using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace AppConfigTransformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("connection={0} ", ConfigurationManager.ConnectionStrings["SQL-ConnectionString"].ConnectionString);
            Console.WriteLine("app settings={0} ", ConfigurationManager.AppSettings["rabbitMQUrl"]);
            Console.ReadLine();
        }
    }
}
