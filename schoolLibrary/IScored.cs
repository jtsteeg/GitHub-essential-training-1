using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolLibrary
{
    public interface IScored
    {
        float Score { get; set; }
        float MaxScore { get; set; }
    }
}
