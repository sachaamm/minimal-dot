using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp1.Controllers;
using ConsoleApp1.Models;
using ConsoleApp1.Test;
using ConsoleApp1.Utility;

namespace ConsoleApp1
{
    class Program
    {
        public static Dictionary<Type, object> Services = new Dictionary<Type, object>();
        
        static void Main(string[] args)
        {

            // var a = ReflectionUtility.GetEnumerableOfType<Service.Service>();
            
            Router router = new Router();

            router.StartListener();
        }

        static void CreateServices()
        {
            
        }
    }
}
