using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_API
{
    class Program
    {
        //To ensure a low level of coupling, IE avoiding creating new objects, it should be interfaces that are called instead. 
        static void Main(string[] args)
        {
            IAPI API = Factory.CreateAPI();
            IBook bppl = Factory.CreateBook();
            Console.WriteLine("type the name of the book you wish to see reviews for \n");
            string title = Console.ReadLine();
            //little messy, but should do the job. 
            Console.WriteLine(API.FindReviews(title));
        }
    }
}
