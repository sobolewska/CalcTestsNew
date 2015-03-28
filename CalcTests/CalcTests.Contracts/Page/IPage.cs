using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTests.Contracts.Page
{
    public interface IPage
    {
        string Id { get; }
        void Init();
    }
}
