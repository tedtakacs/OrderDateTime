using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Order Date of Interest");
            string userInput = Console.ReadLine();
            DateTime iDate = DateTime.Parse(userInput);
            OrderDateTimeEntities1 orderDateTimeEntities = new OrderDateTimeEntities1();
            ObjectResult<uspOdersOnDate_Result> query = orderDateTimeEntities.uspOdersOnDate(iDate);
        }
    }
}
