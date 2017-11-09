using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication_First_practice
{
    interface Moveable
    {
        void Forward();
        void Backward();
        void Left();
        void Right();
        void Stop();

    }
}
