using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_API
{
    interface IAPI
    {
       Task<IBook> FindReviews(string title);
    }
}
