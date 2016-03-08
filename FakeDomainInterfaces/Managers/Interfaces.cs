using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeDomainInterfaces.Models;

namespace FakeDomainInterfaces.Managers
{
    public interface IBooksManager : IManager<IBook>
    {
        void DoSomethingNotDefinedByInterface();
    }
}
