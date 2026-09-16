using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Models
{
    public class Kindklasse1 : AbstractClass
    {
        // alle abstrakten Methoden müssen überschrieben (override) werden
        public override double Calculate()
        {
            return this.Value * 2;
        }
    }
}
