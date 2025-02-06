using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance02
{
    public class Cleaner:Staff
    {
        public void Input()
        {
            base.Input();
        }
        public void Output() {
            base.Output();
        }
    }
}
