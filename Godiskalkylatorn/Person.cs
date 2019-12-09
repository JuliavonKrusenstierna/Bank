using System;
using System.Collections.Generic;
using System.Text;

namespace Godiskalkylatorn
{
    [Serializable]


    class Person
    {        
        public int Age { get; set; }
        public int Candies { get; set; }
        public string Name { get;  set; }


        public override string ToString() // för att rätt ska visas i min lista
        {
            return $"{Name} ({Age} år): --> {Candies} godisar";
        }

       
    }
}
