using System.Collections.Generic;

namespace DependencyInversion_API
{
    interface IBook
    {
        List<string> Reviews { get; set; }
        string Title { get; set; }
    }
}