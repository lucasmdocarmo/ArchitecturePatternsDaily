using System;
using System.Collections.Generic;
using System.Text;

namespace Daily.DesignPatterns.Creational.Prototype
{
    public class Ford : Car, ICloneable
    {
        public Ford(string model, string manufacturer, string year, string country) : base(model, manufacturer, year, country)
        {
        }

        public object Clone()
        {
            return (Ford)this.MemberwiseClone();
        }

        public override Car ManualClone()
        {
            return (Ford)MemberwiseClone();
        }
    }
}
