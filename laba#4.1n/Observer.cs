using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4._1n
{
    class Observer
    {
       /* private string name;*/
        public Observer()
        {

            /*this.name = name;*/
        }
        public void notifyMarked(Base who, Graphics gr)
        {
            who.mark();
            who.draw(gr);
        }
    }
}
