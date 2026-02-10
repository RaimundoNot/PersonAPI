using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Person.Models
{
    public class PersonModels
    {
        public PersonModels(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; init; }
        public string Name { get; private set; }
        
        // metodo utilizado para atualizar o nome
        public void ChangeName(string name)
        {
            Name = name;
        }

        //metodo utilizado para deletar o nome - Soft Delete
        public void SetInactive()
        {
            Name = "desativado";
        }
    }
}