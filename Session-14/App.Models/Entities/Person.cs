using App.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.Entities
{
    [Serializable]
    public class Person : Item
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get; }

        public Person()
        {
            Name = string.Empty;
            Surname = string.Empty;
            FullName = $"{Name} {Surname}";
        }
    }
}
