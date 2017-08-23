using System.Collections;
using System.Collections.Generic;

namespace CatsAndOwners.Models
{
    public class Owner
    {
        public int Age { get; set; }

        public Gender Gender { get; set; }

        public string Name { get; set; }

        public IList<Pet> Pets { get; set; }
    }
}
