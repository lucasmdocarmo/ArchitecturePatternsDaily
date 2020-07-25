using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Daily.DesignPatterns.Structural.Adapter
{
    public class ExecutionAdapter
    {
        public static void Execute()
        {
            Console.WriteLine("Adapter Pattern");
            IAdapter _adapter = new Adapter();
            Pessoa pessoa = new Pessoa("Lucas", 28, "Belo Horizonte");

            Console.WriteLine("Pessoa Class to Adapt");
            WriteLine("Pessoa Class is: Nome: {0} ,Idade: {1} ,Local: {2} ", pessoa.Nome, pessoa.Idade, pessoa.Local);

            Console.WriteLine("Calling Adapter");
            var response = _adapter.ToAdapter(pessoa);
            Console.WriteLine("Calling Adaptee");

            Console.WriteLine("Person Class to Adapt");
            WriteLine("Person Class is: Name: {0} ,Age: {1} ,Location: {2} ", response.Name, response.Age, response.Location);
        }

    }
}
