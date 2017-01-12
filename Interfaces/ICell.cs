using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banana_Chess
{
    interface ICell
    {
        Figure MyFigure { get; set; }

        bool Empty { get; set; }
    }
}
