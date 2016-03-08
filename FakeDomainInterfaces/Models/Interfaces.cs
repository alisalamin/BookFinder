using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDomainInterfaces.Models
{
    public interface IBook : IBO
    {
        int ISBN { get; set; }
        string Title { get; set; }
        string Description { get; set; }
    }
}
