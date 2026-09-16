using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Models
{
    // abstrakte Klasse: 
    //              eine abstrakte Klasse beinhaltet alles, was eine normale
    //              Klasse auch beinhaltet (fields, properties, ctors, methods, ...),
    //              zusätzlich beinhaltet sie abstrakte Methoden
    // abstrakte Methode: besitzt nur einen Methodenkopf, aber keinen Methodencode


    public abstract class AbstractClass
    {

        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                if(value >= 0)
                {
                    _value = value;
                }
            }
        }

        protected AbstractClass()
        {
            Value = 0;
        }

        public string Do()
        {
            return "abstrakt";
        }

        // abstrakte Methode
        //      besitzt keinen Code
        public abstract double Calculate();

    }
}
