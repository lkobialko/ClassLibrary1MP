using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1MP
{
    public class HelloWorld
    {
        public static string Main()
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss tt");
            string userName = "Liudmyla";
            return $"{currentTime} Hello, {userName}!";
        }
        }
    }
