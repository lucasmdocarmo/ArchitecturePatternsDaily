using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Daily.DesignPatterns.Structural.Adapter
{
    public class Adapter : IAdapter
    {
        public Person ToAdapter(Pessoa pessoa)
        {
            return new Person(pessoa.Nome, 
                              pessoa.Idade.ToString(), 
                              pessoa.Local);
        }

        
    }

    public class Person
    {
        public Person(string name, string age, string location)
        {
            Name = name;
            Age = age;
            Location = location;
        }

        public string Name { get; set; }
        public string Age { get; set; }
        public string Location { get; set; }
    }

    public class Pessoa
    {
        public Pessoa(string nome, int idade, string local)
        {
            Nome = nome;
            Idade = idade;
            Local = local;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Local { get; set; }
    }
}
