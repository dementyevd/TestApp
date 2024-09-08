using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAreaLibrary
{
    public abstract class FigureCreator
    {
        public abstract Figure Create();
        protected abstract bool isValid();
    }
}
