using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_API
{
    class Factory
    {
        public static IBook CreateBook()
        {
            return new Book();
        }
        public static IAPI CreateAPI()
        {
            return new API();
        }
        
    }

}
