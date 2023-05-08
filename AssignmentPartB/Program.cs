using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AssignmentPartB.Controllers;
using AssignmentPartB.Entities;
using AssignmentPartB.RepositoryServices;
using AssignmentPartB.Views;
using AssignmentPartB.Views.ViewCreates;
using AssignmentPartB.Application;

namespace AssignmentPartB
{
    public class Program
    {
        static void Main(string[] args)
        {                               
            Application_Test app = new Application_Test();
            app.Run();
        }
    }
}
