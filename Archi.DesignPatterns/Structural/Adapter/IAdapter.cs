using System;
using System.Collections.Generic;
using System.Text;

namespace Daily.DesignPatterns.Structural.Adapter
{
    public interface IAdapter
    {
        Person ToAdapter(Pessoa pessoa);
    }
}
