using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Alexandre_GROSSE_Ludovic_LI
{
    public interface IObservable
    {
        void Attach(IObserver o);
        void Detach(IObserver o);
        void Notify();
    }
}
