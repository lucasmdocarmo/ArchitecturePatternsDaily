using System;
using System.Collections.Generic;
using System.Text;

namespace Daily.DesignPatterns.Creational.Prototype
{
    public class Fiat : Car
    {
        public Fiat(string model, string manufacturer, string year, string country) 
                    : base(model, manufacturer, year, country)
        {
        }

        public override Car ManualClone()
        {
            return (Fiat)MemberwiseClone();
        }
    }
}
