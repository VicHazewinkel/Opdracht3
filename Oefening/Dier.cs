using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening
{
    internal class Dier
    { 
        public string Name { get; set; }

        public Dier(string name)
        {
            Name = name;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Dier))
            {
                return false;   
            }
            return (this.Name == ((Dier)obj).Name);
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
