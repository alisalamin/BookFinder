using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FakeDomainInterfaces
{
    public interface IManager<TBO> where TBO : IBO
    {
        IEnumerable<TBO> GetList();
    }
}
