using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server;

namespace BackEndMTAProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataStorage Data = new DataStorage();
            Data.GetMoviesFromFile();

            System.Console.WriteLine("Done");
        }
    }
}
