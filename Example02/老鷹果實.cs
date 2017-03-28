using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class 老鷹果實 : 飛行系的果實
    {
        public override void IFlyBehavior.Fly()
        {
            Console.WriteLine("我用老鷹果實飛");
        }
    }
}