using System;
using Microsoft.EntityFrameworkCore;

namespace EFCoreProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=DESKTOP-QNQ23OO;Database=CSharpHome;User Id=dipto_user;Password=1234567; ";
            var migrationAssemblyName = typeof(Program).Assembly.FullName;
            var context = new FrameworkContext(connectionString, migrationAssemblyName);
        }
    }
}
