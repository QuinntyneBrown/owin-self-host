using System;
using System.Net.Http;
using Microsoft.Owin.Hosting;

namespace Chloe
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9002/";

            //WebApp.Start<Startup>(url: baseAddress);

            Console.ReadLine();
        }
    }
}
