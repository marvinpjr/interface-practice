using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessingWithInterfaces
{
    public interface IPokable
    {
        bool WasPoked { get; set; }
    }

    public class Person: IPokable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool WasPoked { get; set; }
        public Person(bool wasPoked)
        {
            WasPoked = wasPoked;
        }

        public void Poke(IPokable pokable)
        {
            new PokeHelper().HandlePokeOn(pokable);
        }
    }

    internal class PokeHelper
    {
        internal void HandlePokeOn(IPokable pokable)
        {
            pokable.WasPoked = true;
        }
    }
}
